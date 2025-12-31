using PacketHandlers;
using Models;
using Nito.AsyncEx;
using Queries;
using Pages;
using DTO;

namespace Controller {

    public class TokenController {

        public readonly AsyncReaderWriterLock Lock;
        private Token? _token;

        public TokenController() {
            this.Lock = new();
            this._token = null;
        }

        public AccessToken? get_token(string token) {

            if (this._token == null)
                return null;

            return this._token.token == token ? this._token.get_access_token() : null;

        }

        public static SendingPacket send_error_token_not_valid() {
            return new PacketFail(401,"Token is not valid or expired");
        }

        public SendingPacket Get() {

            if (Token.is_valid(this._token) == false)
                return new PacketSuccess(404,new Dictionary<string,object?> {
                    ["valid"] = false,
                    ["writer"] = null
                });
            else
                return new PacketSuccess(200,this._token!.to_json_details());

        }

        public SendingPacket Create(IDictionary<string,object> token_data, Config config) {

            if (config.username != (string) token_data["username"] || config.verify_password((string) token_data["password"]) == false)
                return new PacketFail(403,"Username or password does not match up to configuration of system");

            this._token = new Token(true);
            return new PacketSuccess(201,this._token.to_json_created());

        }

        public SendingPacket Delete(AccessToken? token) {
        
            if (token == null)
                return new PacketFail(403,"Token is not valid. Can not remove this token");
            else {
                this._token = null;
                return new PacketSuccess(200,new Dictionary<string,object>{
                    ["message"] = "Token was deleted"
                });
            }

        }

        public SendingPacket Update(IDictionary<string,object> token_data, AccessToken? token, Config config) {

            if (token == null || token.is_valid == false)
                return TokenController.send_error_token_not_valid();

            bool is_writer = (bool) token_data["writer"];

            // Switch to writer mode
            if (is_writer == true) {

                if (token_data.ContainsKey("username") && token_data.ContainsKey("password")) {

                    if (config.username != (string) token_data["username"] || config.verify_password((string) token_data["password"]) == false)
                        return new PacketFail(403,"Username or password does not match up to configuration of system. Could not switch to writer mode!");
                    else
                        this._token!.is_writer = true;

                }
                else
                    return new PacketFail(417,"In order to switch token to writer mode, username and password should be provided");

            }
            // Switch to reader mode
            else {
                this._token!.is_writer = false;
            }

            return new PacketSuccess(200,new Dictionary<string,object?> {
                    ["valid"] = true,
                    ["writer"] = is_writer
                });


        }


    }

}

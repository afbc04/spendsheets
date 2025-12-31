using PacketHandlers;
using Models;
using Nito.AsyncEx;
using DTO;

namespace Controller {

    public class ConfigController {

        // Proprieties
        public readonly AsyncReaderWriterLock Lock;
        private ConfigDAO _dao;

        public bool does_config_exist {private set; get;}
        public Config? config {private set; get;}
        public DateTime last_online_date {private set; get;}
        public bool is_next_month {private set; get;}
        public bool outdated_database {private set; get;}
        private Config? config_to_be_updated;

        // Constructors
        public ConfigController() {
            this.Lock = new();
            this._dao = new ConfigDAO();
        }

        // @@@@@@@@@@@@@@@@@@@@@@@@@
        //  Auxiliar Funcionalities
        // @@@@@@@@@@@@@@@@@@@@@@@@@
        public static SendingPacket send_error_config_does_not_exists() {
            return new PacketFail(404,"System is not configured. Create config at \"POST /v1.0/config\"");
        }

        public async Task load_settings() {

            Config? config = await this._dao.get();

            if (config != null) {

                // Update entries
                DateTime date = DateTime.UtcNow;
                Console.WriteLine($"Tempo que passou {date - config.last_online_date}");
                this.last_online_date = config.last_online_date;
                this.is_next_month = date.Year > config.last_online_date.Year || date.Month > config.last_online_date.Month;
                config.last_online_date = date;

                // Update Database
                this.outdated_database = config.database_version < Models.ModelsManager.database_version;

                // Prepare new config
                this.config_to_be_updated = config;

            }

            this.does_config_exist = config != null;

        }

        public async Task finish_config() {

            if (this.config_to_be_updated != null) {

                this.config = this.config_to_be_updated;
                bool was_updated = await this._dao.put(this.config);

                if (!was_updated)
                    throw new ControllerManagerException("Could not update config");

            }

        }

        // @@@@@@@@@@@@@@@@@@@@@@@@@
        //    Main Funcionalities
        // @@@@@@@@@@@@@@@@@@@@@@@@@
        public SendingPacket Get() {

            if (this.config == null)
                return ConfigController.send_error_config_does_not_exists();
            else
                return new PacketSuccess(200,this.config.to_json());

        }

        public async Task<SendingPacket> Create(IDictionary<string,object> config_data) {

            if (this.does_config_exist)
                return new PacketFail(403,"Config already exists. Do not need creation");

            try {

                var config_dto = new ConfigDTO();

                config_dto.set_username((string) config_data["username"]);
                config_dto.set_password((string) config_data["password"]);

                if (config_data.ContainsKey("name")) config_dto.set_name((string) config_data["name"]);
                if (config_data.ContainsKey("public")) config_dto.set_public((bool) config_data["public"]);
                if (config_data.ContainsKey("initialMoney")) config_dto.set_initial_money((double) config_data["initialMoney"]);
                if (config_data.ContainsKey("lostMoney")) config_dto.set_lost_money((double) config_data["lostMoney"]);
                if (config_data.ContainsKey("savedMoney")) config_dto.set_saved_money((double) config_data["savedMoney"]);

                var new_config = config_dto.extract();

                if (await this._dao.put(new_config)) {
                    this.does_config_exist = true;
                    this.config = new_config;
                    return new PacketSuccess(201,new_config.to_json());
                }
                else
                    return new PacketFail(422,"Error while inserting config into database");

            }
            catch (ConfigDTOException ex) {
                return new PacketFail(417,ex.message);
            }

        }

        public async Task<SendingPacket> Update(IDictionary<string,object> config_data) {

            if (!this.does_config_exist)
                return ConfigController.send_error_config_does_not_exists();

            try {

                var config_dto = new ConfigDTO((await this._dao.get())!);

                if (config_data.ContainsKey("username")) config_dto.set_username((string) config_data["username"]);
                if (config_data.ContainsKey("password")) config_dto.set_password((string) config_data["password"]);
                if (config_data.ContainsKey("name")) config_dto.set_name((string) config_data["name"]);
                if (config_data.ContainsKey("public")) config_dto.set_public((bool) config_data["public"]);
                if (config_data.ContainsKey("initialMoney")) config_dto.set_initial_money((double) config_data["initialMoney"]);
                if (config_data.ContainsKey("lostMoney")) config_dto.set_lost_money((double) config_data["lostMoney"]);
                if (config_data.ContainsKey("savedMoney")) config_dto.set_saved_money((double) config_data["savedMoney"]);

                var updated_config = config_dto.extract();

                if (await this._dao.put(updated_config)) {
                    this.does_config_exist = true;
                    this.config = updated_config;
                    return new PacketSuccess(200,updated_config.to_json());
                }
                else
                    return new PacketFail(422,"Error while updating config of database");


            }
            catch (ConfigDTOException ex) {
                return new PacketFail(417,ex.message);
            }

        }


    }

}

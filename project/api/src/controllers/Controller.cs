using PacketHandlers;
using Nito.AsyncEx;
using Pages;
using Queries;

namespace Controller {

    public class ControllerManager {

        private readonly AsyncReaderWriterLock _lock;

        private ConfigController _config;
        private TokenController _token;

        public ControllerManager() {
            this._lock = new();
            this._config = new ConfigController();
            this._token = new TokenController();
        }

        public async Task load_settings() {
            await this._config.load_settings();
        }

        /// #################################
        ///           CONFIG
        /// #################################
        public async Task<SendingPacket> config_get() {

            var controller_lock = await this._lock.ReaderLockAsync();
            var config_manager_lock = await this._config.Lock.ReaderLockAsync();
            controller_lock.Dispose();

            try {

                var response = await this._config.Get();
                return response;
                
            } finally {
                config_manager_lock.Dispose();
            }

        }

        public async Task<SendingPacket> config_create(IDictionary<string,object> request_data) {

            var controller_lock = await this._lock.WriterLockAsync();
            var config_manager_lock = await this._config.Lock.WriterLockAsync();
            controller_lock.Dispose();

            try {

                var response = await this._config.Create(request_data);
                return response;
                
            } finally {
                config_manager_lock.Dispose();
            }
        
        }

        public async Task<SendingPacket> config_update(IDictionary<string,object> request_data) {

            var controller_lock = await this._lock.WriterLockAsync();
            var config_manager_lock = await this._config.Lock.WriterLockAsync();
            controller_lock.Dispose();

            try {

                var response = await this._config.Update(request_data);
                return response;
                
            } finally {
                config_manager_lock.Dispose();
            }
        
        }

        /// #################################
        ///           TOKEN
        /// #################################
        public async Task<SendingPacket> token_get() {

            if (this._config.does_config_exist == false)
                return ConfigController.send_error_config_does_not_exists();

            var controller_lock = await this._lock.ReaderLockAsync();
            var token_manager_lock = await this._token.Lock.ReaderLockAsync();
            controller_lock.Dispose();

            try {

                var response = this._token.Get();
                return response;
                
            } finally {
                token_manager_lock.Dispose();
            }

        }

        public async Task<SendingPacket> token_create(IDictionary<string,object> request_data) {

            if (this._config.does_config_exist == false)
                return ConfigController.send_error_config_does_not_exists();

            var controller_lock = await this._lock.ReaderLockAsync();
            var config_manager_lock = await this._config.Lock.ReaderLockAsync();
            var token_manager_lock = await this._token.Lock.WriterLockAsync();
            controller_lock.Dispose();

            try {

                var config = await this._config.get();
                var response = this._token.Create(request_data,config!);
                return response;
                
            } finally {
                config_manager_lock.Dispose();
                token_manager_lock.Dispose();
            }
        
        }

        public async Task<SendingPacket> token_delete(string token) {

            if (this._config.does_config_exist == false)
                return ConfigController.send_error_config_does_not_exists();

            var controller_lock = await this._lock.ReaderLockAsync();
            var token_manager_lock = await this._token.Lock.WriterLockAsync();
            controller_lock.Dispose();

            try {

                AccessToken? access_token = this._token.get_token(token);
                var response = this._token.Delete(access_token);
                return response;
                
            } finally {
                token_manager_lock.Dispose();
            }
        
        }

        public async Task<SendingPacket> token_update(IDictionary<string,object> request_data, string token) {

            if (this._config.does_config_exist == false)
                return ConfigController.send_error_config_does_not_exists();

            var controller_lock = await this._lock.ReaderLockAsync();
            var config_manager_lock = await this._config.Lock.ReaderLockAsync();
            var token_manager_lock = await this._token.Lock.WriterLockAsync();
            controller_lock.Dispose();

            try {

                AccessToken? access_token = this._token.get_token(token);
                var config = await this._config.get();
                var response = this._token.Update(request_data,access_token,config!);
                return response;
                
            } finally {
                config_manager_lock.Dispose();
                token_manager_lock.Dispose();
            }
        
        }

    }

}



using BusinessLayer.Interface;
using ModelLayer.DTO;
using RepositoryLayer.Service;
using RepositoryLevel.Interface;
using System;

namespace BusinessLayer.Service
{
    public class RegisterHelloBL : IRegisterHelloBL
    {
        private readonly IRegisterHelloRL _registerHelloRL;
        private readonly ILoggerSer<RegisterHelloBL> _loggerService;

        public RegisterHelloBL(IRegisterHelloRL registerHelloRL, ILoggerSer<RegisterHelloBL> loggerService)
        {
            _registerHelloRL = registerHelloRL;
            _loggerService = loggerService;
        }

        // Register User
        public ResponseModel<string> RegisterUser(RegisterDTO registerDTO)
        {
            try
            {
                _loggerService.LogInfo($"RegisterUser method called for {registerDTO.Username}.");
                bool isSuccess = _registerHelloRL.AddUser(registerDTO, out string message);
                return new ResponseModel<string>(isSuccess, message, isSuccess ? registerDTO.Username : "");
            }
            catch (Exception ex)
            {
                _loggerService.LogError("Error in RegisterUser method.", ex);
                return new ResponseModel<string>(false, $"Error: {ex.Message}", "");
            }
        }

        // Login User
        public ResponseModel<string> LoginUser(LoginDTO loginDTO)
        {
            try
            {
                _loggerService.LogInfo($"LoginUser method called for {loginDTO.username}.");
                bool isSuccess = _registerHelloRL.ValidateUser(loginDTO, out string message);
                return new ResponseModel<string>(isSuccess, message, isSuccess ? loginDTO.username : "");
            }
            catch (Exception ex)
            {
                _loggerService.LogError("Error in LoginUser method.", ex);
                return new ResponseModel<string>(false, $"Error: {ex.Message}", "");
            }
        }
    }
}

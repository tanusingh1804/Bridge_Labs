using Microsoft.AspNetCore.Mvc;
using BusinessLayer.Service;
using ModelLayer.DTO;
using System.Security.Cryptography.X509Certificates;
namespace HelloApp.Controllers

{
    [ApiController]
    [Route("[controller]")] //set routes or address
    public class HelloAppController : ControllerBase
    {
        RegisterHelloBL _registerHelloBl; //object create kiye h 

        ResponseModel<string> response;


        public HelloAppController(RegisterHelloBL registerHello)

        {
            _registerHelloBl = registerHello;
        }

        [HttpGet]
        public string Get()
        {
            return _registerHelloBl.registration("value from controller");
        }

        [HttpPost]
        public IActionResult LoginUser(LoginDTO loginDTO)

        {
            try
            {
                response = new ResponseModel<string>();
                bool result = _registerHelloBl.loginUser(loginDTO);
                if (result)
                {
                    response.Success = true;
                    response.Message = "Login successful";
                    response.Data = loginDTO.username;
                    return Ok(response);
                }


                response.Success = false;
                response.Message = "login failed";
                response.Data = "";
                return NotFound();
            }
            catch (Exception ex) {
                response.Success = false;
                response.Message = ex.Message;
                response.Data=ex.Message;
                return BadRequest();
            }

            //return response = new ResponseModel<string>
            //{
            //    message = "data re",
            //    success = true,
            //    Data = loginDTO.ToString()
            //};



        }

    }
}
using DataAccess.Models;
using Domain.IRepository;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    [EnableCors("corspolicy")]
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private ILogin _Ilogin;

        public WeatherForecastController(ILogin login)
        {
            _Ilogin = login;

        }
        [HttpGet]
        public string Login(string userName,string password)
        {
            string result =_Ilogin.logins(userName,password);
            return result;
        }


    }


}
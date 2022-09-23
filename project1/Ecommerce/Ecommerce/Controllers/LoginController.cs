using Ecommerce.Models;
using Ecommerce.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        EcommerceContext db;
        public LoginController(EcommerceContext _db)
        {
            db = _db;
        }
        [HttpPost]
        public IActionResult Login(LoginViewModel loginViewModel)
        {

            var Islogin = db.Logins.Any(x => x.UserName == loginViewModel.UserName && x.Password == loginViewModel.Password);

            return Ok(new { IsLogin = Islogin, Message = Islogin ? "Successfully login" : "Either username or password is incorrect" });
        }
    }
}

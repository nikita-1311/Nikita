using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Api_Consuming.Models;

namespace Api_Consuming.Controllers
{
    public class LoginController : ApiController
    {
        [Route("Api/Login/UserLogin")]
        [HttpPost]
        public Response Login(Login lg)
        {
            CompanyEntities  EB = new CompanyEntities();
            var obj = EB.LoginForm(lg.UserName, lg.Password).ToList<LoginForm_Result>().FirstOrDefault();
            
            if(obj.Status == 0)
            {
                return new Response { Status = "Invalid", Message = "Invalid User" };
            }
            else if (obj.Status == -1)
            {
                return new Response { Status = "Invalid", Message = "Invalid User" };
            }
            else
            {
                return new Response { Status = "Success", Message = lg.UserName };
            }
        }
        [Route("Api/Login/CreateContact")]
        [HttpPost]
        public object CreateContact(Registration Rg)
        {
            try
            {
                CompanyEntities CE = new CompanyEntities();
                Employeemaster EM = new Employeemaster();
                if(EM.UserId == 0)
                {
                    EM.UserName = Rg.UserName;
                    EM.LoginName = Rg.LoginName;
                    EM.Password = Rg.Password;
                    EM.Status = Rg.Status;
                    EM.IsApporved = Rg.IsApporved;
                    EM.TotalCnt = Rg.TotalCnt;
                    EM.Address = Rg.Address;
                    EM.ContactNo = Rg.ContactNo;
                    EM.Email = Rg.Email;
                    CE.Employeemasters.Add(EM);
                    CE.SaveChanges();
                    return new Response { Status = "Success", Message = "Successfully Saved" };
                }
            }
            catch(Exception)
            {
                throw;
            }
            return new Response { Status = "Error", Message = "Invalid Data" };
        }
    }
}

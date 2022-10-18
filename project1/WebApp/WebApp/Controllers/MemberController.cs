using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Members.Data.Model;
using System.Collections.Generic;
using Members.Data.Interface;
using Members.Data.Repository;

namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemberController : ControllerBase
    {
        private IMember members = new MembersRepository();
        [HttpGet]
        public ActionResult<IEnumerable<Member>> GetAllMember()
        {
            return members.GetAllMember();
        }
        public ActionResult<Member> GetMemberById(int id)
        {
            return members.GetMember(id); 
        }
    } 
}


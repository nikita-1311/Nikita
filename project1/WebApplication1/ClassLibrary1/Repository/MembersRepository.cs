using System;
using System.Collections.Generic;
using System.Text;
using Members.Data.Interface;
using Members.Data.Model;

namespace Members.Data.Repository
{
    public class MembersRepository : IMember
    {
        List<Member> IMember.GetAllMember()
        {
            List<Member> list = new List<Member>
            {

            }
        }
    }
}

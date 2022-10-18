using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Members.Data.Interface;
using Members.Data.Model;

namespace Members.Data.Repository
{
    public class MembersRepository : IMember
    {
        List<Member> list = new List<Member>
        {
            new Member{MemberId=1, FirstName="Nikita", LastName="Bhujbal", Address="City"}
        };
        List<Member> IMember.GetAllMember()
        {
            return list;
        }
        Member IMember.GetMember(int id)
        {
            return list.FirstOrDefault(x => x.MemberId==id);
        } 
    }
}

using Members.Data.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Members.Data.Interface
{
    public interface IMember
    {
        List<Member> GetAllMember();
        Member GetMember(int id);
    }
}

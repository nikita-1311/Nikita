using System;
using System.Collections.Generic;
using System.Text;

namespace Member.Data.Interface
{
    interface IMember
    {
        List<IMember> GetAllMember();
    }
}

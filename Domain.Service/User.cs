using Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Service
{
    public class User:IUser
    {

        public string GetUserName()
        {
            return "User对象为构造函数注入";
        }
    }
}

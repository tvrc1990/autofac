using Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Service
{
    public class Role:IRole
    {
       public IGroup group { set; get; }
        public string GetRoleName()
        {
            return string.Format("Role:{0},Group:{1}", "Role对象是构造函数注入", "Group对象是属性自动注入到Role对象中");
        }
    }
}

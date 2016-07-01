using Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WEB_API_IOC.Controllers
{
    public class DemoController : ApiController
    {
        private IUser user;
        private IRole role;
       // public IGroup group;
        public DemoController(IUser _user,IRole _role)
        {
            this.user = _user;
            this.role = _role;
        }

        // GET api/demo
        public IEnumerable<string> Get()
        {
            return new string[] { user.GetUserName(), role.GetRoleName()};
        }

        // GET api/demo/5
        public string Get(int id)
        {
            return user.GetUserName(); ;
        }

        // POST api/demo
        public void Post([FromBody]string value)
        {
        }

        // PUT api/demo/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/demo/5
        public void Delete(int id)
        {
        }
    }
}

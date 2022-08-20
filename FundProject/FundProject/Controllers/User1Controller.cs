using BEL;
using BLL1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FundProject.Controllers
{
    public class User1Controller : ApiController
    {
        [Route("api/User1/Names")]
        [HttpGet]
        public List<string> GetNames()
        {
            return User1Service.GetNames();
        }
        [Route("api/User1/All")]
        [HttpGet]
        public List<User1Model> GetAll()
        {
            return User1Service.GetAll();
        }
        [Route("api/User1/Add")]
        [HttpPost]
        public bool Add(User1Model e)
        {
            User1Service.Add(e);
            return true;
        }

        [Route("api/User1/Edit")]
        [HttpPost]
        public void Edit(User1Model e)
        {
            User1Service.Edit(e);
        }

        [Route("api/User1/delete/{id}")]
        [HttpDelete]
        public bool Delete(int id)
        {
            User1Service.Delete(id);
            return true;
        }

    }
}

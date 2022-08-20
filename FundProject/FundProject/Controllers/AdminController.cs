using BLL1;
using BEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FundProject.Controllers
{
    public class AdminController : ApiController
    {

        [Route("api/Admin/Names")]
        [HttpGet]

        public List<string> GetNames()
        {
            return AdminService.GetNames();
        }

        [Route("api/Admin/All")]
        [HttpGet]
        public List<AdminModel> GetAll()
        {
            return AdminService.Get();
        }

        [Route("api/Admin/Add")]
        [HttpPost]
        public bool Add(AdminModel a)
        {
            AdminService.Add(a);
            return true;
        }
       

        [Route("api/Admin/Edit")]
        [HttpPost]
        public void Edit(AdminModel s)
        {
            AdminService.Edit(s);

        }

        [Route("api/Admin/delete/{id}")]
        [HttpDelete]

        public bool Delete(int id)
        {
            AdminService.Delete(id);
            return true;    
        }

    }

}
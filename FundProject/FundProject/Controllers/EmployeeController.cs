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
    public class EmployeeController : ApiController
    {
        [Route("api/Employee/Names")]
        [HttpGet]
        public List<string> GetNames()
        {
            return EmployeeService.GetNames();  
        }
        [Route("api/Employee/All")]
        [HttpGet]
        public List<EmployeeModel> GetAll()
        {
            return EmployeeService.GetAll(); 
        }
        [Route("api/Employee/Add")]
        [HttpPost]
        public bool Add(EmployeeModel e)
        {
            EmployeeService.Add(e); 
            return true;    
        }

        [Route("api/Employee/Edit")]
        [HttpPost]
        public void Edit(EmployeeModel e)
        {
            EmployeeService.Edit(e);    
        }

        [Route("api/Employee/delete/{id}")]
        [HttpDelete]
        public bool Delete(int id)
        {
            EmployeeService.Delete(id);
            return true;
        }

    }
}

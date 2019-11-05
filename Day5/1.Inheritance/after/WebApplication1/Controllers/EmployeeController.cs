using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    public class EmployeeController : BaseController
    {
        public IHttpActionResult Get()
        {
            List<Employee> result = EmployeeService.GetAll();
            return Ok(result);
        }
    }
}

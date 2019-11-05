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
    public class AccountController : ApiController
    {
        private readonly AccountService accountService;
        public AccountController()
        {
            accountService = new AccountService();
        }

        public IHttpActionResult Get()
        {
            List<Account> result = accountService.GetAll();
            return Ok(result);
        }
    }
}

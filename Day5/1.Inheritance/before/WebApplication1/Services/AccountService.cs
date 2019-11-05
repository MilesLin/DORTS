using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class AccountService
    {
        public List<Account> GetAll()
        {
            return new List<Account>
            {
                new Account { Id = 1, Email = "abc@abc.com", RoleName = "manager" },
                new Account { Id = 2, Email = "xyz@abc.com", RoleName = "clerk" },
                new Account { Id = 3, Email = "def@abc.com", RoleName = "boss" },
            };
        }
    }
}
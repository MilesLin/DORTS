using System.Web.Http;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    public class BaseController : ApiController
    {
        protected AccountService AccountService
        {
            get
            {
                return new AccountService();
            }
        }

        protected EmployeeService EmployeeService
        {
            get
            {
                return new EmployeeService();
            }
        }
    }
}
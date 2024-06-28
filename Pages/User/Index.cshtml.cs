using DemoWebApp.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DemoWebApp.Pages.User
{
    public class IndexModel : PageModel
    {
        private readonly IConfiguration configuration;
        public List<Users> listusers = new List<Users>();

        public IndexModel (IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public void OnGet()
        {
            DAL dal = new DAL();
            listusers = dal.GetUsers(configuration);
        }
    }
}

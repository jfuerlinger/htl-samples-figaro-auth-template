using System.Threading.Tasks;
using Figaro.Core.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Figaro.Web.Pages.Auth
{
    public class LogoutModel : PageModel
    {
        public ActionResult OnPostAsync()
        {
            return Page();
        }
    }
}

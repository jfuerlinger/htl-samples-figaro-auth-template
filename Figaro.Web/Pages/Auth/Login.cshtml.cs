using System.Threading.Tasks;
using Figaro.Core.Entities;
using Figaro.Web.DataTransferObjects;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Figaro.Web.Pages.Auth
{
    public class LoginModel : PageModel
    {
        public CredentialDto Credentials { get; set; }

        public IActionResult OnPostAsync()
        {
            return Page();
        }
    }
}

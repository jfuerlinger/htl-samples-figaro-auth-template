using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Figaro.Web.DataTransferObjects;
using Figaro.Core.Entities;
using System;

namespace Figaro.Web.Pages.Auth
{
    public class RegisterModel : PageModel
    {
        public UserDto AuthUser { get; set; }

        public IActionResult OnPostAsync()
        {
            return Page();
        }
    }
}

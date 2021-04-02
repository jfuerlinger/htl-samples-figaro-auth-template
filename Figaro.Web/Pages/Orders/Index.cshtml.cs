﻿using Figaro.Core.Contracts;
using Figaro.Core.DTOs;
using Figaro.Core.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Figaro.Web.Pages.Orders
{
    public class IndexModel : PageModel
    {
        [Display(Name = "Nachname")]
        public string FilterLastName { get; set; }

        public bool IsAdmin { get; set; }

        public IEnumerable<OrderDto> Orders { get; set; }

        public IActionResult OnGetAsync()
        {
            return Page();
        }

        public IActionResult OnPostSearch()
        {
            return Page();
        }
    }
}

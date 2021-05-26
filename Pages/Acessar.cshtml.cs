using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SocialFit.Data;
using SocialFit.Models;

namespace SocialFit.Pages
{
    public class AcessarModel : PageModel
    {
        private readonly SocialFit.Data.SocialFitContext _context;

        [BindProperty]
        public Client Client { get; set; }

        public AcessarModel(SocialFit.Data.SocialFitContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> OnPostLogarAsync()
        {
            string email = Request.Form["email"];
            return Page();
        }

        public IActionResult OnGet()
        {
            return Page();
        }

    }
}
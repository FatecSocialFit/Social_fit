using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SocialFit.Data;
using SocialFit.Models;

namespace SocialFit.Pages.Clients
{
    [AllowAnonymous]
    public class CreateModel : PageModel
    {
        private readonly SocialFit.Data.SocialFitContext _context;

        public CreateModel(SocialFit.Data.SocialFitContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Client Client { get; set; }

        public Client cli { get; set; }

   
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            string repeatPassword = Request.Form["repeat-passwd"];
            string password = Client.Password;
            string aceitar = Request.Form["concordar"];

            var cli = await _context.Client.FirstOrDefaultAsync(m => m.Login == Client.Login);

            if (!string.Equals(password, repeatPassword) || password.Length < 8 || cli!=null || aceitar==null )
            {
                return RedirectToPage("/Erros");
            }

            Hash hash = new Hash(SHA512.Create());

            // generate password hash SHA512
           
            Client.Password = hash.CriptografarSenha(Client.Password);

            _context.Client.Add(Client);
            await _context.SaveChangesAsync();

            return RedirectToPage("Index");
        }

    }
}
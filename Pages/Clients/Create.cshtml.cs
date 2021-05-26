using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SocialFit.Data;
using SocialFit.Models;

namespace SocialFit.Pages.Clients
{
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

            // generate a 128-bit salt using a secure PRNG
            byte[] salt = new byte[128 / 8];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            } 

            // derive a 256-bit subkey (use HMACSHA1 with 10,000 iterations)
            string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: password,
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA1,
                iterationCount: 10000,
                numBytesRequested: 256 / 8));
          
            Client.Password = hashed;

            _context.Client.Add(Client);
            await _context.SaveChangesAsync();

            return RedirectToPage("/Success");
        }

    }
}
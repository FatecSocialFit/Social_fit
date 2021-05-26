using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SocialFit.Data;
using SocialFit.Models;

namespace SocialFit.Pages.Account
{
    public class LoginModel : PageModel
    {
        private readonly SocialFit.Data.SocialFitContext _context;

        [BindProperty]
        public Client Client { get; set; }

        public LoginModel(SocialFit.Data.SocialFitContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> OnPost()
        {
           
            if(!IsUserAuthenticade(Request.Form["email"], Request.Form["passwd"]))
            {
                ModelState.AddModelError(string.Empty, "Usuário ou senha inválidos");
                return Page();
            }

            var cli = _context.Client.FirstOrDefault(c => c.Login.Equals(Request.Form["email"]));

            var claims = new List<Claim>{
                new Claim(ClaimTypes.Name, Request.Form["email"]),             
            };

            var userIdentify = new ClaimsIdentity(claims, "login");
            ClaimsPrincipal principal = new ClaimsPrincipal(userIdentify);

            await HttpContext.SignInAsync(principal);
            ViewData["usuario"] = cli.Id.ToString();

            return RedirectToPage("/PageUser");
        }


        public async Task<IActionResult> OnPostLogoutAsync()
        {
           
            await HttpContext.SignOutAsync();
            return RedirectToPage("/Index");
        }


        public bool IsUserAuthenticade(string email, string senha)
        {
            Hash hash = new Hash(SHA512.Create());
            var cli = _context.Client.FirstOrDefault(c => c.Login == email);
            if(cli!=null && hash.VerificarSenha(senha, cli.Password))
            {
                return true;
            }      
            return false;
        }
    }
}

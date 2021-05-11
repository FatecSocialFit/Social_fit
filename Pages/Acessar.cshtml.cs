using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
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

        public const string SessionKeyName = "_Name";
        public const string SessionKeyAge = "_Age";
        const string SessionKeyTime = "_Time";

        public string SessionInfo_Name { get; private set; }
        public string SessionInfo_Age { get; private set; }
        public string SessionInfo_CurrentTime { get; private set; }
        public string SessionInfo_SessionTime { get; private set; }
        public string SessionInfo_MiddlewareValue { get; private set; }


        [BindProperty]
        public Client Client { get; set; }

        public AcessarModel(SocialFit.Data.SocialFitContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> OnPostLogarAsync()
        {
           
            string email = Request.Form["email"];
            string passwordIn = Request.Form["passwd"];
            Hash hash = new Hash(SHA512.Create());
            var cli = await _context.Client.FirstOrDefaultAsync(c => c.Login == email);
            //!hash.VerificarSenha(passwordIn, cli.Password)
            if (cli!=null)
            {
                if (string.IsNullOrEmpty(HttpContext.Session.GetString(SessionKeyName)))
                {
                    HttpContext.Session.SetString(SessionKeyName, cli.Name!=null? cli.Name : "");
                    HttpContext.Session.SetInt32(SessionKeyAge, cli.Id);
                }

                var name = HttpContext.Session.GetString(SessionKeyName);
                var age = HttpContext.Session.GetInt32(SessionKeyAge);

                return RedirectToPage("/Index");    
            }
            else
            {
                return Page();
            }
        }

        public IActionResult OnGet()
        {
            return Page();
        }

    }
}
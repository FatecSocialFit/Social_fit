using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SocialFit.Data;
using SocialFit.Models;

namespace SocialFit.Pages
{
    [Authorize]
    public class PageUserModel : PageModel
    {
        private readonly SocialFit.Data.SocialFitContext _context;
        public const string SessionKeyName = "_Name";

        public PageUserModel(SocialFit.Data.SocialFitContext context)
        {
            _context = context;
        }

        public Client Client { get;set; }

        public async Task OnGetAsync()
        {

            // Client = await _context.Client.ToListAsync();
           Client = await _context.Client.FirstOrDefaultAsync(b => b.Login.Equals(User.Identity.Name));


        }
    }
}

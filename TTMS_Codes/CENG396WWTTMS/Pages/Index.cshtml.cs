using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CENG396WWTTMS.Models.DB;
using Microsoft.AspNetCore.Http;

namespace CENG396WWTTMS
{
    public class IndexModel : PageModel
    {
        private readonly CENG396WWTTMS.Models.DB.CENG396_WWTTMSContext _context;

        public IndexModel(CENG396WWTTMS.Models.DB.CENG396_WWTTMSContext context)
        {
            _context = context;
        }

        public IList<CrewMember> CrewMember { get; set; }
        public IList<Mcc> Mcc { get; set; }

        public async Task OnGetAsync()
        {
            //CrewMember = await _context.CrewMember.ToListAsync();
            Mcc = await _context.Mcc.ToListAsync();
        }

        [BindProperty]
        public string email { get; set; }

        [BindProperty]
        public string password { get; set; }
        public string Msg { get; set; }

        private bool CrewMemberExists(string email, string password)
        {
            bool usern = false, pass = false;

            usern = _context.CrewMember.Any(e => e.Email == email);
            pass = _context.CrewMember.Any(e => e.Password == password);
            if (usern == true && pass == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool MCCExists(string email, string password)
        {
            bool admin = false, apass = false;

            admin = _context.Mcc.Any(e => e.Email == email);
            apass = _context.Mcc.Any(e => e.Password == password);

            if (admin == true && apass == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public IActionResult OnPost()
        {
            if (CrewMemberExists(email, password))
            {
                //HttpContext.Session.SetString("username", Username); 
                var c_mem = _context.CrewMember.Single(a => a.Email == email);
                HttpContext.Session.SetString("username", c_mem.Email);
                // return RedirectToPage("Welcome"); 
                return RedirectToPage("CrewMember");
            }
            else if (MCCExists(email, password))
            {
                var cust = _context.Mcc.Single(a => a.Email == email);
                HttpContext.Session.SetString("username", email);
                //securityManager.SignIn(HttpContext, cust); 
                return RedirectToPage("MCC");
            }
            else
            {
                Msg = "Invalid";
                return Page();
            }
        }
    }
}

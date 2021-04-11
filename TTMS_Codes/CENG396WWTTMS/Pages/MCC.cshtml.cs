using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CENG396WWTTMS.Models.DB;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace CENG396WWTTMS
{
    public class MCCModel : PageModel
    {
        private readonly CENG396WWTTMS.Models.DB.CENG396_WWTTMSContext _context;

        public MCCModel(CENG396WWTTMS.Models.DB.CENG396_WWTTMSContext context)
        {
            _context = context;
        }

        public IList<Trouble> Trouble { get; set; }

        public async Task OnGetAsync()
        {
            Trouble = await _context.Trouble
                    .Where(b => b.TicketState == "Opened")
                    .ToListAsync();
        }

        /*[BindProperty] public string Username { get; set; }
        public void OnGet()
        {
            Username = HttpContext.Session.GetString("username");

        }
        private bool CustomersExists(String Username) { return _context.Mcc.Any(e => e.MccName == Username); }*/

        [BindProperty] public Trouble Troubles { get; set; }


        public void Save(Trouble cust) { _context.Trouble.Update(cust); _context.SaveChanges(); }


        public string email { get; set; }
        // public string UserId; 
        
        int crew_number;
        public IActionResult OnPostRegister()
        {
            string TroubleC = Request.Form["TroubleCheck"];
            string crewMem = Request.Form["crew_members"];
            bool id = false, troubles = false;

            if (crewMem == "1") crew_number = 1;
            else if (crewMem == "2") crew_number = 2;
            else if (crewMem == "3") crew_number = 3;


            if (crew_number == 1)
            {
                id = _context.Crew.Any(e => e.CrewId == 0);
                troubles = _context.Trouble.Any(e => e.TicketState == "Opened");
                var Status = _context.Trouble.Single(a => a.TicketState == "Opened");
                if (id == true && troubles == true)
                {
                    Status.CrewAssignedId = crew_number;
                    Status.TicketState = "Assigned";
                }

                _context.SaveChanges();

            }

            else if (crew_number == 2)
            {

                id = _context.Crew.Any(e => e.CrewId == 0);
                troubles = _context.Trouble.Any(e => e.TicketState == "Opened");
                var Status = _context.Trouble.Single(a => a.TicketState == "Opened");
                if (id == true && troubles == true)
                {
                    Status.CrewAssignedId = crew_number;
                    Status.TicketState = "Assigned";
                }

                _context.SaveChanges();

            }
            else if (crew_number == 3)
            {
                id = _context.Crew.Any(e => e.CrewId == 0);
                troubles = _context.Trouble.Any(e => e.TicketState == "Opened");
                var Status = _context.Trouble.Single(a => a.TicketState == "Opened");
                if (id == true && troubles == true)
                {
                    Status.CrewAssignedId = crew_number;
                    Status.TicketState = "Assigned";
                }

                _context.SaveChanges();

            }
            return RedirectToPage();
        }  
    }
}
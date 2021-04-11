using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CENG396WWTTMS.Models.DB;
using System.Net.Mail;

namespace CENG396WWTTMS
{
    public class CreateModel : PageModel
    {
        private readonly CENG396WWTTMS.Models.DB.CENG396_WWTTMSContext _context;

        public CreateModel(CENG396WWTTMS.Models.DB.CENG396_WWTTMSContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            //ViewData["AbonNum"] = new SelectList(_context.Client, "AbonNum", "AbonNum");
            //ViewData["CrewAssignedId"] = new SelectList(_context.Crew, "CrewId", "CrewId");
            return Page();
        }

        [BindProperty]
        public Trouble Trouble { get; set; }
        public bool Notify { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            Trouble.TicketState = "Opened";
            Trouble.CrewAssignedId = 0;
            _context.Trouble.Add(Trouble);
            await _context.SaveChangesAsync();
            _ = SendEmailAsync(Trouble.TtNumber);
            return RedirectToPage("./TTNumber");
        }
        public async Task SendEmailAsync(int ttnumber)
        {
            var trouble = _context.Trouble.Single(a => a.TtNumber == ttnumber);
            string To = trouble.Email;
            string Subject = "Information mail from Water Works (do not reply)";
            string Body = "Hello " + trouble.FullName + "!" + "\nWe have received your trouble declaration. Here is your Trouble Ticket Number: " + ttnumber + "\nWe will contact you again as soon as we fix your problem. \nHave a nice day!";
            MailMessage mm = new MailMessage();
            mm.To.Add(To);
            mm.Subject = Subject;
            mm.Body = Body; mm.IsBodyHtml = false;
            mm.From = new MailAddress("denemerazorpages@gmail.com");
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.Port = 587;
            smtp.UseDefaultCredentials = false;
            smtp.EnableSsl = true;
            smtp.Credentials = new System.Net.NetworkCredential("denemerazorpages@gmail.com", "a_123456");
            await smtp.SendMailAsync(mm);
        }
    }
}

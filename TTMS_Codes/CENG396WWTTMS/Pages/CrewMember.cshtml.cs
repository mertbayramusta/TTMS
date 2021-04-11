using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CENG396WWTTMS.Models.DB;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Net.Mail;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections;
using System.Data;

namespace CENG396WWTTMS
{
    public class CrewMemberModel : PageModel
    {
        private readonly CENG396WWTTMS.Models.DB.CENG396_WWTTMSContext _context;

        public CrewMemberModel(CENG396WWTTMS.Models.DB.CENG396_WWTTMSContext context)
        {
            _context = context;
        }

       
        public string Msg { get; set; }

        [BindProperty]
        public Client Client { get; set; }
        public Trouble Trouble_a { get; set; }
        public IList<Trouble> Trouble { get; set; }

        [BindProperty]
        public string Username { get; set; }
        
        //public int Count { get; set; }

        public int tnumber { get; set; }
        public int ttnumber { get; set; }

        /*public IList<int> AbonNum { get; set; }
        public IList<int> TtNumber { get; set; }
        public IList<string> FullName { get; set; }
        public IList<string> Email { get; set; }
        public IList<string> TroDesc { get; set; }
        public IList<string> Address { get; set; }
        public IList<string> TicketState { get; set; }
        */
        public string Address { get; set; }
        //public int Crew_ID { get; set; }

        int Crew_ID;
  
        private bool TroubleExists(int crew_id)
        {
            bool m_id = false, assigned = false;
            m_id = _context.Trouble.Any(e => e.CrewAssignedId == crew_id);
            assigned = _context.Trouble.Any(e => e.TicketState == "Assigned");
            if (m_id == true && assigned == true)
                return true;
            else
                return false;

        }

        public async Task SendEmailAsync(int ttnumber)
        {
            var trouble = _context.Trouble.Single(a => a.TtNumber == ttnumber);
            string To = trouble.Email;
            string Subject = "Information mail from Water Works (do not reply)";
            string Body = "Hello " + trouble.FullName + "!" + "\nYour trouble with \"Trouble Ticket Number: " + ttnumber + "\" has been fixed.\nHave a nice day!";
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

        public async Task SendEmailAsync2(string address, int ttnumber)
        {
            
            string To = Username;
            string Subject = "Information mail from Water Works (do not reply)";
            string Body = "The address of the selected Trouble Ticket \"" + ttnumber + "\"is: " +address;
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

        public async Task OnGetAsync()
        {
            Username = HttpContext.Session.GetString("username"); 
            var e_mail = HttpContext.Session.GetString("username");
            var crew_member = _context.CrewMember.Single(a => a.Email == e_mail);
            Crew_ID = crew_member.CrewId;
            if (TroubleExists(Crew_ID))
            {
                Msg = "There are new troubles for your crew";
                Trouble = await _context.Trouble
                    .Where(b => b.CrewAssignedId == Crew_ID && b.TicketState == "Assigned")
                    .ToListAsync();
                /*var troubles =
                    _context.Trouble.Join(
                        _context.Client,
                        trouble => trouble.AbonNum,
                        client => client.AbonNum,
                        (trouble, client) => new
                        {
                            TtNumber = trouble.TtNumber,
                            AbonNum = client.AbonNum,
                            FullName = trouble.FullName,
                            Email = trouble.Email,
                            TroDesc = trouble.TroubleDesc,
                            Address = client.Address,
                            CrewAssignedId = trouble.CrewAssignedId,
                            TicketState = trouble.TicketState
                        }).ToList();

                var alltroubles = troubles.FindAll(a => a.CrewAssignedId == Crew_ID);
                int i = 0;
                foreach (var tro in alltroubles)
                {
                    TtNumber[i] = tro.TtNumber;
                    AbonNum[i] = tro.AbonNum;
                    FullName[i] = tro.FullName;
                    Email[i] = tro.Email;
                    TroDesc[i] = tro.TroDesc;
                    Address[i] = tro.Address;
                    TicketState[i] = tro.TicketState;
                    i++;
                }
                Count = i;*/
            }
            else
            {
                Msg = "No New Trouble for Your Crew";
            }
            
        }
        public IActionResult OnPostSave()
        {
            string tt_num = Request.Form["ttnumber"];
            if (tt_num == "")
            {

            }
            else
            {
                ttnumber = Convert.ToInt32(tt_num);
                var t = _context.Trouble.Single(a => a.TtNumber == ttnumber);
                int an = t.AbonNum;
                var abon = _context.Client.Single(a => a.AbonNum == an);
                Address = abon.Address;
                _ = SendEmailAsync2(Address, ttnumber);
            }
            return RedirectToPage();
        }
        public IActionResult OnPostRegister()
        {
            string tt_number = Request.Form["tnumber"];
            if (tt_number == "")
            {

            }
            else
            {
                tnumber = Convert.ToInt32(tt_number);
                var trouble = _context.Trouble.Single(a => a.TtNumber == tnumber);
                trouble.TicketState = "Done";
                _context.SaveChanges();
                _ = SendEmailAsync(trouble.TtNumber);
            }
            return RedirectToPage();
        }
        /*public IActionResult OnGetLogout()
        {
            HttpContext.Session.Remove("email");
            return RedirectToPage("Index");
        }*/
    }   
}
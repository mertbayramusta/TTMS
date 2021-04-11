using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CENG396WWTTMS.Models.DB;

namespace CENG396WWTTMS
{
    public class EditModel : PageModel
    {
        private readonly CENG396WWTTMS.Models.DB.CENG396_WWTTMSContext _context;

        public EditModel(CENG396WWTTMS.Models.DB.CENG396_WWTTMSContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Trouble Trouble { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Trouble = await _context.Trouble
                .Include(t => t.AbonNumNavigation)
                .Include(t => t.CrewAssigned).FirstOrDefaultAsync(m => m.TtNumber == id);

            if (Trouble == null)
            {
                return NotFound();
            }
           ViewData["AbonNum"] = new SelectList(_context.Client, "AbonNum", "Address");
           ViewData["CrewAssignedId"] = new SelectList(_context.Crew, "CrewId", "CrewName");
            return Page();
        }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Trouble).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TroubleExists(Trouble.TtNumber))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool TroubleExists(int id)
        {
            return _context.Trouble.Any(e => e.TtNumber == id);
        }
    }
}

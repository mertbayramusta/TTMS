using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CENG396WWTTMS.Models.DB;

namespace CENG396WWTTMS
{
    public class DeleteModel : PageModel
    {
        private readonly CENG396WWTTMS.Models.DB.CENG396_WWTTMSContext _context;

        public DeleteModel(CENG396WWTTMS.Models.DB.CENG396_WWTTMSContext context)
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
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Trouble = await _context.Trouble.FindAsync(id);

            if (Trouble != null)
            {
                _context.Trouble.Remove(Trouble);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}

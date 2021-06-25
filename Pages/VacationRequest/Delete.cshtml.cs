using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Workday.Models;

namespace workday.Pages_VacationRequest
{
    public class DeleteModel : PageModel
    {
        private readonly WorkdayContext _context;

        public DeleteModel(WorkdayContext context)
        {
            _context = context;
        }

        [BindProperty]
        public VacationRequest VacationRequest { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            VacationRequest = await _context.VacationRequest.FirstOrDefaultAsync(m => m.ID == id);

            if (VacationRequest == null)
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

            VacationRequest = await _context.VacationRequest.FindAsync(id);

            if (VacationRequest != null)
            {
                _context.VacationRequest.Remove(VacationRequest);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}

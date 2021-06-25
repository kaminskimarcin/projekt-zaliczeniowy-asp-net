using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Workday.Models;

namespace workday.Pages_VacationRequest
{
    public class CreateModel : PageModel
    {
        private readonly WorkdayContext _context;

        public CreateModel(WorkdayContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public VacationRequest VacationRequest { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.VacationRequest.Add(VacationRequest);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

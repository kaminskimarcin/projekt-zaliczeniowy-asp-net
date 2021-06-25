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
    public class IndexModel : PageModel
    {
        private readonly WorkdayContext _context;


        public IndexModel(WorkdayContext context)
        {
            _context = context;
        }

        public IList<VacationRequest> VacationRequest { get;set; }

        public async Task OnGetAsync()
        {
            VacationRequest = await _context.VacationRequest.ToListAsync();
        }

        public object Accept(Workday.Models.VacationRequest vacationRequest) {
            Console.WriteLine("test");
            return null;
        }
    }
}

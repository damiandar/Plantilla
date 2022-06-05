using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AccesoriosArgentinos.Modelos;

namespace AccesoriosArgentinos._Pages_Materiales
{
    public class DetailsModel : PageModel
    {
        private readonly AccesoriosArgentinos.Modelos.AccesoriosDbContext _context;

        public DetailsModel(AccesoriosArgentinos.Modelos.AccesoriosDbContext context)
        {
            _context = context;
        }

        public Material Material { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Material = await _context.Materiales.FirstOrDefaultAsync(m => m.Id == id);

            if (Material == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AccesoriosArgentinos.Modelos;

namespace AccesoriosArgentinos._Pages_Piezas
{
    public class DetailsModel : PageModel
    {
        private readonly AccesoriosArgentinos.Modelos.AccesoriosDbContext _context;

        public DetailsModel(AccesoriosArgentinos.Modelos.AccesoriosDbContext context)
        {
            _context = context;
        }

        public Pieza Pieza { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Pieza = await _context.Piezas
                .Include(p => p.Marca)
                .Include(p => p.MaterialPiezas)
                .Include(p => p.Matriz).FirstOrDefaultAsync(m => m.Id == id);

            if (Pieza == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}

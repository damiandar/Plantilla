using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AccesoriosArgentinos.Modelos;

namespace AccesoriosArgentinos._Pages_OrdenesDetalle
{
    public class DeleteModel : PageModel
    {
        private readonly AccesoriosArgentinos.Modelos.AccesoriosDbContext _context;

        public DeleteModel(AccesoriosArgentinos.Modelos.AccesoriosDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public OrdenesProduccionDetalle OrdenesProduccionDetalle { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            OrdenesProduccionDetalle = await _context.OrdenesProduccionDetalles
                .Include(o => o.Estado)
                .Include(o => o.Matriz)
                .Include(o => o.Operario).FirstOrDefaultAsync(m => m.PiezaId == id);

            if (OrdenesProduccionDetalle == null)
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

            OrdenesProduccionDetalle = await _context.OrdenesProduccionDetalles.FindAsync(id);

            if (OrdenesProduccionDetalle != null)
            {
                _context.OrdenesProduccionDetalles.Remove(OrdenesProduccionDetalle);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}

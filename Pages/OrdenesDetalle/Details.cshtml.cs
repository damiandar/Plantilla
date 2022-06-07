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
    public class DetailsModel : PageModel
    {
        private readonly AccesoriosArgentinos.Modelos.AccesoriosDbContext _context;

        public DetailsModel(AccesoriosArgentinos.Modelos.AccesoriosDbContext context)
        {
            _context = context;
        }

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
                .Include(o => o.Operario).FirstOrDefaultAsync(m => m.PiezaCodigo == id);

            if (OrdenesProduccionDetalle == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AccesoriosArgentinos.Modelos;

namespace AccesoriosArgentinos._Pages_Ordenes
{
    public class DetailsModel : PageModel
    {
        private readonly AccesoriosArgentinos.Modelos.AccesoriosDbContext _context;

        public DetailsModel(AccesoriosArgentinos.Modelos.AccesoriosDbContext context)
        {
            _context = context;
        }

        public OrdenesProduccionCabecera OrdenesProduccionCabecera { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            OrdenesProduccionCabecera = await _context.OrdenesProduccionCabeceras
                .Include(o => o.Inyectora).FirstOrDefaultAsync(m => m.Id == id);

            if (OrdenesProduccionCabecera == null)
            {
                return NotFound();
            }
            var Items = _context.OrdenesProduccionDetalles
                 .Include(x => x.Pieza)
                 .ThenInclude(x => x.Matriz)
                 .ThenInclude(x => x.Deposito)
                 .Include(x => x.Pieza)
                 .ThenInclude(x => x.Material)
                 .Where(x => x.OrdenProduccionCabeceraId == id)
                 .ToList();
            ViewData["Items"] = Items;
            return Page();
        }
    }
}

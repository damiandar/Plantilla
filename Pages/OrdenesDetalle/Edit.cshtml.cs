using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AccesoriosArgentinos.Modelos;

namespace AccesoriosArgentinos._Pages_OrdenesDetalle
{
    public class EditModel : PageModel
    {
        private readonly AccesoriosArgentinos.Modelos.AccesoriosDbContext _context;

        public EditModel(AccesoriosArgentinos.Modelos.AccesoriosDbContext context)
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
                .Include(o => o.Operario).FirstOrDefaultAsync(m => m.PiezaCodigo == id);

            if (OrdenesProduccionDetalle == null)
            {
                return NotFound();
            }
           ViewData["EstadoId"] = new SelectList(_context.EstadosProduccion, "Id", "Id");
           ViewData["MatrizId"] = new SelectList(_context.Matrices, "Id", "Id");
           ViewData["OperarioId"] = new SelectList(_context.Operarios, "Id", "Id");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(OrdenesProduccionDetalle).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrdenesProduccionDetalleExists(OrdenesProduccionDetalle.PiezaCodigo))
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

        private bool OrdenesProduccionDetalleExists(int id)
        {
            return _context.OrdenesProduccionDetalles.Any(e => e.PiezaCodigo == id);
        }
    }
}

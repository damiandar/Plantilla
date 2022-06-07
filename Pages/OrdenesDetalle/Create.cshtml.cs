using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using AccesoriosArgentinos.Modelos;

namespace AccesoriosArgentinos._Pages_OrdenesDetalle
{
    public class CreateModel : PageModel
    {
        private readonly AccesoriosArgentinos.Modelos.AccesoriosDbContext _context;

        public CreateModel(AccesoriosArgentinos.Modelos.AccesoriosDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["EstadoId"] = new SelectList(_context.EstadosProduccion, "Id", "Id");
        ViewData["MatrizId"] = new SelectList(_context.Matrices, "Id", "Id");
        ViewData["OperarioId"] = new SelectList(_context.Operarios, "Id", "Id");
            return Page();
        }

        [BindProperty]
        public OrdenesProduccionDetalle OrdenesProduccionDetalle { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.OrdenesProduccionDetalles.Add(OrdenesProduccionDetalle);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

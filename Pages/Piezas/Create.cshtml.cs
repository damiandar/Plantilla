using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using AccesoriosArgentinos.Modelos;

namespace AccesoriosArgentinos._Pages_Piezas
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
            ViewData["MarcaId"] = new SelectList(_context.Marcas, "Id", "Descripcion");
            ViewData["MaterialId"] = new SelectList(_context.Materiales, "Id", "Descripcion");
            ViewData["MatrizId"] = new SelectList(_context.Matrices, "Id", "Descripcion");
            ViewData["Inyectoras"] = new SelectList(_context.Inyectoras, "Id", "Descripcion");
            return Page();
        }

        [BindProperty]
        public Pieza Pieza { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Piezas.Add(Pieza);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

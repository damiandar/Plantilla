using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AccesoriosArgentinos.Modelos;

namespace AccesoriosArgentinos._Pages_Piezas
{
    public class EditModel : PageModel
    {
        private readonly AccesoriosArgentinos.Modelos.AccesoriosDbContext _context;

        public EditModel(AccesoriosArgentinos.Modelos.AccesoriosDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Pieza Pieza { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Pieza = await _context.Piezas
                .Include(p => p.Marca)
                .Include(p => p.Material)
                .Include(p => p.Matriz).FirstOrDefaultAsync(m => m.Id == id);

            if (Pieza == null)
            {
                return NotFound();
            }
           ViewData["MarcaId"] = new SelectList(_context.Marcas, "Id", "Id");
           ViewData["MaterialId"] = new SelectList(_context.Materiales, "Id", "Id");
           ViewData["MatrizId"] = new SelectList(_context.Matrices, "Id", "Id");
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

            _context.Attach(Pieza).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PiezaExists(Pieza.Id))
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

        private bool PiezaExists(int id)
        {
            return _context.Piezas.Any(e => e.Id == id);
        }
    }
}

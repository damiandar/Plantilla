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
    public class DeleteModel : PageModel
    {
        private readonly AccesoriosArgentinos.Modelos.AccesoriosDbContext _context;

        public DeleteModel(AccesoriosArgentinos.Modelos.AccesoriosDbContext context)
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
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Pieza = await _context.Piezas.FindAsync(id);

            if (Pieza != null)
            {
                _context.Piezas.Remove(Pieza);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}

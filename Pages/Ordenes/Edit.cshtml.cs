using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AccesoriosArgentinos.Modelos;

namespace AccesoriosArgentinos._Pages_Ordenes
{
    public class EditModel : PageModel
    {
        private readonly AccesoriosArgentinos.Modelos.AccesoriosDbContext _context;

        public EditModel(AccesoriosArgentinos.Modelos.AccesoriosDbContext context)
        {
            _context = context;
        }

        [BindProperty]
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
            Items= await _context.OrdenesProduccionDetalles.Where(x=> x.OrdenProduccionCabeceraId==id).ToList();
            Piezas=await _context.Piezas.Where(x=> x.MatrizId==OrdenesProduccionCabecera.MatrizId).ToList();
           ViewData["InyectoraId"] = new SelectList(_context.Inyectoras, "Id", "Id");
           ViewData["Items"]=Items;
           ViewData["Piezas"]=new SelectList(Piezas,"Id","Descripcion");
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

            _context.Attach(OrdenesProduccionCabecera).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrdenesProduccionCabeceraExists(OrdenesProduccionCabecera.Id))
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

        private bool OrdenesProduccionCabeceraExists(int id)
        {
            return _context.OrdenesProduccionCabeceras.Any(e => e.Id == id);
        }
    }
}

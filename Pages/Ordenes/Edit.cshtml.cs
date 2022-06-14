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
            ViewData["OrdenId"] = id; 
            OrdenesProduccionCabecera = await _context.OrdenesProduccionCabeceras
                .Include(o => o.Inyectora).FirstOrDefaultAsync(m => m.Id == id);

            
            if (OrdenesProduccionCabecera == null)
            {
                return NotFound();
            }

            var Items = _context.OrdenesProduccionDetalles
                    .Include(x => x.Pieza)
                        .ThenInclude(x => x.Material)
                        .Where(x => x.OrdenProduccionCabeceraId == id).ToList();
            var Piezas = _context.Piezas.Where(x => x.InyectoraId == OrdenesProduccionCabecera.InyectoraId).ToList();
            ViewData["InyectoraId"] = new SelectList(_context.Inyectoras, "Id", "Id");
            ViewData["Items"] = Items;
            ViewData["Piezas"] = new SelectList(Piezas, "Id", "Descripcion");
            return Page();
        }

        public void OnPostPieza(int codigo,int cantidad) {
            /*int OrdenId = 0;
            if (int.TryParse(ViewData["OrdenId"].ToString(), out int intValue)) {
                OrdenId = intValue;
            }*/
   
            
            var valor1 = codigo;
            var valor2 = cantidad;

            var Pieza = _context.Piezas.Where(x => x.Id == codigo).First();

            var Item = new OrdenesProduccionDetalle();
            Item.Pieza = Pieza;
            Item.OrdenProduccionCabeceraId = OrdenesProduccionCabecera.Id;
            Item.Cantidad = cantidad;
            _context.OrdenesProduccionDetalles.Add(Item);
            _context.SaveChanges();

            var Items = _context.OrdenesProduccionDetalles
                        .Include(x=>x.Pieza)
                        .ThenInclude(x=>x.Material)
                        .Where(x => x.OrdenProduccionCabeceraId == OrdenesProduccionCabecera.Id)
                        .ToList();
            var Piezas = _context.Piezas.Where(x => x.InyectoraId == OrdenesProduccionCabecera.InyectoraId).ToList();
            ViewData["InyectoraId"] = new SelectList(_context.Inyectoras, "Id", "Id");
            ViewData["Items"] = Items;
            ViewData["Piezas"] = new SelectList(Piezas, "Id", "Descripcion");

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

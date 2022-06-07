using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AccesoriosArgentinos.Modelos;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace AccesoriosArgentinos._Pages_Piezas
{
    public class EditModel : PageModel
    {
        [BindProperty]
        public PiezaVM PiezaVM { get; set; }

        private readonly AccesoriosArgentinos.Modelos.AccesoriosDbContext _context;
        private readonly IWebHostEnvironment _hostingEnvironment;

        public EditModel(AccesoriosArgentinos.Modelos.AccesoriosDbContext context,IWebHostEnvironment hostingEnviroment)
        {
            _context = context;
            _hostingEnvironment=hostingEnviroment;
        }
 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            PiezaVM = new PiezaVM();

            if (id == null)
            {
                return NotFound();
            }

            PiezaVM.Pieza = await _context.Piezas
                .Include(p => p.Marca)
                .Include(p => p.Material)
                .Include(p => p.Matriz).FirstOrDefaultAsync(m => m.Id == id);

            if (PiezaVM.Pieza == null)
            {
                return NotFound();
            } 
            PiezaVM.ListaMarcas = new SelectList(_context.Marcas, "Id", "Descripcion");
            PiezaVM.ListaMateriales = new SelectList(_context.Materiales, "Id", "Descripcion");
            PiezaVM.ListaMatrices = new SelectList(_context.Matrices, "Id", "Descripcion");
            PiezaVM.ListaInyectoras = new SelectList(_context.Inyectoras, "Id", "Descripcion");
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
            if(PiezaVM.Pieza.Foto!=null){
                string carpetaFotos=Path.Combine(_hostingEnvironment.WebRootPath,"images");
                //string nombreArchivo=Pieza.Foto.FileName;
                string nombreArchivo= PiezaVM.Pieza.Codigo + ".jpg";
                string rutaCompleta=Path.Combine(carpetaFotos,nombreArchivo);
                //subimos la imagen al servidor
                PiezaVM.Pieza.Foto.CopyTo(new FileStream(rutaCompleta,FileMode.Create));
                //guardar la ruta de la imagen en la base de datos
                PiezaVM.Pieza.FotoRuta=nombreArchivo;
            }
            _context.Attach(PiezaVM.Pieza).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PiezaExists(PiezaVM.Pieza.Id))
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

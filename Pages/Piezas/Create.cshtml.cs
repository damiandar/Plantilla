using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using AccesoriosArgentinos.Modelos;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace AccesoriosArgentinos._Pages_Piezas
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public PiezaVM PiezaVM { get; set; }

        private readonly AccesoriosArgentinos.Modelos.AccesoriosDbContext _context;
        private readonly IWebHostEnvironment _hostingEnvironment;
        
        public CreateModel(AccesoriosArgentinos.Modelos.AccesoriosDbContext context,IWebHostEnvironment hostingEnviroment)
        {
            _context = context;
            _hostingEnvironment=hostingEnviroment;
        }

        public IActionResult OnGet()
        {
            PiezaVM = new PiezaVM();
            PiezaVM.Pieza = new Pieza();
            PiezaVM.ListaMarcas = new SelectList(_context.Marcas, "Id", "Descripcion");
            PiezaVM.ListaMateriales = new SelectList(_context.Materiales, "Id", "Descripcion");
            PiezaVM.ListaMatrices = new SelectList(_context.Matrices, "Id", "Descripcion");
            PiezaVM.ListaInyectoras = new SelectList(_context.Inyectoras, "Id", "Descripcion");
            return Page();
        }

   
        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            if(PiezaVM.Pieza.Foto!=null){
                string carpetaFotos=Path.Combine(_hostingEnvironment.WebRootPath,"images");
                string nombreArchivo= PiezaVM.Pieza.Codigo + ".jpg";
                string rutaCompleta=Path.Combine(carpetaFotos,nombreArchivo);
                //subimos la imagen al servidor
                PiezaVM.Pieza.Foto.CopyTo(new FileStream(rutaCompleta,FileMode.Create));
                //guardar la ruta de la imagen en la base de datos
                PiezaVM.Pieza.FotoRuta=nombreArchivo;
            }
            _context.Piezas.Add(PiezaVM.Pieza);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

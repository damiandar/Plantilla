using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using AccesoriosArgentinos.Modelos;

namespace AccesoriosArgentinos._Pages_Materiales
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
            return Page();
        }

        [BindProperty]
        public Material Material { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Materiales.Add(Material);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

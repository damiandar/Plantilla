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
    public class IndexModel : PageModel
    {
        private readonly AccesoriosArgentinos.Modelos.AccesoriosDbContext _context;

        public IndexModel(AccesoriosArgentinos.Modelos.AccesoriosDbContext context)
        {
            _context = context;
        }

        public IList<Pieza> Pieza { get;set; }

        public async Task OnGetAsync()
        {
            Pieza = await _context.Piezas
                .Include(p => p.Marca)
                .Include(p => p.MaterialPiezas)
                .Include(p => p.Matriz).ToListAsync();
        }
    }
}

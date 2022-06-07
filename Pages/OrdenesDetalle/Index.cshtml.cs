using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AccesoriosArgentinos.Modelos;

namespace AccesoriosArgentinos._Pages_OrdenesDetalle
{
    public class IndexModel : PageModel
    {
        private readonly AccesoriosArgentinos.Modelos.AccesoriosDbContext _context;

        public IndexModel(AccesoriosArgentinos.Modelos.AccesoriosDbContext context)
        {
            _context = context;
        }

        public IList<OrdenesProduccionDetalle> OrdenesProduccionDetalle { get;set; }

        public async Task OnGetAsync()
        {
            OrdenesProduccionDetalle = await _context.OrdenesProduccionDetalles
                .Include(o => o.Estado)
                .Include(o => o.Matriz)
                .Include(o => o.Operario).ToListAsync();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AccesoriosArgentinos.Modelos;

namespace AccesoriosArgentinos._Pages_Ordenes
{
    public class IndexModel : PageModel
    {
        private readonly AccesoriosArgentinos.Modelos.AccesoriosDbContext _context;

        public IndexModel(AccesoriosArgentinos.Modelos.AccesoriosDbContext context)
        {
            _context = context;
        }

        public IList<OrdenesProduccionCabecera> OrdenesProduccionCabecera { get;set; }

        public async Task OnGetAsync()
        {
            OrdenesProduccionCabecera = await _context.OrdenesProduccionCabeceras
                .Include(o => o.Inyectora).ToListAsync();
        }
    }
}

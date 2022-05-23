using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using AccesoriosArgentinos.Modelos;

namespace AccesoriosArgentinos.Pages
{
    public class IndexModel : PageModel
    {
        public List<Material> Materiales {get;set;}
        private readonly ILogger<IndexModel> _logger;
        private readonly AccesoriosDbContext _context;
        public IndexModel(ILogger<IndexModel> logger,AccesoriosDbContext db)
        {
            _logger = logger;
            _context=db;
        }

        public void OnGet()
        {
            this.Materiales=_context.Materiales.ToList();
        }
    }
}

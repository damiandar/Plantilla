using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AccesoriosArgentinos.Modelos; 
namespace AccesoriosArgentinos.Pages
{
    public class BillingModel : PageModel
    {
        private AccesoriosDbContext _context;
        public BillingModel(AccesoriosDbContext db){
            _context=db;
        }
        public void OnGet()
        {
            var o=_context.Marcas.ToList();
        }
    }
}

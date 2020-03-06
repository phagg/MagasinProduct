using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MagasinProduct.Data;
using MagasinProduct.Models;

namespace MagasinProduct
{
    public class IndexModel : PageModel
    {
        private readonly MagasinProduct.Data.MagasinProductContext _context;

        public IndexModel(MagasinProduct.Data.MagasinProductContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; }

        public async Task OnGetAsync()
        {
            Product = await _context.Product.ToListAsync();
        }
    }
}

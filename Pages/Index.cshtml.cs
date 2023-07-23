using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChocoShop.Data;
using ChocoShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ChocoShop.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ChocoShopContext db;
        public IndexModel(ChocoShopContext db) => this.db = db;
        public List<Product> Products { get; set; } = new List<Product>();
        public Product FeaturedProduct { get; set; }
        public async Task OnGetAsync()
        {
            Products = await db.Products.ToListAsync();
            FeaturedProduct = Products.ElementAt(new Random().Next(Products.Count));
        }
    }
}

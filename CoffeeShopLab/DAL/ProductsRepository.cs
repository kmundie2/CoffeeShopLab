using CoffeeShopLab.Models;
using Microsoft.EntityFrameworkCore;

namespace CoffeeShopLab.DAL
{
    public class ProductsRepository
    {
        private readonly CoffeeShopLabDbContext _context;

        public ProductsRepository(CoffeeShopLabDbContext context)
        {
            _context = context;
        }


        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVC_Storage.Models;
using MVC_Storage.Models.ViewModels;

namespace MVC_Storage.Data
{
    public class MVC_StorageContext : DbContext
    {
        public MVC_StorageContext (DbContextOptions<MVC_StorageContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Product { get; set; } = default!;
        public DbSet<ProductViewModel> ProductIndexViewModel { get; set; } = default!;
    }
}

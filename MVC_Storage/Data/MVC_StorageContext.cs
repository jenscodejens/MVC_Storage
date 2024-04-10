using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVC_Storage.Models;

namespace MVC_Storage.Data
{
    public class MVC_StorageContext : DbContext
    {
        public MVC_StorageContext (DbContextOptions<MVC_StorageContext> options)
            : base(options)
        {
        }

        public DbSet<MVC_Storage.Models.Product> Product { get; set; } = default!;
    }
}

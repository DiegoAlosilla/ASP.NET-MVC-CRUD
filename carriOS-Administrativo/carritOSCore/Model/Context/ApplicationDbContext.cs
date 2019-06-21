using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace carritOSCore.Model.Entities
{
    public partial class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options)
            : base(options)
        {
        }

        public DbSet<BusinessOwner> BusinessOwners { get; set; }
    }
}

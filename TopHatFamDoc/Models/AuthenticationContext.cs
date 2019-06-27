using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TopHatFamDoc.Models;

namespace TopHatFamDoc.Models
{
    public class AuthenticationContext: IdentityDbContext
    {
        public AuthenticationContext(DbContextOptions options):base(options)
        {

        }

        public DbSet<ApplicationUser>ApplicationUser { get; set; }

        public DbSet<TopHatFamDoc.Models.Pacienti> Pacienti { get; set; }
        

    }
}

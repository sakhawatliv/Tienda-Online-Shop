using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Tienda.Model.ApplicationUser;

namespace Tienda.Repository.Database
{
    public class TiendaDbContext:IdentityDbContext<ApplicationUser>
    {
        public TiendaDbContext(DbContextOptions<TiendaDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}

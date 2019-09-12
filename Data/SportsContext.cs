using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blazor.CRUD.Sample.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Blazor.CRUD.Sample.Api.Data
{
    public class SportsContext:DbContext
    {
        public SportsContext(DbContextOptions<SportsContext> options):base(options)
        {

        }

        public DbSet<Player> Player { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjMVCHelloWorld.Models;

namespace ProjMVCHelloWorld.Data
{
    public class ProjMVCHelloWorldContext : DbContext
    {
        public ProjMVCHelloWorldContext (DbContextOptions<ProjMVCHelloWorldContext> options)
            : base(options)
        {
        }

        public DbSet<ProjMVCHelloWorld.Models.Projects> Projects { get; set; }
    }
}

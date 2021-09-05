using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebCad.Models;

namespace WebCad.Data
{
    public class WebCadContext : DbContext
    {
        public WebCadContext (DbContextOptions<WebCadContext> options)
            : base(options)
        {
        }

        public DbSet<WebCad.Models.Department> Department { get; set; }
    }
}

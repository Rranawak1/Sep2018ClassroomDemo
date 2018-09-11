using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region
using System.Data.Entity;
using Chinook.Data;
#endregion

namespace ChinookSystem.DAL
{
    internal class ChinookContext:DbContext
    {
        public ChinookContext() : base("ChibookDB")
        {

        }

        public DbSet<Albums> Albums { get; set; }
        public DbSet<Artist> Artists { get; set; }
    }
}


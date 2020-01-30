using Domain.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Data
{
    public class DataContext: DbContext
    {
        public DataContext() : base("DefaultConnection")
        {
        }

        public DbSet<Estudiante> Estudiantes { get; set; }
    }
}

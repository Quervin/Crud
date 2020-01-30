using Domain.Data;
using Domain.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Consults
{
    public class SqlComands
    {
        private DataContext db = new DataContext();

        public IQueryable<Estudiante> LoadEstudiante()
        {
           return db.Estudiantes.OrderBy(e => e.Nombre);
        }
    }
}

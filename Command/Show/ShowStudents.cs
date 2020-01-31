using Domain;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Show
{
    public class ShowStudents
    {
        private ContextDbEstudiante _db;

        public ShowStudents()
        {
            _db = new ContextDbEstudiante();
        }

        public List<Estudiante> LoadEstudiante()
        {
            List<Estudiante> ListaEstudiantes = _db.Estudiante.ToList();

            return ListaEstudiantes;
        }
    }
}

using Domain;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Comands
{
    public class ComandsStudent
    {
        private ContextDbEstudiante _db;

        public ComandsStudent()
        {
            _db = new ContextDbEstudiante();
        }

        public void AddEstudiante(Estudiante estudiante)
        {
            _db.Estudiante.Add(estudiante);
            _db.SaveChanges();
        }

        public void EditEstudiante(Estudiante estudiante)
        {
            var result = _db.Estudiante.Find(estudiante.estudiante_id);
            if (result != null)
            {
                result.nombre = estudiante.nombre;
                result.primer_apellido = estudiante.primer_apellido;
                result.segundo_apellido = estudiante.segundo_apellido;
                result.edad = estudiante.edad;

                _db.Entry(result).State = EntityState.Modified;
                _db.SaveChanges();
            }
        }

        public void DeleteEstudiante(Estudiante estudiante)
        {
            var result = _db.Estudiante.Find(estudiante.estudiante_id);
            if (result != null)
            {
                _db.Entry(result).State = EntityState.Deleted;
                _db.SaveChanges();
            }
        }
    }
}

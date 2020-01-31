
using Command.Show;
using Domain.Entities;
using Logica.Comands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI.Controllers
{
    public class EstudiantesController : ApiController
    {
        private ShowStudents Show = new ShowStudents();

        private ComandsStudent Comand = new ComandsStudent();
        public HttpResponseMessage GetEstudiantes()
        {
            var estudiantes = Show.LoadEstudiante();

            return Request.CreateResponse(HttpStatusCode.OK, estudiantes);
        }

        public string Post(Estudiante estudiante)
        {
            try
            {
                Comand.AddEstudiante(estudiante);

                return "Added Successfully";
            }
            catch(Exception)
            {
                return "Failed to Add";
            }
        }

        public string Put(Estudiante estudiante)
        {
            try
            {
                Comand.EditEstudiante(estudiante);

                return "Updated Successfully";
            }
            catch (Exception)
            {
                return "Failed to Update";
            }
        }

        public string Delete(Estudiante estudiante)
        {
            try
            {
                Comand.DeleteEstudiante(estudiante);

                return "Deleted Successfully";
            }
            catch (Exception)
            {
                return "Failed to Delete";
            }
        }
    }
}

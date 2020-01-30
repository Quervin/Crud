using Command.Consults;
using Domain.Data;
using Domain.Data.Entities;
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
        private SqlComands Cm = new SqlComands();
        public IQueryable<Estudiante> GetEstudiantes()
        {
            return Cm.LoadEstudiante();
        }
    }
}

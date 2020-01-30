using Domain.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Consults
{
    public class SqlComands
    {
        private readonly DataContext _dataContext;
        public SqlComands(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public void LoadEstudiante()
        {
            _dataContext.Estudiantes.OrderBy(p => p.Description).ToList();
        }
    }
}

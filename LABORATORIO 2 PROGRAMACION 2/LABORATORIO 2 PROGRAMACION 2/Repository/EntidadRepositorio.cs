using LABORATORIO_2_PROGRAMACION_2.Data;
using LABORATORIO_2_PROGRAMACION_2.Dominio;
using LABORATORIO_2_PROGRAMACION_2.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LABORATORIO_2_PROGRAMACION_2.Repository
{
    public class EntidadRepositorio : IDatos 
    {

        private ApplicationDbContext app;

        public EntidadRepositorio(ApplicationDbContex app)
        {
            this.app = app;
        }

       public void Save(Entidad E)
       {
            app.Update(E);
            app.SaveChanges();
       }
        List<Entidad> IDatos.listardatos()
        {
            return app.Entidades.ToList();
        }

        
    }
}

using LABORATORIO_2_PROGRAMACION_2.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LABORATORIO_2_PROGRAMACION_2.Service
{
    interface IDatos
    {
        void Save(Entidad E);

        List<Entidad> listardatos();
    }
}

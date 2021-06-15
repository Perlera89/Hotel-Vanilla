using Hotel_Vanilla.ENTIDAD;
using Hotel_Vanilla.MODELO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Vanilla.CONTROLADOR
{
    class CEstados
    {
        MEstados estados = new MEstados();
        public List<Estados> MostrarEstados()
        {
            return estados.MostrarEstados();
        }
    }
}

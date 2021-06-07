using Hotel_Vanilla.ENTIDAD;
using Hotel_Vanilla.MODELO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Vanilla.CONTROLADOR
{
    class CSucesos
    {
        MSucesos sucesos = new MSucesos();

        public List<Sucesos> ConsultarSucesos()
        {
            return sucesos.ConsultarSucesos();
        }

        public List<Sucesos> ConsultarUltimosSucesos()
        {
            return sucesos.ConsultarUltimosSucesos();
        }
    }
}

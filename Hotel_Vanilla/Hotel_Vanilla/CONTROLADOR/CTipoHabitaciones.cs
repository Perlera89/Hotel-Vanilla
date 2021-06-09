using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel_Vanilla.MODELO;
using Hotel_Vanilla.ENTIDAD;

namespace Hotel_Vanilla.CONTROLADOR
{
    class CTipoHabitaciones
    {
        MTipoHabitacion mTipoHabitacion = new MTipoHabitacion();

        //mostrar
        public List<TipoHabitaciones> CargarCBTipoHabitacion()
        {
            return mTipoHabitacion.ConsultarTipoHabitaciones();
        }

    }

}

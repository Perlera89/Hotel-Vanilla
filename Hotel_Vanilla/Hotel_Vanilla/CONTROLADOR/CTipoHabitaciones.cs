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
        public List<TipoHabitaciones> MostrarTipoCB()
        {
            return mTipoHabitacion.ConsultarTipoHabitaciones();
        }

        public List<sp_MostrarTipoHabitaciones> MostrarTipoHabitaciones()
        {
            return mTipoHabitacion.MostrarTipoHabitaciones();
        }

        //Agregar
        public void AgregarTipoHabitacion(sp_MostrarTipoHabitaciones tipo)
        {
            mTipoHabitacion.AgregarTipoHabitacion(tipo);
        }

        public void EliminarTipoHabitacion(sp_MostrarTipoHabitaciones tipo)
        {
            mTipoHabitacion.EliminarTipoHabitaciones(tipo);
        }

    }

}

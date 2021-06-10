using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel_Vanilla.ENTIDAD;
using Hotel_Vanilla.MODELO;

namespace Hotel_Vanilla.CONTROLADOR
{
    class CspMostrarHabitaciones
    {
        MHabitaciones Mhabitacion = new MHabitaciones();
        public List<sp_MostrarHabitaciones> ConsultarHuespedes()
        {
            return Mhabitacion.ConsultarHabitacion(); //Llama al modelo
        }

        public void AgregarHabitacion(sp_MostrarHabitaciones habitaciones, int id)
        {
            Mhabitacion.AgregarHabitacion(habitaciones, id);
        }

        public void ActualizarHabitacion(int codigo, String nHabitaciones, Decimal tarifa, int id)
        {
            Mhabitacion.ActualizarHabitacion(codigo, nHabitaciones, tarifa, id);
        }

        public void EliminarHabitacion(int id)
        {
            Mhabitacion.EliminarHabitacion(id);
        }
    }
}

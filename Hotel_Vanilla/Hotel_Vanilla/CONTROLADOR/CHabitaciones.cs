using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel_Vanilla.ENTIDAD;
using Hotel_Vanilla.MODELO;

namespace Hotel_Vanilla.CONTROLADOR
{
    class CHabitaciones
    {
        MHabitaciones Mhabitacion = new MHabitaciones();
        public List<sp_MostrarHabitaciones> ConsultarHabitacion()
        {
            return Mhabitacion.ConsultarHabitacion();
        }

        public List<spBuscarHabitacion> BuscarHabitaciones(string buscador)
        {
            return Mhabitacion.BuscarHabitaciones(buscador);
        }

        public void AgregarHabitacion(Habitaciones habitacion)
        {
            Mhabitacion.AgregarHabitacion(habitacion);
        }

        public void ActualizarHabitacion(Habitaciones habitacion)
        {
            Mhabitacion.ActualizarHabitacion(habitacion);
        }

        public void EliminarHabitacion(Habitaciones habitacion)
        {
            Mhabitacion.EliminarHabitacion(habitacion);
        }

        public int TotalHabitaciones()
        {
            return Mhabitacion.TotalHabitaciones();
        }
    }
}

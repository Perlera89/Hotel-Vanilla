using Hotel_Vanilla.ENTIDAD;
using Hotel_Vanilla.MODELO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Vanilla.CONTROLADOR
{
    class CManejoReservas
    {
        MManejoReservas mReservas = new MManejoReservas();

        public List<spMostrarManejoReservas> ConsultarReservas()
        {
            return mReservas.ConsultarReservas();
        }

        public List<spBuscarReservacion> BuscarReservaciones(string buscador)
        {
            return mReservas.BuscarReservaciones(buscador);
        }

        public void AgregarReserva(ManejoReservas Reservas)
        {
            mReservas.AgregarReserva(Reservas);
        }

        public void EliminarReserva(ManejoReservas Reservas)
        {
            mReservas.EliminarReserva(Reservas);
        }

        public void ActualizarReserva(ManejoReservas Reservas)
        {
            mReservas.ActualizarReserva(Reservas);
        }
    }
}

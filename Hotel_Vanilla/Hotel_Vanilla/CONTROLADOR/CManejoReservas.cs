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

        //MOSTRAR
        public List<spMostrarManejoReservas> ConsultarReservas()
        {
            return mReservas.ConsultarReservas(); //Llama al modelo
        }

        //GUARDAR
        public void AgregarReserva(ManejoReservas Reservas)
        {
            mReservas.AgregarReserva(Reservas);
        }

        //ELIMINAR
        public void EliminarReserva(ManejoReservas Reservas)
        {
            mReservas.EliminarReserva(Reservas);
        }

        //MODIFICAR
        public void ActualizarReserva(ManejoReservas Reservas)
        {
            mReservas.ActualizarReserva(Reservas);
        }
    }
}

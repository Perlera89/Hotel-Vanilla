using Hotel_Vanilla.ENTIDAD;
using Hotel_Vanilla.MODELO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Vanilla.CONTROLADOR
{
    class CHuespedes
    {
        MHuespedes mHuespedes = new MHuespedes();
        public List<spMostrarHuesped> ConsultarHuespedes()
        {
            return mHuespedes.ConsultarHuespedes(); //Llama al modelo
        }

        public List<spBuscarHuesped> BuscarHuespedes(string buscador)
        {
            return mHuespedes.BuscarHuespedes(buscador);
        }

        public void AgregarHuesped(Huespedes Huespedes)
        {
            mHuespedes.AgregarHuesped(Huespedes);
        }

        public void EliminarHuesped(Huespedes huesped)
        {
            mHuespedes.EliminarHuesped(huesped);
        }

        public void ModificarHuesped(Huespedes huesped)
        {
            mHuespedes.ActualizarHuesped(huesped);
        }

        public int TotalHuespedes()
        {
            return mHuespedes.TotalHuespedes();
        }
    }
}

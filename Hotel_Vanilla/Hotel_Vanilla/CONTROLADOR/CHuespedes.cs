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
        public List<Huespedes> ConsultarHuespedes()
        {
            return mHuespedes.ConsultarHuespedes(); //Llama al modelo
        }

        public void AgregarHuesped(Huespedes Huespedes)
        {
            mHuespedes.AgregarHuesped(Huespedes);
        }

        public void EliminarHuesped(Huespedes huespedes)
        {
            mHuespedes.EliminarHuesped(huespedes);
        }

        public void ModificarHuesped(Huespedes huesped)
        {
            mHuespedes.ActualizarHuesped(huesped);
        }
    }
}

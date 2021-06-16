using Hotel_Vanilla.ENTIDAD;
using Hotel_Vanilla.MODELO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Vanilla.CONTROLADOR
{
    public class CUsuarios
    {
        MUsuarios mUsuarios = new MUsuarios();
        public void AgregarUsuario(Usuarios usu)
        {
            mUsuarios.AgregarUsuario(usu); 
        }

        public List<Usuarios> CompararDatos(Usuarios usu)
        {
            return mUsuarios.CompararDatos(usu);
        }

        public void ActualizarUsuario(Usuarios usuario)
        {
            mUsuarios.ActualizarUsuario(usuario);
        }
    }
}

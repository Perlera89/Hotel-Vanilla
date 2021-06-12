using Dapper;
using Hotel_Vanilla.ENTIDAD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Vanilla.MODELO
{
    class MUsuarios
    {
        IDbConnection cn = Conexion.conectar();

        public List<Usuarios> ConsultarUsuario()
        {

            string consulta = "sp_MostrarUsuarios";
            cn.Open();
            List<Usuarios> usuarios = cn.Query<Usuarios>(consulta, commandType: CommandType.StoredProcedure).ToList();
            cn.Close();
            return usuarios;
        }
        public void AgregarUsuario(Usuarios usu)
        {
            string consulta = "insert into Usuarios values(@nombre, @correo, @clave)";
         
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@nombre", usu.nombre, DbType.String);
            parametros.Add("@correo", usu.correo, DbType.String);
            parametros.Add("@clave", usu.clave, DbType.String);
         
            cn.Open();
            cn.Execute(consulta, parametros, commandType: CommandType.Text);
            cn.Close();
        }
    
        public List<Usuarios> CompararDatos(Usuarios usu)
        {
            string consulta = "sp_ComprobarDatos";
            
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@correo", usu.correo, DbType.String);
            parametros.Add("@clave", usu.clave, DbType.String);

            cn.Open();
            List<Usuarios> usuList = cn.Query<Usuarios>(consulta, parametros, commandType: CommandType.StoredProcedure).ToList();
            cn.Close();

            return usuList;
        }
    }
}

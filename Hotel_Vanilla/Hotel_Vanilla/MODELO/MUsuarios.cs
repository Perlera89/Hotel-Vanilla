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
        IDbConnection conexion = Conexion.conectar();

        public List<Usuarios> ConsultarUsuario()
        {

            string consulta = "sp_MostrarUsuarios";
            conexion.Open();
            List<Usuarios> usuarios = conexion.Query<Usuarios>(consulta, commandType: CommandType.StoredProcedure).ToList();
            conexion.Close();
            return usuarios;
        }
        public void AgregarUsuario(Usuarios usu)
        {
            string consulta = "sp_InsertarUsuario";
         
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@nombre", usu.nombre, DbType.String);
            parametros.Add("@correo", usu.correo, DbType.String);
            parametros.Add("@clave", usu.clave, DbType.String);

            conexion.Open();
            conexion.Execute(consulta, parametros, commandType: CommandType.StoredProcedure);
            conexion.Close();
        }
    
        public List<Usuarios> CompararDatos(Usuarios usu)
        {
            string consulta = "sp_ComprobarDatos";
            
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@correo", usu.correo, DbType.String);
            parametros.Add("@clave", usu.clave, DbType.String);

            conexion.Open();
            List<Usuarios> usuList = conexion.Query<Usuarios>(consulta, parametros, commandType: CommandType.StoredProcedure).ToList();
            conexion.Close();

            return usuList;
        }

        //Modelo para actualizar usuarios con el procedimiento
        public void ActualizarUsuario(Usuarios usuario)
        {
            string consulta = "sp_ActualizarUsuario";
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@id", usuario.idUsuario, DbType.Int32);
            parametros.Add("@nombre", usuario.nombre, DbType.String);
            parametros.Add("@correo", usuario.correo, DbType.String);
            parametros.Add("@clave", usuario.clave, DbType.String);

            conexion.Open();
            conexion.Execute(consulta, parametros, commandType: CommandType.StoredProcedure);
            conexion.Close();
        }
    }
}

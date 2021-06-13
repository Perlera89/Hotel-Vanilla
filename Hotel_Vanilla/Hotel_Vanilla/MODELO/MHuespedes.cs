using Dapper;
using Hotel_Vanilla.ENTIDAD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Vanilla.MODELO
{
    class MHuespedes
    {
        //Modelo para consultar huespedes con el procedimiento
        IDbConnection conexion = Hotel_Vanilla.Conexion.conectar();
        public List<spMostrarHuesped> ConsultarHuespedes()
        {
            List<spMostrarHuesped> Huespedes = new List<spMostrarHuesped>();
            string consulta = "sp_Mostrarhuesped";
            conexion.Open();
            Huespedes = conexion.Query<spMostrarHuesped>(consulta, commandType: CommandType.StoredProcedure).ToList();
            conexion.Close();
            return Huespedes;
        }

        //Modelo para agregar huespedes con el procedimiento
        public void AgregarHuesped(Huespedes Huespedes)
        {
            string consulta = "sp_insertarHuesped";
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@nombres", Huespedes.nombres, DbType.String);
            parametros.Add("@apellidos", Huespedes.apellidos, DbType.String);
            parametros.Add("@direccion", Huespedes.direccion, DbType.String);
            parametros.Add("@telefono", Huespedes.telefono, DbType.String);
            parametros.Add("@correo", Huespedes.correo, DbType.String);
            parametros.Add("@idEstado_Fk", Huespedes.idEstado_FK, DbType.Int32);
            conexion.Open();
            conexion.Execute(consulta, parametros, commandType: CommandType.StoredProcedure);
            conexion.Close();
        }

        //Modelo para eliminar huespedes con el procedimiento
        public void EliminarHuesped(Huespedes huesped)
        {
            string consulta = "sp_eliminarhuesped";
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@id", huesped.idHuesped, DbType.Int32);
            conexion.Open();
            conexion.Execute(consulta, parametros, commandType: CommandType.StoredProcedure);
            conexion.Close();
        }

        //Modelo para actualizar huespedes con el procedimiento
        public void ActualizarHuesped(Huespedes huesped)
        {
            string consulta = "sp_actualizarHuesped";
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@idHuesped", huesped.idHuesped, DbType.Int32);
            parametros.Add("@nombres", huesped.nombres, DbType.String);
            parametros.Add("@apellidos", huesped.apellidos, DbType.String);
            parametros.Add("@direccion", huesped.direccion, DbType.String);
            parametros.Add("@telefono", huesped.telefono, DbType.String);
            parametros.Add("@correo", huesped.correo, DbType.String);
            parametros.Add("@idEstado_fk", huesped.idEstado_FK, DbType.Int32);
            conexion.Open();
            conexion.Execute(consulta, parametros, commandType: CommandType.StoredProcedure);
            conexion.Close();
        }

        //Modelo para la busqueda de huespedes
        public List<spBuscarHuesped> BuscarHuespedes(string buscador)
        {
            List<spBuscarHuesped> Huespedes = new List<spBuscarHuesped>();
            string consulta = "sp_BuscarHuesped";
            DynamicParameters parametro = new DynamicParameters();
            parametro.Add("@buscador", buscador);
            conexion.Open();
            Huespedes = conexion.Query<spBuscarHuesped>(consulta, parametro, commandType: CommandType.StoredProcedure).ToList();
            conexion.Close();
            return Huespedes;
        }

        //Consulta para mostrar el total de Huespedes
        public int TotalHuespedes()
        {
            int Huespedes;
            string consulta = "sp_TotalHuespedes";
            conexion.Open();
            Huespedes = conexion.QuerySingle<int>(consulta, commandType: CommandType.StoredProcedure);
            conexion.Close();
            return Huespedes;
        }
    }
}

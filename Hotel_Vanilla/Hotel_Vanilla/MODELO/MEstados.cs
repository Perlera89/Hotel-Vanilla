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
    class MEstados
    {
        //Modelo para mostrar los estados
        IDbConnection conexion = Conexion.conectar();
        public List<Estados> MostrarEstados()
        {
            List<Estados> estados = new List<Estados>();
            string consulta = "sp_MostrarEstados";
            conexion.Open();
            estados = conexion.Query<Estados>(consulta, commandType: CommandType.Text).ToList();
            conexion.Close();
            return estados;
        }

        //Modelo Agregar estado con el procedimiento
        public void AgregarEstado(Estados estado)
        {
            string consulta = "sp_InsertarEstado";
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@nombre", estado.nombreEstado, DbType.String);
            conexion.Open();
            conexion.Execute(consulta, parametros, commandType: CommandType.StoredProcedure);
            conexion.Close();
        }

        //Modelo para eliminar estado con el procedimiento
        public void EliminarEstado(Estados estado)
        {
            string consulta = "sp_EliminarEstado";
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@id", estado.idEstado, DbType.Int32);
            conexion.Open();
            conexion.Execute(consulta, parametros, commandType: CommandType.StoredProcedure);
            conexion.Close();
        }
    }
}

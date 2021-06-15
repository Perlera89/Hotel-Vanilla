using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel_Vanilla.ENTIDAD;
using Dapper;

namespace Hotel_Vanilla.MODELO
{
    class MTipoHabitacion
    {
        IDbConnection conexion = Conexion.conectar();

        //Modelo para cargar tipo habitaciones en combo box
        public List<TipoHabitaciones> ConsultarTipoHabitaciones()
        {
            List<TipoHabitaciones> habitaciones = new List<TipoHabitaciones>();
            string consulta = "sp_TipoHabitacion";
            conexion.Open();
            habitaciones = conexion.Query<TipoHabitaciones>(consulta, commandType: CommandType.StoredProcedure).ToList();
            conexion.Close();
            return habitaciones;
        }

        //Modelo para mostrar tipo habitaciones en los ajustes
        public List<sp_MostrarTipoHabitaciones> MostrarTipoHabitaciones()
        {
            List<sp_MostrarTipoHabitaciones> habitaciones = new List<sp_MostrarTipoHabitaciones>();
            string consulta = "sp_MostrarTipoHabitaciones";
            conexion.Open();
            habitaciones = conexion.Query<sp_MostrarTipoHabitaciones>(consulta, commandType: CommandType.StoredProcedure).ToList();
            conexion.Close();
            return habitaciones;
        }

        //Modelo Agregar Tipo habitaciones con el procedimiento
        public void AgregarTipoHabitacion(sp_MostrarTipoHabitaciones tipo)
        {
            string consulta = "sp_InsertarTipoHabitacion";
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@tipo", tipo.tipo, DbType.String);
            parametros.Add("@ocupantes", tipo.numeroOcupantes, DbType.Int32);
            conexion.Open();
            conexion.Execute(consulta, parametros, commandType: CommandType.StoredProcedure);
            conexion.Close();
        }

        //Modelo para eliminar tipo de habitacion con el procedimiento
        public void EliminarTipoHabitaciones(sp_MostrarTipoHabitaciones tipo)
        {
            string consulta = "sp_EliminarTipoHabitacion";
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@id", tipo.idTipoHabitacion, DbType.Int32);
            conexion.Open();
            conexion.Execute(consulta, parametros, commandType: CommandType.StoredProcedure);
            conexion.Close();
        }
    }
}

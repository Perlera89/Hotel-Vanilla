using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel_Vanilla.ENTIDAD;
using Dapper;
using System.Windows.Forms;

namespace Hotel_Vanilla.MODELO
{
    class MspMostrarHabitaciones
    {
        IDbConnection conexion = Conexion.conectar();
        public List<sp_MostrarHabitaciones> ConsultarHabitacion()
        {
            List<sp_MostrarHabitaciones> habitaciones = new List<sp_MostrarHabitaciones>();
            string consulta = "sp_MostrarHabitaciones";
            conexion.Open();
            habitaciones = conexion.Query<sp_MostrarHabitaciones>(consulta, commandType: CommandType.StoredProcedure).ToList();
            conexion.Close();
            return habitaciones;
        }

        public void AgregarHabitacion(sp_MostrarHabitaciones habitacion,int id)
        {
            string consulta = "sp_InsertarHabitacion";
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@numeroHabitacion", habitacion.numeroHabitacion, DbType.String);
            parametros.Add("@tarifa", habitacion.tarifa, DbType.Decimal);
            parametros.Add("@idTipoHabitacion_FK", id, DbType.Int32);
            //abrimos la conexion, ejecutamos la consulta y cerramos la conexion
            conexion.Open();
            conexion.Execute(consulta, parametros, commandType: CommandType.StoredProcedure);
            conexion.Close();
        }

        public void ActualizarHabitacion(int codigo, String numeroHabitacion, Decimal tarifa, int id)
        {
            string consulta = "sp_ActualizarHabitacion";
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@idHabitacion", codigo, DbType.Int32);
            parametros.Add("@numeroHabitacion", numeroHabitacion, DbType.String);
            parametros.Add("@tarifa", tarifa, DbType.Decimal);
            parametros.Add("@idTipoHabitacion_FK", id, DbType.Int32);
            conexion.Open();
            conexion.Execute(consulta, parametros, commandType: CommandType.StoredProcedure);
            conexion.Close();
        }

        public void EliminarHabitacion(int id)
        {
            try
            {
                string consulta = "sp_EliminarHabitacion";
                DynamicParameters parametros = new DynamicParameters();
                parametros.Add("@id", id, DbType.Int32);
                conexion.Open();
                conexion.Execute(consulta, parametros, commandType: CommandType.StoredProcedure);
                conexion.Close();
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("¡NO SE HA PODIDO ELIMINAR ESTE REGISTRO!\n\n" +
                                "Nota: El id del registro esta siendo referenciado en uno o más\n" +
                                "registros dentro del sistema, si desea eliminarlo debe modificar\n" +
                                " y/o eliminar manualmente cada registro que haga referencia a este.");
                conexion.Close();
            }

        }
    }
}

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
        public List<TipoHabitaciones> ConsultarTipoHabitaciones()
        {
            List<TipoHabitaciones> habitaciones = new List<TipoHabitaciones>();
            string consulta = "sp_TipoHabitacion";
            conexion.Open();
            habitaciones = conexion.Query<TipoHabitaciones>(consulta, commandType: CommandType.StoredProcedure).ToList();
            conexion.Close();
            return habitaciones;
        }
    }
}

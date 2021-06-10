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
    class MManejoReservas
    {
        IDbConnection conexion = Conexion.conectar();

        //MOSTRAR
        public List<spMostrarManejoReservas> ConsultarReservas()
        {
            // Select * from Reservas
            List<spMostrarManejoReservas> reservas = new List<spMostrarManejoReservas>();
            string consulta = "sp_MostrarManejoReservas";
            conexion.Open();
            reservas = conexion.Query<spMostrarManejoReservas>(consulta, commandType: CommandType.StoredProcedure).ToList();
            conexion.Close();
            return reservas;
        }

        //GUARDAR
        public void AgregarReserva(ManejoReservas Reservas)
        {
            string consulta = "sp_InsertarManejoReservas";
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@reserva", Reservas.fechaReserva, DbType.Date);
            parametros.Add("@checkIn", Reservas.fechaCheckIn, DbType.Date);
            parametros.Add("@checkOut", Reservas.fechaCheckOut, DbType.Date);
            parametros.Add("@dias", Reservas.numeroDias, DbType.Int32);
            parametros.Add("@adelantado", Reservas.pagoAdelantado, DbType.Decimal);
            parametros.Add("@descuento", Reservas.descuento, DbType.Decimal);
            parametros.Add("@total", Reservas.total, DbType.Decimal);
            parametros.Add("@idHabitacion", Reservas.idHabitacion_FK, DbType.Int32);
            parametros.Add("@idHuesped", Reservas.idHuesped_FK, DbType.Int32);
            //abrimos la conexion, ejecutamos la consulta y cerramos la conexion
            conexion.Open();
            conexion.Execute(consulta, parametros, commandType: CommandType.StoredProcedure);
            conexion.Close();
        }

        //ELIMINAR
        public void EliminarReserva(ManejoReservas Reservas)
        {
            try
            {
                string consulta = "sp_EliminarManejoReservas";
                DynamicParameters parametros = new DynamicParameters();
                parametros.Add("@id", Reservas.idReserva, DbType.Int32);
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

        //ACTUALIZAR
        public void ActualizarReserva(ManejoReservas Reservas)
        {
            string consulta = "sp_ActualizarManejoReservas";
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@id", Reservas.idReserva, DbType.Int32);
            parametros.Add("@reserva", Reservas.fechaReserva, DbType.Date);
            parametros.Add("@checkIn", Reservas.fechaCheckIn, DbType.Date);
            parametros.Add("@checkOut", Reservas.fechaCheckOut, DbType.Date);
            parametros.Add("@dias", Reservas.numeroDias, DbType.Int32);
            parametros.Add("@adelantado", Reservas.pagoAdelantado, DbType.Decimal);
            parametros.Add("@descuento", Reservas.descuento, DbType.Decimal);
            parametros.Add("@total", Reservas.total, DbType.Decimal);
            parametros.Add("@idHabitacion", Reservas.idHabitacion_FK, DbType.Int32);
            parametros.Add("@idHuesped", Reservas.idHuesped_FK, DbType.Int32);
            conexion.Open();
            conexion.Execute(consulta, parametros, commandType: CommandType.StoredProcedure);
            conexion.Close();
        }
    }
}

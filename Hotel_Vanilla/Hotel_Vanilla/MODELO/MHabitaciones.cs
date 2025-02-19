﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel_Vanilla.ENTIDAD;
using Dapper;
using System.Windows.Forms;
using Hotel_Vanilla.Vista;

namespace Hotel_Vanilla.MODELO
{
    class MHabitaciones
    {
        //Modelo para mostrar las habitaciones con el procedimiento
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

        //Modelo Agregar habitacion con el procedimiento
        public void AgregarHabitacion(Habitaciones habitacion)
        {
            string consulta = "sp_InsertarHabitacion";
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@numeroHabitacion", habitacion.numeroHabitacion, DbType.String);
            parametros.Add("@tarifa", habitacion.tarifa, DbType.Decimal);
            parametros.Add("@idTipoHabitacion_FK", habitacion.idTipoHabitacion_FK, DbType.Int32);
            conexion.Open();
            conexion.Execute(consulta, parametros, commandType: CommandType.StoredProcedure);
            conexion.Close();
        }

        //Modelo para Actualizar habitacion con el procedimiento
        public void ActualizarHabitacion(Habitaciones habitacion)
        {
            string consulta = "sp_ActualizarHabitacion";
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@idHabitacion", habitacion.idHabitacion, DbType.Int32);
            parametros.Add("@numeroHabitacion", habitacion.numeroHabitacion, DbType.String);
            parametros.Add("@tarifa", habitacion.tarifa, DbType.Decimal);
            parametros.Add("@idTipoHabitacion_FK", habitacion.idTipoHabitacion_FK, DbType.Int32);
            conexion.Open();
            conexion.Execute(consulta, parametros, commandType: CommandType.StoredProcedure);
            conexion.Close();
        }

        //Modelo para Eliminar habitacion con el procedimiento
        public void EliminarHabitacion(Habitaciones habitacion)
        {
            try
            {
                string consulta = "sp_EliminarHabitacion";
                DynamicParameters parametros = new DynamicParameters();
                parametros.Add("@id", habitacion.idHabitacion, DbType.Int32);
                conexion.Open();
                conexion.Execute(consulta, parametros, commandType: CommandType.StoredProcedure);
                conexion.Close();
            }
            catch (System.Data.SqlClient.SqlException)
            {
                frmMensajeAviso.Avisar("El id del registro esta siendo referenciado en uno o más\n" +
                                "registros dentro del sistema, si desea eliminarlo debe modificar\n" +
                                " y/o eliminar manualmente cada registro que haga referencia a este.");
                conexion.Close();
            }
        }

        //Modelo para la busqueda de habitaciones
        public List<spBuscarHabitacion> BuscarHabitaciones(string buscador)
        {
            List<spBuscarHabitacion> Habitaciones = new List<spBuscarHabitacion>();
            string consulta = "sp_BuscarHabitacion";
            DynamicParameters parametro = new DynamicParameters();
            parametro.Add("@buscador", buscador);
            conexion.Open();
            Habitaciones = conexion.Query<spBuscarHabitacion>(consulta, parametro, commandType: CommandType.StoredProcedure).ToList();
            conexion.Close();
            return Habitaciones;
        }

        //Consulta para mostrar el total de Habitaciones
        public int TotalHabitaciones()
        {
            int habitaciones;
            string consulta = "sp_TotalHabitaciones";
            conexion.Open();
            habitaciones = conexion.QuerySingle<int>(consulta, commandType: CommandType.StoredProcedure);
            conexion.Close();
            return habitaciones;
        }
    }
}

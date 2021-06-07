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
        IDbConnection cn = Conexion.conectar();
        public List<Huespedes> ConsultarHuespedes()
        {
            List<Huespedes> Huespedes = new List<Huespedes>();
            string consulta = "sp_Mostrarhuesped";
            cn.Open();
            Huespedes = cn.Query<Huespedes>(consulta, commandType: CommandType.StoredProcedure).ToList();
            cn.Close();
            return Huespedes;
        }

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
            //abrimos la conexion, ejecutamos la consulta y cerramos la conexion
            cn.Open();
            cn.Execute(consulta, parametros, commandType: CommandType.StoredProcedure);
            cn.Close();
        }
        public void EliminarHuesped(Huespedes huesped)
        {
            string consulta = "sp_eliminarhuesped";
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@id", huesped.idHuesped, DbType.Int32);
            cn.Open();
            cn.Execute(consulta, parametros, commandType: CommandType.StoredProcedure);
            cn.Close();
        }
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
            cn.Open();
            cn.Execute(consulta, parametros, commandType: CommandType.StoredProcedure);
            cn.Close();
        }
    }
}

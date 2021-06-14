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
    class MSucesos
    {
        IDbConnection cn = Conexion.conectar();

        public List<Sucesos> ConsultarSucesos()
        {
            List<Sucesos> Sucesos = new List<Sucesos>();
            string consulta = "sp_TodosSucesos";
            cn.Open();
            Sucesos = cn.Query<Sucesos>(consulta, commandType: CommandType.StoredProcedure).ToList();
            cn.Close();
            return Sucesos;
        }

        public List<Sucesos> ConsultarUltimosSucesos()
        {
            List<Sucesos> Sucesos = new List<Sucesos>();
            string consulta = "sp_UltimoSucesos";
            cn.Open();
            Sucesos = cn.Query<Sucesos>(consulta, commandType: CommandType.StoredProcedure).ToList();
            cn.Close();
            return Sucesos;
        }

        //Modelo para la busqueda de sucesos
        public List<spBuscarSuceso> BuscarSucesos(string buscador)
        {
            List<spBuscarSuceso> Sucesos = new List<spBuscarSuceso>();
            string consulta = "sp_BuscarSucesos";
            DynamicParameters parametro = new DynamicParameters();
            parametro.Add("@buscador", buscador);
            cn.Open();
            Sucesos = cn.Query<spBuscarSuceso>(consulta, parametro, commandType: CommandType.StoredProcedure).ToList();
            cn.Close();
            return Sucesos;
        }

        //Consulta para mostrar el ultimo Suceso
        public List<Sucesos> UltimoSuceso()
        {
            List<Sucesos> Sucesos = new List<Sucesos>();
            string consulta = "sp_UltimoSucesos";
            cn.Open();
            Sucesos = cn.Query<Sucesos>(consulta, commandType: CommandType.StoredProcedure).ToList();
            cn.Close();
            return Sucesos;
        }
    }
}

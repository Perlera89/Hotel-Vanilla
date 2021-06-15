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
        public List<Estados> MostrarEstados()
        {
            IDbConnection conexion = Conexion.conectar();
            List<Estados> estados = new List<Estados>();
            string consulta = "select * from Estados";
            conexion.Open();
            estados = conexion.Query<Estados>(consulta, commandType: CommandType.Text).ToList();
            conexion.Close();
            return estados;
        }
    }
}

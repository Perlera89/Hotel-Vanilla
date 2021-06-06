﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Vanilla
{
    class Conexion
    {
        public static IDbConnection conectar()
        {
            IDbConnection connection;
            var cadena = ConfigurationManager.ConnectionStrings["Hotel_Vanilla.Properties.Settings.VanillaBDConnectionString"].ConnectionString;
            connection = new SqlConnection(cadena);
            return connection;
        }
    }
}

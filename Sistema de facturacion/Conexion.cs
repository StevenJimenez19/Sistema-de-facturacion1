using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_facturacion
{
    
    class Conexion
    {
        //conexion
        public static SqlConnection Conectar ()
        {
            SqlConnection cn = new SqlConnection("SERVER=DESKTOP-PHTCG9K\\SQLEXPRESS;DATABASE=Facturacion;Integrated security= true");

            cn.Open();

            return cn;
        }
    }
}

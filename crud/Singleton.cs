using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace crud
{
    public class Singleton
    {
         private static SqlConnection co;
         private Singleton()
         {
        
         }
         public SqlConnection conex()
         {
            if (co == null)
            {
                co = new SqlConnection(Properties.Settings.Default.Conexion);
            }
            return co;
         }


    }
}
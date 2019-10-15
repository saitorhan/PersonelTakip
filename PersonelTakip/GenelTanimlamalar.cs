using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelTakip
{
    static class GenelTanimlamalar
    {
        public static string BaglantiCumlesi =>
            ConfigurationManager.ConnectionStrings["BaglantiCumlesi"].ConnectionString;

        public static SqlConnection SqlBaglanti => new SqlConnection(BaglantiCumlesi);
    }
}

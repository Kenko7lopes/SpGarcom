using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SpG.model
{
    public class Conexao
    {
                // string para conexao em desuso
        //public static string ConnectionString => ConfigurationManager.ConnectionStrings["Conexao"].ConnectionString;

        public static string conString = //"Provider=Microsoft.Jet.OLEDB.4.0;" +
                                         "Data Source=.;" +
                                         "Database=SpGarcom;"+
                                         //"AttachDbFilename=|DataDirectory|\\data\\SpGarçom.mdf;" +
                                         "Trusted_Connection=Yes;";
        //"Initial Catalog=SpGarcom;" +
        //"User Instance=true;" +
        //"Trusted_Connection = Yes;";


        public static SqlConnection db = new SqlConnection(conString);

    }
}
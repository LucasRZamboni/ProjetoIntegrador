using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjetoIntegrador
{
    internal class Conexao
    {

        public static SqlConnection con = new SqlConnection();
        //public static string consulta = "SELECT CPF, Nome FROM Table1 WHERE CPF = @CPF OR Nome = @Nome";

        public static void Conectar()
        {
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\LUCAS\Desktop\ProjetoIntegrador-main\ProjetoIntegrador\SignUp.mdf;Integrated Security=True;Connect Timeout=30";

            con.Open();


        }

    }
}

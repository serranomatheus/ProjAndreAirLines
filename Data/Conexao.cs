using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using File;

namespace Data
{
    public class Conexao
    {
        //manipular inf banco de dados 
        //incluir e consulta insert e select 
        #region ConexaoBanco
        private static string datasource = @"DESKTOP-TCJTUCH";//instancia do servidor
        private static string database = "AndreAirLines"; //Base de Dados
        private static string username = "sa"; //usuario da conexão
        private static string password = "170495";

        static string connString = @"Data Source=" + datasource + ";Initial Catalog="
                     + database + ";Persist Security Info=True;User ID=" + username + ";Password=" + password;

        
        #endregion

        public static void InserirPassageiro(Passageiro passageiro)
        {
            SqlConnection connection = new SqlConnection(connString);
            try
            {
                using (connection)
                {
                    connection.Open();
                    SqlCommand sql_cmnd = new SqlCommand("InserirPassageiro", connection);
                    sql_cmnd.CommandType = CommandType.StoredProcedure;

                    sql_cmnd.Parameters.AddWithValue("@Cpf", SqlDbType.NVarChar).Value = passageiro.Cpf;
                    sql_cmnd.Parameters.AddWithValue("@Nome", SqlDbType.NVarChar).Value = passageiro.Nome;
                    sql_cmnd.Parameters.AddWithValue("@Telefone", SqlDbType.NVarChar).Value = passageiro.Telefone;
                    sql_cmnd.Parameters.AddWithValue("@DataNascimento",passageiro.DataNascimento);
                    sql_cmnd.Parameters.AddWithValue("@Email", SqlDbType.NVarChar).Value = passageiro.Email;
                    sql_cmnd.Parameters.AddWithValue("@Endereco", SqlDbType.Int).Value = passageiro.Endereco;

                    sql_cmnd.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }

        public static void InserirAeronave(Aeronave aeronave)
        {
            SqlConnection connection = new SqlConnection(connString);
            try
            {
                using (connection)
                {
                    connection.Open();
                    SqlCommand sql_cmnd = new SqlCommand("InserirAeronave", connection);
                    sql_cmnd.CommandType = CommandType.StoredProcedure;

                    sql_cmnd.Parameters.AddWithValue("@Id", SqlDbType.NVarChar).Value = aeronave.Id;
                    sql_cmnd.Parameters.AddWithValue("@Nome", SqlDbType.NVarChar).Value = aeronave.Nome;
                    sql_cmnd.Parameters.AddWithValue("@Capacidade", SqlDbType.Int).Value = aeronave.Capacidade;
                   

                    sql_cmnd.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        public static void InserirPassageiroBanco()
        {
            string pathFile = @"C:\Users\matheus\source\repos\ProjAndreAirLines\arqJson\passageiro.json";

            var lst = LerArquivo.getDataPassageiro(pathFile);

            if (lst != null)
            {
                var dataQuery =
                (from data in lst
                 where data != null
                 select data);



                foreach (var data in dataQuery)
                {
                    Conexao.InserirPassageiro(data);
                }
            }
        }

        public static void InserirAeronaveBanco()
        {
            string pathFile = @"C:\Users\matheus\source\repos\ProjAndreAirLines\arqJson\aeronave.json";

            var lst = LerArquivo.getDataAeronave(pathFile);

            if (lst != null)
            {
                var dataQuery =
                (from data in lst
                 where data != null
                 select data);



                foreach (var data in dataQuery)
                {
                    Conexao.InserirAeronave(data);
                }
            }
        }


    }
}

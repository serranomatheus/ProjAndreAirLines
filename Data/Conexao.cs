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

        public static void InserirPassageiro(Model.Passageiro passageiro)
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
                    sql_cmnd.Parameters.AddWithValue("@DataNascimento", passageiro.DataNascimento);
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

        public static void InserirAeronave(Model.Aeronave aeronave)
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
        public static void InserirAeroporto(Model.Aeroporto aeroporto)
        {
            SqlConnection connection = new SqlConnection(connString);
            try
            {
                using (connection)
                {
                    connection.Open();
                    SqlCommand sql_cmnd = new SqlCommand("InserirAeroporto", connection);
                    sql_cmnd.CommandType = CommandType.StoredProcedure;

                    sql_cmnd.Parameters.AddWithValue("@Sigla", SqlDbType.NVarChar).Value = aeroporto.Sigla;
                    sql_cmnd.Parameters.AddWithValue("@Nome", SqlDbType.NVarChar).Value = aeroporto.Nome;
                    sql_cmnd.Parameters.AddWithValue("@Endereco", SqlDbType.Int).Value = aeroporto.Endereco;


                    sql_cmnd.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        public static void InserirVoo(Model.Voo voo)
        {
            SqlConnection connection = new SqlConnection(connString);
            try
            {
                using (connection)
                {
                    connection.Open();
                    SqlCommand sql_cmnd = new SqlCommand("InserirVoo", connection);
                    sql_cmnd.CommandType = CommandType.StoredProcedure;

                    sql_cmnd.Parameters.AddWithValue("@Destino", SqlDbType.NVarChar).Value = voo.Destino;
                    sql_cmnd.Parameters.AddWithValue("@Origem", SqlDbType.NVarChar).Value = voo.Origem;
                    sql_cmnd.Parameters.AddWithValue("@Aeronave", SqlDbType.NVarChar).Value = voo.Aeronave;
                    sql_cmnd.Parameters.AddWithValue("@HorarioEmbarque",SqlDbType.DateTime).Value = voo.HorarioEmbarque;
                    sql_cmnd.Parameters.AddWithValue("@HorarioDesembarque", SqlDbType.DateTime).Value = voo.HorarioDesembarque;

                    sql_cmnd.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        public static void InserirPassageiroVoo()
        {
            string pathFile = @"C:\Users\matheus\source\repos\ProjAndreAirLines\arqJson\voo.json";

            var lst = LerArquivo.getDataVoo(pathFile);

            if (lst != null)
            {
                var dataQuery =
                (from data in lst
                 where data != null
                 select data);



                foreach (var data in dataQuery)
                {
                    Conexao.InserirVoo(data);
                }
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

        public static void InserirAeroportoBanco()
        {
            string pathFile = @"C:\Users\matheus\source\repos\ProjAndreAirLines\arqJson\aeroporto.json";
            var lst = LerArquivo.getDataAeroporto(pathFile);
            if (lst != null)
            {
                var dataQuery =
                (from data in lst
                 where data != null
                 select data);



                foreach (var data in dataQuery)
                {
                    Conexao.InserirAeroporto(data);
                }
            }
        }

    }
}

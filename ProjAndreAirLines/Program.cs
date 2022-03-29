using System;
using Data;
using File;

namespace AndreAirLines
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Conexao.InserirPassageiroBanco(); Inserir passageiros no banco de dados
            //Conexao.InserirAeronaveBanco(); Inserir aeronaves no banco de dados
            // Conexao.InserirAeroportoBanco();
            Conexao.InserirPassageiroVoo();

        }
    }
}

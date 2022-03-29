using System;
using System.Collections.Generic;
using Data;
using File;
using Model;

namespace AndreAirLines
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Conexao.InserirPassageiroBanco(); Inserir passageiros no banco de dados
            //Conexao.InserirAeronaveBanco(); Inserir aeronaves no banco de dados
            // Conexao.InserirAeroportoBanco();
            // Conexao.InserirPassageiroVoo();

            //List<Passageiro> lstPassageiro = new List<Passageiro>(Conexao.BuscarPassageiro()); Le todos passageiros no banco de dados e salva em uma lista os cpfs
           // List<Voo> lstVoo = new List<Voo>(Conexao.BuscarVoo()); Le todos voos no banco de dados e salva em uma lista o Id dos voos        

           // Conexao.InserirPassagem(lstPassageiro, lstVoo); Insere passagens com as listas de cpf(passageiro) e id(voo) de parametros
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

using System.Data;



namespace File
{
    public class LerArquivo
    {

        //gerenciar arquivo
        public static List<Passageiro>? getDataPassageiro(string pathFile)
        {
            StreamReader r = new StreamReader(pathFile);
            string jsonString = r.ReadToEnd();
            var lst = JsonConvert.DeserializeObject<List<Passageiro>>(jsonString) as List<Passageiro>;
            if (lst != null)
                return lst;
            return null;

        }

        public static List<Aeronave>? getDataAeronave(string pathFile)
        {
            StreamReader r = new StreamReader(pathFile);
            string jsonString = r.ReadToEnd();
            var lst = JsonConvert.DeserializeObject<List<Aeronave>>(jsonString) as List<Aeronave>;
            if (lst != null)
                return lst;
            return null;


        }

        public static List<Model.Aeroporto>? getDataAeroporto(string pathFile)
        {
            StreamReader r = new StreamReader(pathFile);
            string jsonString = r.ReadToEnd();
            var lst = JsonConvert.DeserializeObject<List<Model.Aeroporto>>(jsonString) as List<Model.Aeroporto>;
            if (lst != null)
                return lst;
            return null;
        }
    }



}


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
        public static List<Model.Passageiro>? getDataPassageiro(string pathFile)
        {
            StreamReader r = new StreamReader(pathFile);
            string jsonString = r.ReadToEnd();
            var lst = JsonConvert.DeserializeObject<List<Model.Passageiro>>(jsonString) as List<Model.Passageiro>;
            if (lst != null)
                return lst;
            return null;

        }

        public static List<Model.Aeronave>? getDataAeronave(string pathFile)
        {
            StreamReader r = new StreamReader(pathFile);
            string jsonString = r.ReadToEnd();
            var lst = JsonConvert.DeserializeObject<List<Model.Aeronave>>(jsonString) as List<Model.Aeronave>;
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
        public static List<Model.Voo>? getDataVoo(string pathFile)
        {
            StreamReader r = new StreamReader(pathFile);
            string jsonString = r.ReadToEnd();
            var lst = JsonConvert.DeserializeObject<List<Model.Voo>>(jsonString) as List<Model.Voo>;
            if (lst != null)
                return lst;
            return null;
        }
    }



}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace File
{

    public class Passageiro
    {
        

        [JsonProperty("cpf")]
        public Int64? Cpf { get; set; }

        [JsonProperty("nome")]
        public string? Nome { get; set; }

        [JsonProperty("telefone")]
        public string? Telefone { get; set; }

        [JsonProperty("dataNascimento")]
        public DateTime? DataNascimento { get; set; }

        [JsonProperty("email")]
        public string? Email { get; set; }

        [JsonProperty("endereco")]
        public int Endereco { get; set; }

        public override string ToString()
        {
            return "Nome: "+Nome+" Cpf: "+Cpf;
        }


    }
}

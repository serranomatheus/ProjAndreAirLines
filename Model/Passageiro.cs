using System;
using Newtonsoft.Json;

namespace Model
{
    public class Passageiro
    {
        #region Propriedades
        [JsonProperty("cpf")]
        public string? Cpf { get; set; }

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

        public Passageiro(string cpf)
        {
            Cpf = cpf;
        }

        

        public override string ToString()
        {
            return "Nome: " + Nome + " Cpf: " + Cpf;
        }

        #endregion
    }
}

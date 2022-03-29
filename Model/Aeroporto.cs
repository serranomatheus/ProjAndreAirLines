using Newtonsoft.Json;

namespace Model
{
    public class Aeroporto
    {
        #region Propriedades
        [JsonProperty("sigla")]
        public string Sigla { get; set; }
        [JsonProperty("Nome")]
        public string Nome { get; set; }
        [JsonProperty("endereco")]
        public int Endereco { get; set; }
        #endregion
    }
}
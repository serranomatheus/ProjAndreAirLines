using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Model
{
    public class Aeronave
    {
        #region Propriedades
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("nome")]
        public string Nome { get; set; }

        [JsonProperty("capacidade")]
        public int Capacidade { get; set; }
        #endregion
    }
}

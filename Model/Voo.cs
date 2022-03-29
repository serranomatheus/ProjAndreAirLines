using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Model
{
    public class Voo
    {
        #region Propriedades
        public int Id { get; set; }
        [JsonProperty("destino")]
        public string Destino { get; set; }
        [JsonProperty("origem")]
        public string Origem { get; set; }
        [JsonProperty("aeronave")]
        public string Aeronave { get; set; }
        [JsonProperty("horarioembarque")]
        public DateTime HorarioEmbarque { get; set; }
        [JsonProperty("horariodesembarque")]
        public DateTime HorarioDesembarque { get; set; }
        #endregion 
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    internal class Voo
    {
        #region Propriedades
        public int Id { get; set; }
        public Aeroporto Destino { get; set; }
        public Aeroporto Origem { get; set; }
        public DateTime HorarioEmbarque { get; set; }
        public DateTime HorarioDesembarque { get; set; }
        #endregion 
    }
}

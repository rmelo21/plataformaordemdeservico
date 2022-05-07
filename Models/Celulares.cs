using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace plataformaordemdeservico.Models
{
    public class Celulares
    {
        public int cod_cel { get; set; }
        public string modelo_cel { get; set; }
        public string fabricante { get; set; }
        public string carregador_cel { get; set; }
        public string descricao_cel { get; set; }
        public string anexo_cel { get; set; }
        public int status { get; set; }
        public DateTime data_aber { get; set; }
        public DateTime hora_abert { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace plataformaordemdeservico.Models
{
    public class Computadores
    {
        public int cod_comp { get; set; }
        public string processador { get; set; }
        public string fabricante { get; set; }
        public string descricao_comp { get; set; }
        public string anexo_comp { get; set; }
        public int status { get; set; }
        public DateTime data { get; set; }
        public DateTime hora { get; set; }
    }
}

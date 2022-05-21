using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace plataformaordemdeservico.Entidades
{
    public class MonitoresDb
    {
        public int Id { get; set; }
        public int cod_mon { get; set; }
        public string modelo_mon { get; set; }
        public string fabricante { get; set; }
        public string polegadas { get; set; }
        public string descricao_mon { get; set; }
        public string anexo_mon { get; set; }
        public int status { get; set; }
        public DateTime data { get; set; }
        public int protocolo { get; set; }
    }
}

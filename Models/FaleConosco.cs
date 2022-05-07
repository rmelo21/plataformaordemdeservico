using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace plataformaordemdeservico.Models
{
    public class FaleConosco
    {
        public int cod_falcon { get; set; }
        public string tipo_registro { get; set; }
        public string descricao_falcon { get; set; }
        public string anexo_falcon { get; set; }
        public int status { get; set; }
        public DateTime data { get; set; }
        public DateTime hora { get; set; }
    }
}

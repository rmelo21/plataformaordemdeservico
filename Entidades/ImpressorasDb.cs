using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace plataformaordemdeservico.Entidades
{
    public class ImpressorasDb
    {
        public int Id { get; set; }
        public int cod_imp { get; set; }
        public string modelo_imp { get; set; }
        public string serie_imp { get; set; }
        public string fabricante { get; set; }
        public string carregador_cel { get; set; }
        public string descricao_imp { get; set; }
        public string anexo_imp { get; set; }
        public int status { get; set; }
        public DateTime data { get; set; }
  
    }
}

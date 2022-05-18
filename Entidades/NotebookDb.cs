using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace plataformaordemdeservico.Entidades
{
    public class NotebookDb
    {
        public int Id { get; set; }
        public int cod_note { get; set; }
        public string modelo_note { get; set; }
        public string fabricante { get; set; }
        public string serie_note { get; set; }
        public string polegadas { get; set; }
        //se carregador original
        public string carregador { get; set; }
        public string descricao_note { get; set; }
        public string anexo_note { get; set; }
        public int status { get; set; }
        public DateTime data { get; set; }
    }
}

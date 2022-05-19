using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace plataformaordemdeservico.Entidades
{
    public class CadastroDb
    {
       
        public int Id { get; set; }
        public int cod_cad { get; set; }
        public string nome { get; set; }
        public string sobrenome { get; set; }
        public string email { get; set; }
        public string usuario { get; set; }
        public string senha { get; set; }
        public string logradouro { get; set; }
        public string num_logradouro { get; set; }
        public string estado { get; set; }
        public string cidade { get; set; }
        public string tel_empresa { get; set; }
        public string celular { get; set; }
        public string whats { get; set; }

        public int protocolo { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using plataformaordemdeservico.Entidades;


namespace plataformaordemdeservico
{
    public class Contexto : DbContext
    {
        //DS = Client Data Set

        public Contexto(DbContextOptions<Contexto> options) : base(options) { }

        public DbSet<CadastroDb> DSCadastroCliente { get; set; }

        public DbSet<CelularesDb> DSCelulares { get; set; }

        public DbSet<ComputadoresDb> DSComputadores { get; set; }

        public DbSet<FaleConoscoDb> DSFaleConosco { get; set; }

        public DbSet<ImpressorasDb> DSImpressoras { get; set; }

        public DbSet<MonitoresDb> DSMonitores { get; set; }

        public DbSet<NotebookDb> DSNotebook { get; set; }
    }
}

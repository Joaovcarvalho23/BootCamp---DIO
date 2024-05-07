using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ModuloApi.Entities;

namespace ModuloApi.Contexts
{
    public class AgendaContext : DbContext 
    {
        //                     aqui recebemos a conexão/conf. do banco          e passamos para a nossa base(DbContext) que gerencia a conexão com o banco de dados
        public AgendaContext (DbContextOptions<AgendaContext> options) : base(options) //passamos para o construtor da classe que estamos herdando. Nesse caso, o DbContext
        {

        }

        public DbSet<Contato> MeusContatos{  get; set; } //aqui vai representar uma tabela
    }
}
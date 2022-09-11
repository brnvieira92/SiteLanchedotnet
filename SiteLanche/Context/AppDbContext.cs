using Microsoft.EntityFrameworkCore;
using SiteLanche.Models;

namespace SiteLanche.Context
{//classe de contexto
    //AppDbContext herda (:) de DbContext
    public class AppDbContext : DbContext
    {
        //Abaixo é um construtor que esta referenciado pelo DbContext
        //essa DbContextOptions ela define as opções a serem usadas pela DbContext
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { 
            
        }

        //abaixo vamos definir as propriedades DbSet, que diz quais classes eu quero mapear para minha tabela. que é como uma tabela do banco de dados
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet <Lanche> Lanches { get; set; }
    }
}

using SiteLanche.Context;
using SiteLanche.Models;
using SiteLanche.Repositories.Interfaces;

namespace SiteLanche.Repositories
{
    //essa é uma classe concreta que implementa metodos para a interface
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;
        //abaixo estou injetando uma instancia do contexto no construtor do repositorio pra acessar os dados
        public CategoriaRepository(AppDbContext context)
        {
            _context = context;
        }
        //abaixo estou injetando uma propriedade de Categoria que retorna uma lista de categoria utilizando o _context
        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}

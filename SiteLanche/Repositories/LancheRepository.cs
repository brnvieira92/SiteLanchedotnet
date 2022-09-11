using Microsoft.EntityFrameworkCore;
using SiteLanche.Context;
using SiteLanche.Models;
using SiteLanche.Repositories.Interfaces;

namespace SiteLanche.Repositories
{
    public class LancheRepository : ILancheRepository
    {
        //para retornar uma lista de lanches eu tenho que usar uma instancia do contexto
        //por isso vou injetar uma intancia do classe AppDbContext
        private readonly AppDbContext _context;
        //essa private readonly é uma variavel apenas do tipo leitura e vai visivel somente dessa classe

        public LancheRepository(AppDbContext contexto)
        {
            //construtor
            _context = contexto;
        }

        //abaixo são as assinaturas(contrato da interface) e seus metodos
        //public IEnumerable<Lanche> Lanches => _context.Lanches.Include significa
        //que quero uma lista lanche e sua categoria.
        public IEnumerable<Lanche> Lanches => _context.Lanches.Include(c => c.Categoria);

        public IEnumerable<Lanche> LanchesPreferidos => _context.Lanches.Where(l => l.IsLanchePreferido)
                                                                        .Include(c => c.Categoria);

        public Lanche GetLancheById(int LancheId)
        {
            return _context.Lanches.FirstOrDefault(l => l.LancheId == LancheId);
        }
    }
}

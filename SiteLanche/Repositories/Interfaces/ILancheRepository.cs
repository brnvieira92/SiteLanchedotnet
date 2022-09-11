using SiteLanche.Models;

namespace SiteLanche.Repositories.Interfaces
{
    public interface ILancheRepository
    {
        //abaixo vou retornar todos os lanches numa lista de lanches
        IEnumerable<Lanche> Lanches { get; }
        IEnumerable<Lanche> LanchesPreferidos { get; }
        Lanche GetLancheById(int LancheId);

    }
}

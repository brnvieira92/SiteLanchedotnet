using SiteLanche.Models;

namespace SiteLanche.Repositories.Interfaces
{
    public interface ICategoriaRepository
    {
        //abaixo defino uma propriedade de somente leitura que retorna uma lista de obj categoria
        //IEnumerable - expoe um enumerador que dá suporte a uma interação simples em
        //uma coleção não genérica.
        IEnumerable<Categoria> Categorias { get; }
    }
}

using Microsoft.AspNetCore.Mvc;
using SiteLanche.Repositories.Interfaces;
using SiteLanche.ViewModels;

namespace SiteLanche.Controllers
{
    public class LancheController : Controller
    {
        //vou injetar uma instancia do repositorio para depois listar List()
        private readonly ILancheRepository _lancheRepository;

        public LancheController(ILancheRepository lancheRepository)
        {
            _lancheRepository = lancheRepository;
        }

        public IActionResult List()
        {
            /*ViewData["Titulo"] = "Todos os Lanches";
            ViewData["Data"] = DateTime.Now;
            //agora usando a instancia _lancheRepository, consigo acessar a minha lista de lanches
            //retornado do banco de dados.
            var lanches = _lancheRepository.Lanches;
            var totalLanches = lanches.Count();
            ViewBag.Total = "Total de Lanches:";
            ViewBag.TotalLanches = totalLanches;*/
            //conceito de viewModel
            var lanchesListViewModel = new LancheListViewModel();
            lanchesListViewModel.Lanches = _lancheRepository.Lanches;
            lanchesListViewModel.CategoriaAtual = "Categoria Atual";
            return View(lanchesListViewModel);
        }
    }
}

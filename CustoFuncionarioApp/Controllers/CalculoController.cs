using CustoFuncionarioApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging.Abstractions;
using System.Drawing;

namespace CustoFuncionarioApp.Controllers
{
    public class CalculoController : Controller
    {
        private NullLogger<CalculoController> nullLogger;

        public CalculoController()
        {
        }

        public CalculoController(NullLogger<CalculoController> nullLogger)
        {
            this.nullLogger = nullLogger;
        }

        public IActionResult Relatorio(Custo custo)
        {
            return View(custo);
        }

        public async Task Relatorio(float valor)
        {
            throw new NotImplementedException();
        }
    }
}

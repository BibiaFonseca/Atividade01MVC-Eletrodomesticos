using Atividade_01.Models;
using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Atividade_01.Controllers
{
    public class EletrodomesticoController : Controller
    {
        public IActionResult Index()
        {
            List<Eletrodomestico> eletrodomesticos = new List<Eletrodomestico>
            {
                new Geladeira {Marca = "Eletrolux", Modelo = "Frost Free Multidoor", ConsumoEnergetico = 55.4, CapacidadeLitros = 590, TemFreezer = true},
                new Televisor {Marca = "Samsung", Modelo = "65Q60DA", ConsumoEnergetico = 175, TamanhoTela = 65, EhSmart = true},
                new Geladeira {Marca = "Brastemp", Modelo = "French Door 3 Portas", ConsumoEnergetico = 56.6, CapacidadeLitros = 554, TemFreezer = true},
            };

            return View(eletrodomesticos);
        }
    }
}

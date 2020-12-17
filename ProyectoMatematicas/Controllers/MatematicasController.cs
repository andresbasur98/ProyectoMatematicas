using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProyectoMatematicas.Models;

namespace ProyectoMatematicas.Controllers
{
    public class MatematicasController : Controller
    {
        public IActionResult TablaMultiplicar()
        {
            ViewData["NUMERO"] = 0;
            return View();
        }

        [HttpPost]
        public IActionResult TablaMultiplicar(int numero)
        {
            ViewData["NUMERO"] = numero;
            List<int> resultados = new List<int>();
            for (int i = 0; i <= 10; i++)
            {
                int resultado = i * numero;
                resultados.Add(resultado);
            }

            return View(resultados);
        }

        public IActionResult SumarNumeros()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SumarNumeros(int numero1 , int numero2)
        {
            ViewData["NUMERO1"] = numero1;
            ViewData["NUMERO2"] = numero2;

            ViewData["RESLT"] = numero1 + numero2;
            return View();
        }

        public IActionResult Collazt(int? numero)
        {
            // estamos recibiendo el parametro
            if( numero != null)
            {
                List<int> collazt = new List<int>();
                while( numero != 1)
                {
                    if( numero % 2 == 0)
                    {
                        numero = numero / 2;
                    }
                    else
                    {
                        numero = numero * 3 + 1;
                    }
                    collazt.Add(numero.Value);
                }
                ViewData["COLLATZ"] = collazt;
            }

            ViewData["NUMERO"] = numero;

            List<int> aleatorios = new List<int>();
            Random random = new Random();
            for (int i = 1; i <= 10; i++)
            {
                int aleat = random.Next(1, 100);
                aleatorios.Add(aleat);
            }
            return View(aleatorios);
        }
        public IActionResult Index()
        {
            
            return View();
        }
    }
}
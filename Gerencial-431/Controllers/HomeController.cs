using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Gerencial_431.Models;
using AppGerencial.Application.Interface;
using AppGerencial.Application.ViewModels;

namespace Gerencial_431.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ITipoAppService _tipoAppService;

        public HomeController(ILogger<HomeController> logger ,  ITipoAppService tiposervice )
        {
            _tipoAppService = tiposervice; 
                  _logger = logger;
        }

        public IActionResult Index()
        {
            var r = _tipoAppService.SelectAll() ;
            return View(r);

        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Lab21_22.Models;
using Lab21_22.Services;

namespace Lab21_22.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRegistrationFacade _registrationFacade;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, IRegistrationFacade registrationFacade)
        {
            _registrationFacade = registrationFacade;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Registration()
        {
            var model = new RegistrationViewModel();
            return View(model);
        }

        public IActionResult RegistrationDetails(RegistrationViewModel model)
        {
            if (!ModelState.IsValid)
            {
                model.ErrorMessage = "Please Correct All Errors and Resubmit The Form";
                return View("Registration", model);
            }
            var registrationDetails = _registrationFacade.Map(model);
            return View(registrationDetails);
        }

        public IActionResult Userinformation(RegistrationViewModel model)
        {
            var userInputs = _registrationFacade.Map(model);
            return View(userInputs);
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

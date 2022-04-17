using FirstMVCApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstMVCApp.Controllers
{
    public class HelloWorldController : Controller
    {
        private static List<DogViewModel> dogs = new List<DogViewModel>();
        public IActionResult Index()
        {
            
            return View(dogs);
        }

        public IActionResult Create()
        {
            var dogVm = new DogViewModel();
            return View(dogVm);
        }

        public IActionResult CreateDog(DogViewModel dogViewModel)
        {
            //return View("Index");
            dogs.Add(dogViewModel);
            return RedirectToAction("Index", nameof(Index));
        }

        public IActionResult Hello()
        {
            DogViewModel doggo = new DogViewModel() { Name = "Sif", Age = 2 };
            return View(doggo);
        }
    }
}

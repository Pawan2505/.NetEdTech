using Microsoft.AspNetCore.Mvc;
using MVCArchitecure.Models;
using MVCArchitecure.Repository;
using MVCArchitecure.ViewModels;

namespace MVCArchitecure.Controllers
{
    public class TutorialController : Controller
    {

        private readonly ITutorialRepository _tourRepository;

        public TutorialController(ITutorialRepository tutorialRepository)
        {
            _tourRepository = tutorialRepository;
        }

        public IActionResult Index()
        {

            //var tutorials = new List<Tutorial>
            // {
            //     new Tutorial{Id=1,Name="C#",Description="C# tutorial"},
            //     new Tutorial{Id=2, Name="Asp.net Core", Description="Asp.net Core MVC tutorial"}
            // };

            //var tutorials = new TutorialRepository().GetAllTutorial();

            var tutorials = _tourRepository.GetAllTutorial();
            return View(tutorials);

        }

        [HttpGet]
        public IActionResult CreateTutorial()
        {
           return View();

        }
        [HttpPost]
        public IActionResult CreateTutorial(Tutorial tutorial)
        {
            Tutorial newtutorial = _tourRepository.Add(tutorial);
            return RedirectToAction("Index");

        }

        [HttpGet]

        public IActionResult EditTutorial(int id)
        {
            Tutorial tutorial = _tourRepository.GetTutorial(id);
            return View(tutorial);
        }

        [HttpPost]

        public IActionResult EditTutorial(Tutorial modifiedData)
        {
            Tutorial tutorial = _tourRepository.GetTutorial(modifiedData.Id);
            tutorial.Name = modifiedData.Name;
            tutorial.Description = modifiedData.Description;
            Tutorial updatedTutorial = _tourRepository.Update(tutorial);
            return RedirectToAction("Index");
        }


        public IActionResult DeleteTutorial(int id)
        {
            Tutorial deletedTutorial = _tourRepository.Delete(id);
            return RedirectToAction("Index");
        }
    }
}

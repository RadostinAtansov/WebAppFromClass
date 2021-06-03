namespace WebApplication5.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using System.Linq;
    using WebApplicationThatIUseForEveryLecture.Controllers.Data;
    using WebApplicationThatIUseForEveryLecture.Models;

    public class DogsController : Controller
    {

        private readonly DbContext data;
        public DogsController()
        => this.data = new DbContext();
        

        // /Dogs/List
        public IActionResult List()
        {

            var dogs = this.data
                .AllDogs()
                .Select(c => new DogViewModel
            {
                Name = c.Name,
                Age = c.Age,
                Owner = c.Owner.Name
            })
                .ToList();

            if (!dogs.Any())
            {
                return NotFound();
            }

            return View(dogs);
        }

        // /Dogs/Sound
        public IActionResult Sound()
        {
            return View();
        }

    }
}

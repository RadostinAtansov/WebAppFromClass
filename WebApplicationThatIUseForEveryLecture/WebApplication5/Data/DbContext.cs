using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationThatIUseForEveryLecture.Controllers.Data
{
    public class DbContext
    {
        public IEnumerable<Dog> AllDogs()
        => new List<Dog>
            {
                new Dog { Id = 1, Name = "Sharo", Age = 2,  Owner = new Owner  { Name = "Rado", Age = 32 } },
                new Dog { Id = 1, Name = "Myrun", Age = 3,  Owner = new Owner  { Name = "Rado", Age = 32 } },
            };
        

    }
}

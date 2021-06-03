using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationThatIUseForEveryLecture.Controllers.Data
{
    public class Dog
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public Owner Owner { get; set; }
    }
}

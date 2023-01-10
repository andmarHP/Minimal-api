using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace minimalAPI.Models
{
    public class Perro
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Raza { get; set; }
        public int Age { get; set; }
    }
}
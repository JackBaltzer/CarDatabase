using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarDatabase.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Model Model { get; set; }
    }
}

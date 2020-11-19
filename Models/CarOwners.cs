using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarDatabase.Models
{
    public class CarOwners
    {
        //public int Id { get; set; }
        //public List<Car> Cars { get; set; }
        [ForeignKey("Car")]
        public int CarId { get; set; }

        public Car Car   { get; set; }
        //public List<Owner> Owners { get; set; }
        [ForeignKey("Owner")]
        public int OwnerId { get; set; }
        public Owner Owner { get; set; }

    }
}

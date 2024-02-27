using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaPlace.Shared
{
    public class Customer
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")] 
        public string Name { get; set; }

        [Required(ErrorMessage = "Street is required")]
        public string Street { get; set; }

        [Required(ErrorMessage = "City is required")]
        [Required] public string City { get; set; }
    }
}

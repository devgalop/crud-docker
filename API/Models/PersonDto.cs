using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class PersonDto : AddPersonDto
    {
        public Guid Id { get; set; }
        public string FullName { get { return Name + " " + LastName; } }
    }
}
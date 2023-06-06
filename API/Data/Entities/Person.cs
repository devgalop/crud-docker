using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.Data.Entities
{
    public class Person
    {
        [Key]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Id number is required")]
        [MaxLength(20)]
        public string IdNumber { get; set; } = string.Empty;
        [Required(ErrorMessage = "Email address is mandatory")]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;
        [MaxLength(30)]
        public string Name { get; set; } = string.Empty;
        [MaxLength(30)]
        public string LastName { get; set; } = string.Empty;
    }
}
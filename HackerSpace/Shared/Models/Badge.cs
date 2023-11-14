using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerSpace.Shared.Models
{
    public class Badge
    {
        public int Id { get; set; }

        [Required]
        [MinLength(5)]
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; } 
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BasicAuth.Models
{
    public class AccountLevel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(60)]
        public string Name { get; set; }

        [StringLength(140)]
        [DataType(DataType.MultilineText)]
        public string Details { get; set; }
    }
}

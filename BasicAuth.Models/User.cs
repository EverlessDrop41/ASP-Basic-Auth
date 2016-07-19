using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BasicAuth.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 60)]
        public string Password { get; set; }
        [Required]
        [StringLength(60, MinimumLength = 60)]
        public string Salt { get; set; }

        [StringLength(60, MinimumLength = 60)]
        public string AuthKey { get; set; }
        public DateTime? AuthKeyExpirationDate { get; set; }

        [Required]
        public int AccountLevelId { get; set; }
        [ForeignKey("AccountLevelId")]
        public AccountLevel AccountLevel { get; set; }
    }
}

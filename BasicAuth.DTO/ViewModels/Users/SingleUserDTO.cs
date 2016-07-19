using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicAuth.DTO.ViewModels.Users
{
    public class SingleUserDTO : SuccessDTO
    {
        public UserDTO User { get; set; }
    }
}

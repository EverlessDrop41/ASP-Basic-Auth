using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicAuth.DTO.ViewModels.Users
{
    public class UserListDTO : SuccessDTO
    {
        public List<UserDTO> Users { get; set; }
    }
}

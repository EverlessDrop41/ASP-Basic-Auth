using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicAuth.DTO
{
    public class AddDTO : SuccessDTO
    {
        public static AddDTO Successful(int id)
        {
            return new AddDTO() { Id = id, Success = true }; 
        }

        public int Id { get; set; }
    }
}

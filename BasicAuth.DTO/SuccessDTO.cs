using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicAuth.DTO
{
    public class SuccessDTO
    {
        public static SuccessDTO GenerateError(string Messsage)
        {
            return new SuccessDTO() { Success = false, ErrorMessage = Messsage };
        }

        public bool? Success { get; set; }
        public string ErrorMessage { get; set; }
    }
}

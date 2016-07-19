using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicAuth.DTO.ViewModels.AccountLevels
{
    public class SingleAccountLevelDTO : SuccessDTO
    {
        public AccountLevelDTO AccountLevel { get; set; }
    }
}

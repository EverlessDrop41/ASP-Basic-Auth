using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicAuth.DTO.ViewModels
{
    public abstract class ModelDTO<TModel>
    {
        public abstract void FromModel(TModel From);
    }
}

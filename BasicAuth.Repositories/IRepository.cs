using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BasicAuth.DTO;

namespace BasicAuth.Repositories
{
    public interface IRepository<TModel>
    {
        IQueryable<TModel> AsQuerable();
        TModel RetrieveById(int id);
        AddDTO Create(TModel newItem);
        SuccessDTO Update(int id, Func<TModel, TModel> getNew);
        SuccessDTO Delete(int id);
    }
}

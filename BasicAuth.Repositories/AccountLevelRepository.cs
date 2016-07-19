using BasicAuth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BasicAuth.DTO;

namespace BasicAuth.Repositories
{
    public class AccountLevelRepository : IRepository<AccountLevel>
    {
        List<AccountLevel> _accountLevelList = new List<AccountLevel>()
        {
            new AccountLevel() { Id = 0, Name =  "Base", Details = "Can view but not edit" },
            new AccountLevel() { Id = 1, Name = "Admin", Details = "Can edit some things"  },
            new AccountLevel() { Id = 2, Name = "Super", Details = "Can edit evrything"    }
        };

        public AccountLevelRepository()
        {}

        public IQueryable<AccountLevel> AsQuerable()
        {
            return _accountLevelList.AsQueryable();
        }

        public AddDTO Create(AccountLevel newItem)
        {
            throw new NotImplementedException();
        }

        public SuccessDTO Delete(int id)
        {
            throw new NotImplementedException();
        }

        public AccountLevel RetrieveById(int id)
        {
            try
            {
                var a = _accountLevelList.Where(x => x.Id == id);
                var b = a.First();
                return b;
            }
            catch (Exception)
            {
                return null;
            }
            
        }

        public SuccessDTO Update(int id, Func<AccountLevel, AccountLevel> getNew)
        {
            throw new NotImplementedException();
        }
    }
}

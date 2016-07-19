using BasicAuth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using BasicAuth.DTO;

namespace BasicAuth.Repositories
{
    public class UserRepository : IRepository<User>
    {
        AccountLevelRepository _accountLevelRepo;

        List<User> _userList = new List<User>()
        {
            new User() { Id = 0, Password="pass", AccountLevelId=0, Email="user@auth.com" },
            new User() { Id = 1, Password="password", AccountLevelId=1, Email="admin@auth.com" },
            new User() { Id = 2, Password="secure_password", AccountLevelId=2, Email="super@auth.com" }
        };

        public UserRepository(AccountLevelRepository accountLevelRepo)
        {
            _accountLevelRepo = accountLevelRepo;

            foreach (User user in _userList)
            {
                user.AccountLevel = _accountLevelRepo.RetrieveById(user.AccountLevelId);
            }
        }

        public IQueryable<User> AsQuerable()
        {
            return _userList.AsQueryable();
        }

        public AddDTO Create(User newItem)
        {
            throw new NotImplementedException();
        }

        public SuccessDTO Delete(int id)
        {
            throw new NotImplementedException();
        }

        public User RetrieveById(int id)
        {
            try
            {
                return _userList.Where(x => x.Id == id).First();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public SuccessDTO Update(int id, Func<User, User> getNew)
        {
            throw new NotImplementedException();
        }
    }
}

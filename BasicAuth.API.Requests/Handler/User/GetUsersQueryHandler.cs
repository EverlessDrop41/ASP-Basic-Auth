using System;
using BasicAuth.API.Requests.Query.User;
using BasicAuth.DTO.ViewModels.Users;
using BasicAuth.Repositories;

using System.Collections.Generic;
using System.Linq;
using BasicAuth.DTO.ViewModels.AccountLevels;

namespace BasicAuth.API.Requests.Handler.User
{
    public class GetUsersQueryHandler : IQueryHandler<GetUsersQuery, UserListDTO>
    {
        UserRepository _repo;

        public GetUsersQueryHandler(UserRepository repo)
        {
            _repo = repo;
        }

        public UserListDTO Execute(GetUsersQuery query)
        {
            var data = _repo.AsQuerable();

            if (!string.IsNullOrWhiteSpace(query.SearchTerm))
            {
                data = data.Where(x => x.Email.Contains(query.SearchTerm));
            }

            if (query.AccountLevel.HasValue)
            {
                data = data.Where(x => x.AccountLevelId == query.AccountLevel.Value);
            }

            var t = data.Select(x => new UserDTO()
             {
                 Id = x.Id,
                 Email = x.Email,
                 AccountLevel = new AccountLevelDTO()
                 {
                     Id = x.AccountLevel.Id,
                     Name = x.AccountLevel.Name,
                     Details = x.AccountLevel.Details
                 }
             });

            List<UserDTO> userList = t.ToList();

            return new UserListDTO()
            {
                Success = true,
                Users = userList
            };
            
        }
    }
}

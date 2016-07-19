using System;
using BasicAuth.API.Requests.Query.AccountLevel;
using BasicAuth.DTO.ViewModels.AccountLevels;
using BasicAuth.Repositories;
using System.Linq;
using System.Collections.Generic;

namespace BasicAuth.API.Requests.Handler.AccountLevel
{
    public class GetAccountLevelsQueryHandler : IQueryHandler<GetAccountLevelsQuery, AccountLevelListDTO>
    {
        AccountLevelRepository _repo;

        public GetAccountLevelsQueryHandler(AccountLevelRepository repo)
        {
            _repo = repo;
        }

        public AccountLevelListDTO Execute(GetAccountLevelsQuery query)
        {
            var data = _repo.AsQuerable();

            if (!string.IsNullOrWhiteSpace(query.SearchTerm))
            {
                data = data.Where(x => x.Name.Contains(query.SearchTerm));
            }

            List<AccountLevelDTO> accountLevelsList = data.Select(x => new AccountLevelDTO() {
                Id = x.Id,
                Name = x.Name,
                Details = x.Details
            }).ToList();

            return new AccountLevelListDTO() {
                Success = true,
                AccountLevels = accountLevelsList
            };
        } 
    }
}

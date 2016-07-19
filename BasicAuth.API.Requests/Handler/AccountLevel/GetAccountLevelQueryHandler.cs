using System;
using BasicAuth.API.Requests.Query.AccountLevel;
using BasicAuth.DTO.ViewModels.AccountLevels;
using BasicAuth.Repositories;

namespace BasicAuth.API.Requests.Handler.AccountLevel
{
    public class GetAccountLevelQueryHandler : IQueryHandler<GetAccountLevelQuery, SingleAccountLevelDTO>
    {
        AccountLevelRepository _repo;

        public GetAccountLevelQueryHandler(AccountLevelRepository repo)
        {
            _repo = repo;
        }

        public SingleAccountLevelDTO Execute(GetAccountLevelQuery query)
        {
            if (query.Id.HasValue)
            {
                var al = new AccountLevelDTO();
                Models.AccountLevel account = _repo.RetrieveById(query.Id.Value);
                if (account != null)
                {
                    al.FromModel(account);
                    return new SingleAccountLevelDTO()
                    {
                        AccountLevel = al,
                        Success = true
                    };
                }
                else
                {
                    return new SingleAccountLevelDTO() {
                        Success = false,
                        ErrorMessage = "There is no Account Level with that id"
                    };
                }
            }
            else
            {
                return new SingleAccountLevelDTO() {
                    Success = false,
                    ErrorMessage = "Id parameter is a requried integer"
                };
            }


        }
    }
}

using BasicAuth.DTO.ViewModels.AccountLevels;

namespace BasicAuth.API.Requests.Query.AccountLevel
{
    public class GetAccountLevelsQuery : IQuery<AccountLevelListDTO>
    {
        public string SearchTerm { get; set; }
    }
}

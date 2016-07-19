using BasicAuth.DTO.ViewModels.AccountLevels;

namespace BasicAuth.API.Requests.Query.AccountLevel
{
    public class GetAccountLevelQuery : IQuery<SingleAccountLevelDTO>
    {
        public int? Id { get; set; }
    }
}

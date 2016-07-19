using BasicAuth.DTO.ViewModels.Users;

namespace BasicAuth.API.Requests.Query.User
{
    public class GetUserQuery : IQuery<SingleUserDTO>
    {
        public int? Id { get; set; }
    }
}

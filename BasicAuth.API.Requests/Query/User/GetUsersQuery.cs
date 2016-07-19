using BasicAuth.DTO.ViewModels.Users;

namespace BasicAuth.API.Requests.Query.User
{
    public class GetUsersQuery : IQuery<UserListDTO>
    {
        public string SearchTerm { get; set; }
        public int? AccountLevel { get; set; }
    }
}

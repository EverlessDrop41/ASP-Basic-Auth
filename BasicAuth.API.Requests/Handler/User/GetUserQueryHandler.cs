using System;
using BasicAuth.API.Requests.Query.User;
using BasicAuth.DTO.ViewModels.Users;
using BasicAuth.Repositories;
using BasicAuth.DTO;

namespace BasicAuth.API.Requests.Handler.User
{
    public class GetUserQueryHandler : IQueryHandler<GetUserQuery, SingleUserDTO>
    {
        UserRepository _repo;

        public GetUserQueryHandler(UserRepository repo)
        {
            _repo = repo;
        }

        public SingleUserDTO Execute(GetUserQuery query)
        {
            if (query.Id.HasValue)
            {
                var u = _repo.RetrieveById(query.Id.Value);
                if (u != null)
                {
                    UserDTO uDTO = new UserDTO();
                    uDTO.FromModel(u);
                    return new SingleUserDTO()
                    {
                        Success = true,
                        User = uDTO
                    };
                }
                else
                {
                    return new SingleUserDTO() {
                        Success = false,
                        ErrorMessage = "There is no user with that id"
                    };
                }
            }
            else
            {
                return new SingleUserDTO()
                {
                    Success = false,
                    ErrorMessage = "Id parameter is a requried integer"
                };
            }
        }
    }
}

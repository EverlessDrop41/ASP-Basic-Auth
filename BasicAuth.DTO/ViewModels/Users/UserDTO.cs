using System;
using BasicAuth.Models;
using BasicAuth.DTO.ViewModels.AccountLevels;

namespace BasicAuth.DTO.ViewModels.Users
{
    public class UserDTO : ModelDTO<User>
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public AccountLevelDTO AccountLevel { get; set; }


        public override void FromModel(User From)
        {
            Id = From.Id;
            Email = From.Email;
            AccountLevel = new AccountLevelDTO();
            AccountLevel.FromModel(From.AccountLevel);
        }
    }
}

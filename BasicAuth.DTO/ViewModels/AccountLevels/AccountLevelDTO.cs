using BasicAuth.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace BasicAuth.DTO.ViewModels.AccountLevels
{
    public class AccountLevelDTO : ModelDTO<AccountLevel>
    {
        [Required]
        [HiddenInput]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [DataType(DataType.MultilineText)]
        public string Details { get; set; }

        public override void FromModel(AccountLevel From)
        {
            Id = From.Id;
            Name = From.Name;
            Details = From.Details;
        }
    }
}

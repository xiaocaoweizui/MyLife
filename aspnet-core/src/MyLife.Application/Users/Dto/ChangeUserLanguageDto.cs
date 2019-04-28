using System.ComponentModel.DataAnnotations;

namespace MyLife.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}
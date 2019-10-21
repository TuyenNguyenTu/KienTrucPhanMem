using System.ComponentModel.DataAnnotations;

namespace Project.KienTrucPhanMem.Configuration.Dto
{
    public class ChangeUiThemeInput
    {
        [Required]
        [MaxLength(32)]
        public string Theme { get; set; }
    }
}
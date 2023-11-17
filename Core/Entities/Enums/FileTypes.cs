using System.ComponentModel.DataAnnotations;

namespace Core.Entities.Enums
{
    public enum FileTypes
    {
        None,
        [Display(Name = ".pdf")]
        PDF,
        [Display(Name = ".png")]
        PNG,
        [Display(Name = ".jpeg")]
        JPEG, 
        [Display(Name = ".jpg")]
        JPG,
        [Display(Name = ".docx")]
        DOCX
    }
}

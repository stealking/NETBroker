using Core.Entities.Enums;
using Core.Extensions;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace Core.Attributes
{

    public class FileTypeAttribute : ValidationAttribute
    {
        internal List<FileTypes> FileTypes { get; private set; }

        public FileTypeAttribute(params FileTypes[] fileTypes)
        {
            FileTypes = fileTypes.ToList();
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var file = value as IFormFile;
            if (file != null)
            {
                var fileType = Path.GetExtension(file.FileName).ToLower().GetValueFromDisplayName<FileTypes>();
                if (!FileTypes.Any(x => x == fileType))
                {
                    var extension = Path.GetExtension(file.FileName).ToLower();
                    return new ValidationResult($"File type {extension} is not allowed!");
                }
            }

            return ValidationResult.Success;
        }
    }
}

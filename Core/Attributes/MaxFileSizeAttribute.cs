using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace Core.Attributes
{
    public class MaxFileSizeAttribute : ValidationAttribute
    {
        private long maxAllowedFileSize = 2147483648;
        public MaxFileSizeAttribute(long maxFileSize)
        {
            maxAllowedFileSize = maxFileSize;
        }

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var files = value as IEnumerable<IFormFile>;
            if (files?.Count() > 0)
            {
                foreach (var file in files)
                {
                    if (file?.Length > maxAllowedFileSize)
                    {
                        return new ValidationResult($"Maximum allowed file size is {maxAllowedFileSize} bytes.");
                    }
                }
            }
            return ValidationResult.Success;
        }
    }
}

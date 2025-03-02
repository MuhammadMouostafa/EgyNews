using System.ComponentModel.DataAnnotations;
using EgyNews.Data;

namespace EgyNews.CustomValidators
{
    public class UniqueCategoryNameAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value is string categoryName)
            {
                var dbContext = validationContext.GetService(typeof(ApplicationDbContext)) as ApplicationDbContext;
                if (dbContext != null)
                {
                    bool exists = dbContext.Categories.Any(c => c.Name == categoryName);
                    if (exists)
                    {
                        return new ValidationResult("Category name must be unique.");
                    }
                }
                else
                {
                    return new ValidationResult("Unable to access the database context.");
                }
            }
            else
            {
                return new ValidationResult("Invalid value for category name.");
            }

            return ValidationResult.Success;
        }
    }
}

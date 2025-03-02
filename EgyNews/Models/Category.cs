using System.ComponentModel.DataAnnotations;
using EgyNews.CustomValidators;

namespace EgyNews.Models
{
    public class Category
    {
        [Key] // This attribute indicates that the Id property is the primary key
        public int Id { get; set; } // Its already primary key because its name is Id

        [Required]
        [UniqueCategoryName]
        public String Name { get; set; }
    }
}

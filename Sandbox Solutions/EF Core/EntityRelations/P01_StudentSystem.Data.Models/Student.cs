using P01_StudentSystem.Data.Common;
using System.ComponentModel.DataAnnotations;

namespace P01_StudentSystem.Data.Models
{
    public class Student
    {
        public Student()
        {
            
        }

        [Key]
        public int StudentId { get; set; }

        [Required]
        [MaxLength(ValidationConstants.StudentNameMaxLength)]
        public string Name { get; set; } = null!;

        [StringLength(ValidationConstants.StudentNameMaxLength)]
        public string? PhoneNumber { get; set; }

        [Required]
        public DateTime RegisteredOn { get; set; }
        public DateTime Birthday  { get; set; }
    }
}

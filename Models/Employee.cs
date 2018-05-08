using System.ComponentModel.DataAnnotations;

namespace c_sharp_emp_app.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
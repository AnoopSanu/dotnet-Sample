using System.ComponentModel.DataAnnotations;

namespace SchoolSystemWebApi.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [MaxLength(200, ErrorMessage = "Name cannot exced 200 charactors.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Age is required.")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Standard is required.")]
        public int Standard { get; set; }
    }
}

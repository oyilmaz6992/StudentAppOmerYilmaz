using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentRecordsOmerYilmaz.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [Range(0, 4.0)]
        public double GPA { get; set; }

        // Computed properties
        public int Age => DateTime.Now.Year - DateOfBirth.Year;

        public string GPAScale
        {
            get
            {
                if (GPA >= 3.7) return "Excellent";
                if (GPA >= 3.3) return "Very Good";
                if (GPA >= 2.7) return "Good";
                if (GPA >= 2.0) return "Satisfactory";
                return "Unsatisfactory";
            }
        }

       
        [Required]
        [ForeignKey("Program")]
        public string ProgramCode { get; set; }  

        public ProgramModel Program { get; set; }  //navigation property
    }
}

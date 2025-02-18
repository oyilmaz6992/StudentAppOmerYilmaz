using System.ComponentModel.DataAnnotations;

namespace StudentRecordsOmerYilmaz.Models
{
    public class ProgramModel  
    {
        [Key]
        public string ProgramCode { get; set; }  //like cpa or bacs

        [Required]
        public string Name { get; set; }  //can be computer programmer for example
    }
}

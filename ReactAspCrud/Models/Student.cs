using System.ComponentModel.DataAnnotations;

namespace ReactAspCrud.Models
{
    public class Student
    {
        [Key]
        public int id { get; set; }
        public String stname { get; set; }
        public String course { get; set; }
    }
}

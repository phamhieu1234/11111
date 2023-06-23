using System.ComponentModel.DataAnnotations;

namespace PhamTrungManh.Models
{
    public class Student
    {
        [Key]
        public string MaStudent{ get; set; }
        public string NameStudent{get; set; }
        public string Diachi{ get; set; }

    }
}
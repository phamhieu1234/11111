using System.ComponentModel.DataAnnotations;

namespace PhamTrungManh.Models
{
    public class Student
    {
        [Key]
        [MinLength(20)]
        public string MaStudent{ get; set; }
        [MinLength(50)]
        public string NameStudent{get; set; }
        public string MaLop{ get; set; }
        public string Diachi{ get; set; }

    }
}
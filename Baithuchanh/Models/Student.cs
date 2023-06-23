using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Baithuchanh.Models;

    public class Student
    {
        [Key]
        public string? MaStudent{ get; set; }
    public string? NameStudent{ get; set; }
        public string? PhonumberStudent{ get; set; }
}

using System.ComponentModel.DataAnnotations;
namespace PhamThuHa.Models
{
    public class Student  
    {
        [Key]
        public string? MaStudent{ get; set; }
        public string? NameStudent{ get; set; }
        public string? DiaChiStudent{ get; set; }
        
    }
}

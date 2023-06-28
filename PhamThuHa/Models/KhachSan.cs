using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;
namespace PhamThuHa.Models
{
    public class KhachSan
    {
        [Key]
        [Display(Name ="Mã Sinh Viên")]
        public int Id{ get; set; }
        [MaxLength(10)]
        [Display(Name ="Tên Sinh Viên")]
        public string NameStudent{ get; set; }
        [MaxLength(10)]
        [Display(Name ="Địa chỉ Sinh Viên")]
        public string DiachiStudent{ get; set; }
    }
}
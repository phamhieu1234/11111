using System.ComponentModel.DataAnnotations;

namespace PhamThuHa.Models
{
    public class HocSinh
    {
        [Key]
      
        [Display(Name ="Mã lớp học")]
        public int? MaLopHoc{ get; set; }
         
        [Display(Name ="Tên lớp học")]
          public string TenLopHoc{ get; set; }
            public string DiaLopHoc{ get; set; }

    }
}
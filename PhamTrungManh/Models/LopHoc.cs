using System.ComponentModel.DataAnnotations;

namespace PhamTrungManh.Models;

public class LopHoc
{
    [Key]
    public int MaLopId { get; set; }

    //[Required(ErrorMessage = "Vui
      [MinLength(50)]
    public string TenLop{ get; set; }
  

}
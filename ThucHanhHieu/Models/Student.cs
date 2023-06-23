using System.ComponentModel.DataAnnotations;

namespace ThucHanhHieu.Models;

public class Student
{
    [Key]
    public string? StudentCode { get; set; }
    public string? FullName { get; set; }
    public string? Address { get; set; }

}

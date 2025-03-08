using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AspireApp3.ApiService.Models;

[Table("Employee")]
public class Employee
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string? Department { get; set; }
    public string? Position { get; set; }
    public string? Status { get; set; }
    public string? Email { get; set; }
    public string? Phone { get; set; }
    public string? Address { get; set; }
    public string? City { get; set; }
    public string? State { get; set; }
    public string? PinCode { get; set; }
    public string? Country { get; set; }

}
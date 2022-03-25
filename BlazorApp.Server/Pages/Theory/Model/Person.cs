using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Server.Pages.Theory.Model;
public class Person
{
    [Range(1, Int16.MaxValue)]
    public int Id { get; set; }
    [Required]
    public string FullName { get; set; }
    [Required]
    [Range(1, 100)]
    public int EmployeeNumber { get; set; }
    [Required]
    [EmailAddress]
    public string Email { get; set; }
}

using DAL.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

public class Advertisement : Entity
{
    [Required]
    [ForeignKey("Course")]
    public int CourseId { get; set; }
    public virtual Course Course { get; set; }

    public string Description { get; set; } = string.Empty;  // Исправлено
}

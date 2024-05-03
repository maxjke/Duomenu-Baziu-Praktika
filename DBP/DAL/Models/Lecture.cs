using DAL.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

public class Lecture : Entity
{
    [Required]
    [MaxLength(100)]
    public string LectureName { get; set; } = string.Empty;

    [MaxLength(500)]
    public string Description { get; set; } = string.Empty;

    public string? Video { get; set; }

    [Required]
    public int CourseId { get; set; }
    [ForeignKey("CourseId")]
    public Course Course { get; set; }

    [ForeignKey("Schedule")]
    public int ScheduleId { get; set; } // Убедитесь, что это поле всегда заполняется

    public Schedule Schedule { get; set; }
}

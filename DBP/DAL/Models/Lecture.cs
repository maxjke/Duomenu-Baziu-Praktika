using DAL.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

public class Lecture : Entity
{
 
    public string LectureName { get; set; } = string.Empty;

 
    public string Description { get; set; } = string.Empty;

    public string? Video { get; set; }


    public int CourseId { get; set; }
    
    public Course Course { get; set; }


    public int ScheduleId { get; set; }

    public Schedule Schedule { get; set; }
}

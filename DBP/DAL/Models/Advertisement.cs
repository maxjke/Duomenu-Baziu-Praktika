using DAL.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

public class Advertisement : Entity
{
   
    public int CourseId { get; set; }
    public  Course Course { get; set; }
    public string Description { get; set; } = string.Empty;  
}

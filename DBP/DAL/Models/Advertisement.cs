using DAL.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

public class Advertisement 
{
   
    public int course_id { get; set; } 
    public  Course Course { get; set; }
    public string Information { get; set; } = string.Empty;  
}

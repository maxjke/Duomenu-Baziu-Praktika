using DAL.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

public class Student : Entity
{
    public int? contactinfo_id { get; set; }
    
    public ContactInfo ContactInfo { get; set; }


    public int group_id { get; set; }
    public Group Group { get; set; }


   

    public ICollection<Grade> Grades { get; set; } = new List<Grade>();
}

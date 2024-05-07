using DAL.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

public class Student : Entity
{
    public int? contactinfo_id { get; set; }
    
    public ContactInfo ContactInfo { get; set; } = new ContactInfo();


    public int group_id { get; set; }
    public Group Group { get; set; } = new Group();


   

    public ICollection<Grade> Grades { get; set; } = new List<Grade>();
}

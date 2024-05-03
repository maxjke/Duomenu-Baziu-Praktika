using DAL.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

public class Student : Entity
{
    public int? ContactInfoId { get; set; }
    
    public ContactInfo ContactInfo { get; set; }


    public int GroupId { get; set; }
    public Group Group { get; set; }


    public int ConsultationId { get; set; }  // Исправлено
    public Consultation Consultation { get; set; }

    public ICollection<Grade> Grades { get; set; } = new List<Grade>();
}

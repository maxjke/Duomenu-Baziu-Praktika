using DAL.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

public class Student : Entity
{
    [ForeignKey("ContactInfo")]
    public int? ContactInfoId { get; set; }
    public ContactInfo? ContactInfo { get; set; }

    [Required]
    [ForeignKey("Group")]
    public int GroupId { get; set; }
    public Group Group { get; set; }

    [ForeignKey("Consultation")]
    public int ConsultationId { get; set; }  // Исправлено
    public Consultation Consultation { get; set; }

    public virtual ICollection<Grade> Grades { get; set; } = new List<Grade>();
}

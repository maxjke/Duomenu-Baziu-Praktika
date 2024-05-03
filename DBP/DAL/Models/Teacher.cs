using DAL.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

public class Teacher : Entity
{
    [ForeignKey("ContactInfo")]
    public int? ContactInfoId { get; set; }
    public ContactInfo? ContactInfo { get; set; }

    [Required]
    [ForeignKey("Course")]
    public int CourseId { get; set; }
    public virtual Course Course { get; set; }

    [ForeignKey("Consultation")]
    public int ConsultationId { get; set; }  
    public Consultation Consultation { get; set; }
}

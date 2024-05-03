using DAL.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

public class Teacher : Entity
{
    public int? ContactInfoId { get; set; }
    public ContactInfo ContactInfo { get; set; }


    public int CourseId { get; set; }
    public  Course Course { get; set; }

    public int? ConsultationId { get; set; }
    public Consultation Consultation { get; set; }
}

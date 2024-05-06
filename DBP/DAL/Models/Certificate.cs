using DAL.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

public class Certificate : Entity
{
    public string CertificateName { get; set; } = string.Empty;
    public string CertificateDegree { get; set; } = string.Empty;
    public string ExpireDate { get; set; } = string.Empty;


    public int? course_id { get; set; }  
    public Course? Course { get; set; }
}

using DAL.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

public class Certificate : Entity
{
    public string CertificateName { get; set; } = string.Empty;
    public string CertificateDegree { get; set; } = string.Empty;
    public string ExpireDate { get; set; } = string.Empty;

    [Required]
    [ForeignKey("Course")]
    public int CourseId { get; set; }  // Исправлено, теперь не nullable
    public virtual Course? Course { get; set; }
}

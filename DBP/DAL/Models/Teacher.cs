using DAL.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

public class Teacher : Entity
{
    public int? contactinfo_id { get; set; }
    public ContactInfo ContactInfo { get; set; }


    
}

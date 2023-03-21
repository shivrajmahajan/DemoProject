using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class UserInformation
{
    public int UserId { get; set; }

    public string FirstName { get; set; } = null!;

    public string? MiddleName { get; set; }

    public string LastName { get; set; } = null!;

    public string? Gender { get; set; }

    public double? Height { get; set; }

    public int? Weight { get; set; }

    public DateTime? Dob { get; set; }

    public string? Color { get; set; }

    public string? MarrigeStatus { get; set; }

    public string? ZodiacSign { get; set; }

    public int MobileNo { get; set; }

    public int? AlternateMobile { get; set; }

    public string? Email { get; set; }

    public virtual ICollection<Photogallery> Photogalleries { get; } = new List<Photogallery>();
}

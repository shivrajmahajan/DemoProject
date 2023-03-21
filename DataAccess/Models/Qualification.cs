using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class Qualification
{
    public int QualId { get; set; }

    public string? Qualification1 { get; set; }

    public bool? IsActive { get; set; }
}

using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class District
{
    public int DistId { get; set; }

    public string DistName { get; set; } = null!;

    public int? StateId { get; set; }

    public virtual State? State { get; set; }

    public virtual ICollection<Taluka> Talukas { get; } = new List<Taluka>();
}

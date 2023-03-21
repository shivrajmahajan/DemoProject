using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class Taluka
{
    public int TqId { get; set; }

    public string TqName { get; set; } = null!;

    public int? DistId { get; set; }

    public virtual ICollection<City> Cities { get; } = new List<City>();

    public virtual District? Dist { get; set; }
}

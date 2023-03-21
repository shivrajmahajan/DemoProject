using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class City
{
    public int CityId { get; set; }

    public string CityName { get; set; } = null!;

    public int? TqId { get; set; }

    public virtual ICollection<Address> Addresses { get; } = new List<Address>();

    public virtual Taluka? Tq { get; set; }
}

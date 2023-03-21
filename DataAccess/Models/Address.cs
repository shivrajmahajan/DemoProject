using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class Address
{
    public int AddId { get; set; }

    public string Address1 { get; set; } = null!;

    public string? AddressType { get; set; }

    public int Pincode { get; set; }

    public int? CityId { get; set; }

    public virtual City? City { get; set; }
}

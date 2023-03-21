using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class State
{
    public int StateId { get; set; }

    public string? StateName { get; set; }

    public virtual ICollection<District> Districts { get; } = new List<District>();
}

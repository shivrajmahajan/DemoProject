using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class Photogallery
{
    public int PhotoId { get; set; }

    public string? ImgUrl { get; set; }

    public int? UserId { get; set; }

    public bool? IsProfile { get; set; }

    public virtual UserInformation? User { get; set; }
}

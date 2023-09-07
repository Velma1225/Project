using System;
using System.Collections.Generic;

namespace ApplicationCore.Entities;

public partial class EnvironmentPic
{
    public int EnvironmentPicId { get; set; }

    public int CompanyId { get; set; }

    public string EnvironmentPicPath { get; set; }

    public DateTime CreateAt { get; set; }

    public DateTime? UpdateAt { get; set; }

    public virtual Company Company { get; set; }
}

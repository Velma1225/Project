using System;
using System.Collections.Generic;

namespace ApplicationCore.Entities;

public partial class BoostUsed
{
    public int BoostUsedId { get; set; }

    public int Quantity { get; set; }

    public DateTime UsedAt { get; set; }

    public int JobDescriptionId { get; set; }

    public int UnitPrice { get; set; }

    public int CompanyId { get; set; }

    public virtual Company Company { get; set; }

    public virtual JobDescription JobDescription { get; set; }
}

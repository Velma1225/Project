using System;
using System.Collections.Generic;

namespace ApplicationCore.Entities;

public partial class MembershipOrder
{
    public int MembershipOrderId { get; set; }

    public int MembershipCategoryId { get; set; }

    public DateTime OrderAt { get; set; }

    public int CompanyId { get; set; }

    public DateTime DueAt { get; set; }

    public int UnitPrice { get; set; }

    public bool Online { get; set; }

    public virtual Company Company { get; set; }
}

using System;
using System.Collections.Generic;

namespace ApplicationCore.Entities;

public partial class BoostOrder
{
    public int BoostOrderId { get; set; }

    public int CompanyId { get; set; }

    public int Quantity { get; set; }

    public int Price { get; set; }

    public DateTime OrderAt { get; set; }

    public DateTime DueAt { get; set; }

    public bool Online { get; set; }

    public virtual Company Company { get; set; }
}

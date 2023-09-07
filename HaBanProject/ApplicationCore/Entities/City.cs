using System;
using System.Collections.Generic;

namespace ApplicationCore.Entities;

public partial class City
{
    public int CityId { get; set; }

    public string CityName { get; set; }

    public DateTime CreateAt { get; set; }

    public DateTime? UpdateAt { get; set; }

    public virtual ICollection<District> Districts { get; set; } = new List<District>();
}

using System;
using System.Collections.Generic;

namespace ApplicationCore.Entities;

public partial class District
{
    public int DistrictId { get; set; }

    public string DistrictName { get; set; }

    public int CityId { get; set; }

    public DateTime CreateAt { get; set; }

    public DateTime? UpdateAt { get; set; }

    public virtual ICollection<AddressDetail> AddressDetails { get; set; } = new List<AddressDetail>();

    public virtual City City { get; set; }
}

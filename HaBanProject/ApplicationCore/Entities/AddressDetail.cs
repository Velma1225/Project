using System;
using System.Collections.Generic;

namespace ApplicationCore.Entities;

public partial class AddressDetail
{
    public int AddressDetailId { get; set; }

    public string Address { get; set; }

    public decimal Latitude { get; set; }

    public decimal Longitude { get; set; }

    public int? DistrictId { get; set; }

    public virtual ICollection<AddressRelation> AddressRelations { get; set; } = new List<AddressRelation>();

    public virtual District District { get; set; }
}

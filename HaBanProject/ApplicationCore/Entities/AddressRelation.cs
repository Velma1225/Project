using System;
using System.Collections.Generic;

namespace ApplicationCore.Entities;

public partial class AddressRelation
{
    public int AddressRelationId { get; set; }

    public int? AddressId { get; set; }

    public int? CompanyId { get; set; }

    public int? JobDescriptionId { get; set; }

    public int? ResumeId { get; set; }

    public virtual AddressDetail Address { get; set; }
}

using System;
using System.Collections.Generic;

namespace ApplicationCore.Entities;

public partial class CollectionCompany
{
    public int CollectionCompanyId { get; set; }

    public int CompanyId { get; set; }

    public DateTime CreateAt { get; set; }

    public int CandidateId { get; set; }

    public virtual Candidate Candidate { get; set; }

    public virtual Company Company { get; set; }
}

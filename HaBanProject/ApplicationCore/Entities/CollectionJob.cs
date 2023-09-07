using System;
using System.Collections.Generic;

namespace ApplicationCore.Entities;

public partial class CollectionJob
{
    public int CollectionJobId { get; set; }

    public int CandidateId { get; set; }

    public DateTime CreateAt { get; set; }

    public int JobDescriptionId { get; set; }

    public virtual Candidate Candidate { get; set; }

    public virtual JobDescription JobDescription { get; set; }
}

using System;
using System.Collections.Generic;

namespace ApplicationCore.Entities;

public partial class ApplicationRecord
{
    public int ApplicationRecordId { get; set; }

    public int CompanyId { get; set; }

    public int CandidateId { get; set; }

    public int JobDescriptionId { get; set; }

    public int ResumeSnapshotId { get; set; }

    public bool ReadStatus { get; set; }

    public bool InterviewStatus { get; set; }

    public DateTime CreateAt { get; set; }

    public virtual Candidate Candidate { get; set; }

    public virtual Company Company { get; set; }

    public virtual JobDescription JobDescription { get; set; }

    public virtual ResumeSnapshot ResumeSnapshot { get; set; }
}

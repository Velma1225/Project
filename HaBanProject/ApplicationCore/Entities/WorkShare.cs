using System;
using System.Collections.Generic;

namespace ApplicationCore.Entities;

public partial class WorkShare
{
    public int WorkShareId { get; set; }

    public int CompanyId { get; set; }

    public int CandidateId { get; set; }

    public int Evaluation { get; set; }

    public string ShareContent { get; set; }

    public int JobCategoryId { get; set; }

    public DateTime CreateAt { get; set; }

    public DateTime? UpdateAt { get; set; }

    public virtual Candidate Candidate { get; set; }

    public virtual Company Company { get; set; }

    public virtual JobCategory JobCategory { get; set; }
}

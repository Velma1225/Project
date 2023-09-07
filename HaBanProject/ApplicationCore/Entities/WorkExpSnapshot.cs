using System;
using System.Collections.Generic;

namespace ApplicationCore.Entities;

public partial class WorkExpSnapshot
{
    public int WorkExpSnapshotId { get; set; }

    public int ResumeSnapshotId { get; set; }

    public string CompanyName { get; set; }

    public int IndustryCategoryId { get; set; }

    public string JobTitle { get; set; }

    public int JobNature { get; set; }

    public int JobCategoryId { get; set; }

    public bool Management { get; set; }

    public DateTime TenureStart { get; set; }

    public DateTime? TenureEnd { get; set; }

    public virtual ResumeSnapshot ResumeSnapshot { get; set; }
}

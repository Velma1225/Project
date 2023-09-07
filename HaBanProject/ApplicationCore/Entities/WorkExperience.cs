using System;
using System.Collections.Generic;

namespace ApplicationCore.Entities;

public partial class WorkExperience
{
    public int WorkExperienceId { get; set; }

    public int ResumeId { get; set; }

    public string CompanyName { get; set; }

    public int IndustryCategoryId { get; set; }

    public string JobTitle { get; set; }

    public int JobNature { get; set; }

    public int JobCategoryId { get; set; }

    public bool Management { get; set; }

    public DateTime TenureStart { get; set; }

    public DateTime? TenureEnd { get; set; }

    public DateTime CreateAt { get; set; }

    public DateTime? UpdateAt { get; set; }

    public virtual Resume Resume { get; set; }
}

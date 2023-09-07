using System;
using System.Collections.Generic;

namespace ApplicationCore.Entities;

public partial class JobCategory
{
    public int JobCategoryId { get; set; }

    public string JobCategoryName { get; set; }

    public int EmployeeCategoryId { get; set; }

    public DateTime CreateAt { get; set; }

    public virtual EmployeeCategory EmployeeCategory { get; set; }

    public virtual ICollection<JobDescription> JobDescriptions { get; set; } = new List<JobDescription>();

    public virtual ICollection<WorkShare> WorkShares { get; set; } = new List<WorkShare>();
}

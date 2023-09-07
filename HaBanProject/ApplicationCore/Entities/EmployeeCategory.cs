using System;
using System.Collections.Generic;

namespace ApplicationCore.Entities;

public partial class EmployeeCategory
{
    public int EmployeeCategoryId { get; set; }

    public string EmployeeCategoryName { get; set; }

    public int IndustryCategoryId { get; set; }

    public DateTime CreateAt { get; set; }

    public virtual IndustryCategory IndustryCategory { get; set; }

    public virtual ICollection<JobCategory> JobCategories { get; set; } = new List<JobCategory>();
}

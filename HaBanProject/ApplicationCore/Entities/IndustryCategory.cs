using System;
using System.Collections.Generic;

namespace ApplicationCore.Entities;

public partial class IndustryCategory
{
    public int IndustryCategoryId { get; set; }

    public string IndustryCategoryName { get; set; }

    public DateTime CreateAt { get; set; }

    public DateTime? UpdateAt { get; set; }

    public virtual ICollection<CompanyProfile> CompanyProfiles { get; set; } = new List<CompanyProfile>();

    public virtual ICollection<EmployeeCategory> EmployeeCategories { get; set; } = new List<EmployeeCategory>();
}

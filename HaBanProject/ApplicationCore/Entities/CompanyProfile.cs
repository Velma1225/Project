using System;
using System.Collections.Generic;

namespace ApplicationCore.Entities;

public partial class CompanyProfile
{
    public int CompanyId { get; set; }

    public int? StaffQuantity { get; set; }

    public int IndustryCategoryId { get; set; }

    public string PersonnelContact { get; set; }

    public string Fax { get; set; }

    public string CompanySite { get; set; }

    public string Address { get; set; }

    public string Introduction { get; set; }

    public string ProductContent { get; set; }

    public string Gift { get; set; }

    public string Insurance { get; set; }

    public string WelfareDesc { get; set; }

    public DateTime CreateAt { get; set; }

    public DateTime? UpdateAt { get; set; }

    public virtual Company Company { get; set; }

    public virtual ICollection<CompanyFeatureRelation> CompanyFeatureRelations { get; set; } = new List<CompanyFeatureRelation>();

    public virtual IndustryCategory IndustryCategory { get; set; }

    public virtual ICollection<JobDescription> JobDescriptions { get; set; } = new List<JobDescription>();
}

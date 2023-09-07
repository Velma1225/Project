using System;
using System.Collections.Generic;

namespace ApplicationCore.Entities;

public partial class CompanyFeatureCategory
{
    public int CompanyFeatureCategoryId { get; set; }

    public string CompanyFeatureCategoryName { get; set; }

    public DateTime CreateAt { get; set; }

    public DateTime? UpdateAt { get; set; }

    public virtual ICollection<CompanyFeatureRelation> CompanyFeatureRelations { get; set; } = new List<CompanyFeatureRelation>();
}

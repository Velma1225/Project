using System;
using System.Collections.Generic;

namespace ApplicationCore.Entities;

public partial class CompanyFeatureRelation
{
    public int CompanyFeatureRelationId { get; set; }

    public int CompanyId { get; set; }

    public int CompanyFeatureCategoryId { get; set; }

    public DateTime CreateAt { get; set; }

    public DateTime? UpdateAt { get; set; }

    public virtual CompanyProfile Company { get; set; }

    public virtual CompanyFeatureCategory CompanyFeatureCategory { get; set; }
}

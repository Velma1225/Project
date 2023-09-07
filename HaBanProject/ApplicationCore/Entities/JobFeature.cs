using System;
using System.Collections.Generic;

namespace ApplicationCore.Entities;

public partial class JobFeature
{
    public int JobFeatureId { get; set; }

    public string JobFeatures { get; set; }

    public virtual ICollection<JobFeaturesRelation> JobFeaturesRelations { get; set; } = new List<JobFeaturesRelation>();
}

using System;
using System.Collections.Generic;

namespace ApplicationCore.Entities;

public partial class JobFeaturesRelation
{
    public int JobFeaturesRelationId { get; set; }

    public int? JobDescriptionId { get; set; }

    public int? JobFeatureId { get; set; }

    public virtual JobDescription JobDescription { get; set; }

    public virtual JobFeature JobFeature { get; set; }
}

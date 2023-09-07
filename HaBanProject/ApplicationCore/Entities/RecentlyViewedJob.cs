using System;
using System.Collections.Generic;

namespace ApplicationCore.Entities;

public partial class RecentlyViewedJob
{
    public int RecentlyViewedJobsId { get; set; }

    public string CandidateId { get; set; }

    public DateTime BrowsingTime { get; set; }

    public string JobId { get; set; }
}

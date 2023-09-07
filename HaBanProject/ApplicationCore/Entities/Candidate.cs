using System;
using System.Collections.Generic;

namespace ApplicationCore.Entities;

public partial class Candidate
{
    public int CandidateId { get; set; }

    public string CandidateAccount { get; set; }

    public string Password { get; set; }

    public string Name { get; set; }

    public int Gender { get; set; }

    public string MobilePhone { get; set; }

    public string Email { get; set; }

    public string PhotoUrl { get; set; }

    public DateTime CreateAt { get; set; }

    public virtual ICollection<ApplicationRecord> ApplicationRecords { get; set; } = new List<ApplicationRecord>();

    public virtual ICollection<ChatMessage> ChatMessages { get; set; } = new List<ChatMessage>();

    public virtual ICollection<CollectionCompany> CollectionCompanies { get; set; } = new List<CollectionCompany>();

    public virtual ICollection<CollectionJob> CollectionJobs { get; set; } = new List<CollectionJob>();

    public virtual ICollection<Resume> Resumes { get; set; } = new List<Resume>();

    public virtual ICollection<WorkShare> WorkShares { get; set; } = new List<WorkShare>();
}

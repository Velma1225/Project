using System;
using System.Collections.Generic;

namespace ApplicationCore.Entities;

public partial class Company
{
    public int CompanyId { get; set; }

    public string CompanyAccount { get; set; }

    public string Password { get; set; }

    public string CompanyName { get; set; }

    public string LogoUrl { get; set; }

    public string CompanyPhone { get; set; }

    public string Email { get; set; }

    public int BoostNumber { get; set; }

    public DateTime MembershipDate { get; set; }

    public DateTime FreeDate { get; set; }

    public DateTime CreateAt { get; set; }

    public virtual ICollection<ApplicationRecord> ApplicationRecords { get; set; } = new List<ApplicationRecord>();

    public virtual ICollection<BoostOrder> BoostOrders { get; set; } = new List<BoostOrder>();

    public virtual ICollection<BoostUsed> BoostUseds { get; set; } = new List<BoostUsed>();

    public virtual ICollection<ChatMessage> ChatMessages { get; set; } = new List<ChatMessage>();

    public virtual ICollection<CollectionCompany> CollectionCompanies { get; set; } = new List<CollectionCompany>();

    public virtual CompanyProfile CompanyNavigation { get; set; }

    public virtual ICollection<EnvironmentPic> EnvironmentPics { get; set; } = new List<EnvironmentPic>();

    public virtual ICollection<MembershipOrder> MembershipOrders { get; set; } = new List<MembershipOrder>();

    public virtual ICollection<WorkShare> WorkShares { get; set; } = new List<WorkShare>();
}

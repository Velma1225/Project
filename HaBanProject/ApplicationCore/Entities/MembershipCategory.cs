using System;
using System.Collections.Generic;

namespace ApplicationCore.Entities;

public partial class MembershipCategory
{
    public int MembershipCategoryId { get; set; }

    public string MembershipName { get; set; }

    public int UnitPrice { get; set; }

    public int DiscountPrice { get; set; }

    public int TotalDate { get; set; }

    public DateTime CreateAt { get; set; }

    public DateTime? UpdateAt { get; set; }
}

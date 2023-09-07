using System;
using System.Collections.Generic;

namespace ApplicationCore.Entities;

public partial class ResumeSnapshot
{
    public int ResumeSnapshotId { get; set; }

    public int ApplicationRecordId { get; set; }

    public string Name { get; set; }

    public int Gender { get; set; }

    public int? Age { get; set; }

    public int EmploymentCategoryId { get; set; }

    public string Address { get; set; }

    public string GraduationSchool { get; set; }

    public string MajorIn { get; set; }

    public int EducationId { get; set; }

    public string PhotoUrl { get; set; }

    public string Autobiography { get; set; }

    public string Language { get; set; }

    public string DrivingLicense { get; set; }

    public string ComputerSkill { get; set; }

    public virtual ICollection<ApplicationRecord> ApplicationRecords { get; set; } = new List<ApplicationRecord>();

    public virtual ICollection<WorkExpSnapshot> WorkExpSnapshots { get; set; } = new List<WorkExpSnapshot>();
}

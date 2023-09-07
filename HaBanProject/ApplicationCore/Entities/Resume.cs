using System;
using System.Collections.Generic;

namespace ApplicationCore.Entities;

public partial class Resume
{
    public int ResumeId { get; set; }

    public int CandidateId { get; set; }

    public string ResumeName { get; set; }

    public int? Age { get; set; }

    public int EmploymentCategoryId { get; set; }

    public string Address { get; set; }

    public string GraduationSchool { get; set; }

    public string MajorIn { get; set; }

    public int EducationId { get; set; }

    public string Autobiography { get; set; }

    public string Language { get; set; }

    public string DrivingLicense { get; set; }

    public string ComputerSkill { get; set; }

    public DateTime CreateAt { get; set; }

    public DateTime? UpdateAt { get; set; }

    public bool OpenOrClosed { get; set; }

    public int Rank { get; set; }

    public virtual Candidate Candidate { get; set; }

    public virtual ICollection<WorkExperience> WorkExperiences { get; set; } = new List<WorkExperience>();
}

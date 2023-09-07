using System;
using System.Collections.Generic;

namespace ApplicationCore.Entities;

public partial class JobDescription
{
    public int JobDescriptionId { get; set; }

    public string JobId { get; set; }

    public int CompanyId { get; set; }

    public string JobTitle { get; set; }

    public string JobDetail { get; set; }

    public int SalaryPaymentId { get; set; }

    public int? MinSalary { get; set; }

    public int? MaxSalary { get; set; }

    public string Address { get; set; }

    public int JobShiftId { get; set; }

    public string WorkingHours { get; set; }

    public int? JobCategoryId { get; set; }

    public int EmploymentCategoryId { get; set; }

    public bool IsManager { get; set; }

    public int JobTenureId { get; set; }

    public int EducationId { get; set; }

    public string Language { get; set; }

    public string DrivingLicense { get; set; }

    public string ComputerSkill { get; set; }

    public int VacancyNumber { get; set; }

    public string ContactName { get; set; }

    public string ContactEmail { get; set; }

    public string ContactPhone { get; set; }

    public string ContactAddress { get; set; }

    public string PostScript { get; set; }

    public DateTime CreateAt { get; set; }

    public DateTime UpdateAt { get; set; }

    public DateTime? PostStartAt { get; set; }

    public DateTime? PostEndAt { get; set; }

    public DateTime? BoostEndAt { get; set; }

    public bool IsPosted { get; set; }

    public int DisplayOrder { get; set; }

    public virtual ICollection<ApplicationRecord> ApplicationRecords { get; set; } = new List<ApplicationRecord>();

    public virtual ICollection<CollectionJob> CollectionJobs { get; set; } = new List<CollectionJob>();

    public virtual CompanyProfile Company { get; set; }

    public virtual JobCategory JobCategory { get; set; }

    public virtual BoostUsed JobDescriptionNavigation { get; set; }

    public virtual ICollection<JobFeaturesRelation> JobFeaturesRelations { get; set; } = new List<JobFeaturesRelation>();
}

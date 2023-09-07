using System;
using System.Collections.Generic;

namespace Haban.Models;

public partial class JobDescriptions
{
    public int Id { get; set; }

    public string JobId { get; set; } = null!;

    public int CompanyId { get; set; }

    public string JobTitle { get; set; } = null!;

    public string JobDescription { get; set; } = null!;

    public int SalaryPaymentId { get; set; }

    public int? MinSalary { get; set; }

    public int? MaxSalary { get; set; }

    public string Address { get; set; } = null!;

    public int JobShiftId { get; set; }

    public string WorkingHours { get; set; } = null!;

    //public int JobCategoryId { get; set; }

    public int EmploymentCategoryId { get; set; }

    public bool Management { get; set; }

    public int JobTenureId { get; set; }

    public int EducationId { get; set; }

    public string Language { get; set; } = null!;

    public string DrivingLicense { get; set; } = null!;

    public string ComputerSkill { get; set; } = null!;

    public int VacancyNumber { get; set; }

    public DateTime CreateAt { get; set; }

    public DateTime UpdateAt { get; set; }

    public DateTime? PostStartAt { get; set; }

    public DateTime? PostEndAt { get; set; }

    public DateTime? BoostEndAt { get; set; }

    public bool PostStatus { get; set; }

    public int DisplayOrder { get; set; }

    public string ContactName { get; set; }

    public string ContactEmail { get; set; }

    public string ContactPhone { get; set; }

    public string ContactAddress { get; set; }

    public string PostScript { get; set; }
}

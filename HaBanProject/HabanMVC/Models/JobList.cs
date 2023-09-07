using System;
using System.Collections.Generic;

namespace HabanMVC.Models;

public partial class JobList
{
    public int Id { get; set; }

    public string JobName { get; set; }

    public string CompanyName { get; set; }

    public int PayByHour { get; set; }

    public string Location { get; set; }

    public int JobTenure { get; set; }

    public int Education { get; set; }

    public string JobDescription { get; set; }

    public bool OpenOrNot { get; set; }
}

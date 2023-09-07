using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Services
{
    public class JobService
    {
        private readonly IRepository<JobDescription> _jobRepository;

        public JobService(IRepository<JobDescription> jobRepository)
        {
            _jobRepository = jobRepository;
        }

        public List<JobDescription> GetJobs()
        {
            return null;
        }
    }
}

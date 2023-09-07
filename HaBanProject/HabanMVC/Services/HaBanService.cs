

using ApplicationCore.Entities;
using ApplicationCore.Enums;
using ApplicationCore.Interfaces;
using HabanMVC.ViewModels.HaBan;
using Microsoft.EntityFrameworkCore;
using System.Drawing;

namespace HabanMVC.Services
{
    public class HaBanService : IHaBanService
    {
        private readonly IRepository<Company> _companyRepo;
        private readonly IRepository<JobDescription> _jobDescRepo;

        public HaBanService(IRepository<Company> companyRepo, IRepository<JobDescription> jobDescRepo)
        {
            _companyRepo = companyRepo;
            _jobDescRepo = jobDescRepo;
        }

        public async Task<List<CompanySlider>> GetAllSlider()
        {
            //var result = new List<CompanySlider>();
            var companytop27 = await _companyRepo.ListAsync(c => c.CompanyId < 27);
            var jobDes = await _jobDescRepo.ListAsync(j => companytop27.Select(c => c.CompanyId).Contains(j.CompanyId));

            

            var companyslider = new List<CompanySlider>();

            foreach (var c in companytop27)
            {
                var companyJobs = jobDes.Where(j => j.CompanyId == c.CompanyId);

                // 計算薪資，預設值為 40000
                var maxSalary = companyJobs.Max(j => j.MaxSalary ?? 40000); // 若 MaxSalary 為 null，則使用 40000
                var salaryPaymentId = companyJobs.Max(j => j.SalaryPaymentId);

                if (salaryPaymentId == (int)JobDescriptionEnum.PayByHour) // 時薪制
                {
                    maxSalary = maxSalary * 8 * 22; // 轉換為月薪
                }
                

                var temp = new CompanySlider()
                {
                    Hyperlink = c.CompanyId.ToString(),
                    ImageUrl = c.LogoUrl,
                    ImageAlt = c.CompanyName,
                    Name = c.CompanyName,
                    HighestPaying = (int)Math.Truncate((decimal)maxSalary / 1000)
                };


                companyslider.Add(temp);
            }

            return companyslider;
        }



    }
}

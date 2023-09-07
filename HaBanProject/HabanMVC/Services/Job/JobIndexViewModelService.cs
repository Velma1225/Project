using ApplicationCore.Entities;
using Azure.Core;
using Haban.Models;
using HabanMVC.Models;
using HabanMVC.ViewModels.Job.Description;
using HabanMVC.ViewModels.Job.Index;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text.Json.Serialization;

namespace HabanMVC.Services.Job
{
    public class JobIndexViewModelService
    {
        private readonly JobRepository _jobRepository;
        //private readonly IJobService _jobService;
        private readonly HaBanContext _context;
        private readonly CommonGetServices _commonGetServices;

        public JobIndexViewModelService(
            //IJobService jobService,
            CommonGetServices commonGetServices,
            JobRepository jobRepository,
            HaBanContext context)
        {
            //_jobService = jobService;
            _commonGetServices = commonGetServices;
            _jobRepository = jobRepository;
            _context = context;
        }

        public JobIndexViewModel TransformToJobIndexViewModel()
        {
            //List<JobDescriptions> jobDescriptions = _jobRepository.GetJobs();
            var jobDescriptions = _context.JobDescriptions.Include(job => job.Company).ToList();
            //List<JobDescriptions> jobDescriptions = _jobService.GetJobs();

            List<JobIndexCardViewModel> jobList = jobDescriptions.Select(job => new JobIndexCardViewModel
            {
                Id = job.JobDescriptionId,
                JobTitle = job.JobTitle,
                Company = _context.Companies.FirstOrDefault(c => c.CompanyId == job.CompanyId).CompanyName,
                CompanyUrl = "https://www.google.com.tw/",
                JobDescription = job.JobDetail,
                SalaryPayment = _commonGetServices.GetSalaryPayment(job.SalaryPaymentId),
                SalaryRange = $"(F){job.MinSalary}元至{job.MaxSalary}元",
                City = "(WS)台北市",
                District = "(WS)中山區",
                JobTenure = _commonGetServices.GetJobTenure(job.JobTenureId),
                Education = _commonGetServices.GetEducation(job.EducationId),



            }).ToList();

            var freshSearchList = new List<FreshSearchViewModel>
                {
                    new FreshSearchViewModel()
                    {
                        SearchItem = "(Fake)💰 高薪四萬休假日",
                        KeywordUrl = "https://www.518.com.tw/job-index.html?ap=2&ak=80&ak_min=40000"
                    } ,
                    new FreshSearchViewModel()
                    {
                        SearchItem = "(Fake)🍚 伙食津貼吃飽飽",
                        KeywordUrl = "https://www.518.com.tw/job-index.html?ap=2&ak=80&ak_min=40000"
                    } ,
                    new FreshSearchViewModel()
                    {
                        SearchItem = "(Fake)👕 門市員購好優惠",
                        KeywordUrl = "https://www.518.com.tw/job-index.html?ap=2&ak=80&ak_min=40000"
                    } ,
                    new FreshSearchViewModel()
                    {
                        SearchItem = "(Fake)💼 無工作經驗免煩惱",
                        KeywordUrl = "https://www.518.com.tw/job-index.html?ap=2&ak=80&ak_min=40000"
                    }
                };

            var viewModel = new JobIndexViewModel
            {
                JobList = jobList,
                FreshSearchList = freshSearchList
            };

            return viewModel;
        }

        //public JobIndexViewModelService(JobRepository jobRepository, CommonGetServices commonGetServices)
        //{
        //    _jobRepository = jobRepository;
        //    _commonGetServices = commonGetServices;
        //}


        //public JobIndexViewModel TransformToJobIndexViewModel()
        //{
        //    List<JobDescriptions> jobDescriptions = _jobRepository.GetJobs();

        //    List<JobIndexCardViewModel> jobList = jobDescriptions.Select(job => new JobIndexCardViewModel
        //    {
        //        Id = job.Id,
        //        JobTitle = job.JobTitle,
        //        Company = "(WS)八方雲集(中和興南店/明輝小吃店)",
        //        CompanyUrl = "https://www.google.com.tw/",
        //        JobDescription = job.JobDescription,
        //        SalaryPayment = _commonGetServices.GetSalaryPayment(job.SalaryPaymentId),
        //        SalaryRange = $"(F){job.MinSalary}元至{job.MaxSalary}元",
        //        City = "(WS)台北市",
        //        District = "(WS)中山區",
        //        JobTenure = _commonGetServices.GetJobTenure(job.JobTenureId),
        //        Education = _commonGetServices.GetEducation(job.EducationId),



        //    }).ToList();

        //    var freshSearchList = new List<FreshSearchViewModel>
        //        {
        //            new FreshSearchViewModel()
        //            {
        //                SearchItem = "(Fake)💰 高薪四萬休假日",
        //                KeywordUrl = "https://www.518.com.tw/job-index.html?ap=2&ak=80&ak_min=40000"
        //            } ,
        //            new FreshSearchViewModel()
        //            {
        //                SearchItem = "(Fake)🍚 伙食津貼吃飽飽",
        //                KeywordUrl = "https://www.518.com.tw/job-index.html?ap=2&ak=80&ak_min=40000"
        //            } ,
        //            new FreshSearchViewModel()
        //            {
        //                SearchItem = "(Fake)👕 門市員購好優惠",
        //                KeywordUrl = "https://www.518.com.tw/job-index.html?ap=2&ak=80&ak_min=40000"
        //            } ,
        //            new FreshSearchViewModel()
        //            {
        //                SearchItem = "(Fake)💼 無工作經驗免煩惱",
        //                KeywordUrl = "https://www.518.com.tw/job-index.html?ap=2&ak=80&ak_min=40000"
        //            }
        //        };

        //    var viewModel = new JobIndexViewModel
        //    {
        //        JobList = jobList,
        //        FreshSearchList = freshSearchList
        //    };

        //    return viewModel;
        //}
    }
}

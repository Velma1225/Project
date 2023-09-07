
using Azure.Core;
using Haban.Models;
using HabanMVC.ViewModels.Job.Description;
using HabanMVC.ViewModels.Job.Index;
using System;
using System.Collections.Generic;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace HabanMVC.Services.Job    
{
    public class JobDescriptionViewModelService
    {
        private readonly JobRepository _jobRepository;
        private readonly CommonGetServices _commonGetServices;
        public JobDescriptionViewModelService(JobRepository jobRepository, CommonGetServices commonGetServices)
        {
            _jobRepository = jobRepository;
            _commonGetServices = commonGetServices;
        }

        public List<JobDescriptionViewModel> TransformToJDViewModel()
        {
            List<JobDescriptions> jobDescriptions = _jobRepository.GetJobs();
            List<JobDescriptionViewModel> jDViewModels = jobDescriptions.Select(job => new JobDescriptionViewModel
            {
                Id = job.Id,
                JobId = job.JobId,
                JobTitle = job.JobTitle,
                Company = "(WS)八方雲集(中和興南店/明輝小吃店)",
                CompanyUrl = "https://www.google.com.tw/",
                JobDescription = job.JobDescription,
                SalaryPayment = _commonGetServices.GetSalaryPayment(job.SalaryPaymentId),
                SalaryRange = $"(F){job.MinSalary}元至{job.MaxSalary}元",
                Address = job.Address,
                City = "(WS)台北市",
                District = "(WS)中山區",
                JobTenure = _commonGetServices.GetJobTenure(job.JobTenureId),
                Education = _commonGetServices.GetEducation(job.EducationId),
                JobShift = _commonGetServices.GetJobShift(job.JobShiftId),
                WorkingHours = job.WorkingHours,
                JobCategoryList = new List<string>
                {
                    "(WS)廚師",
                    "(WS)飯店工作人員",
                },
                EmploymentCategory = _commonGetServices.GetEmploymentCategory(job.EmploymentCategoryId),
                Management = job.Management ? "(F)是" : "(F)否",
                Language = job.Language,
                DrivingLicense = job.DrivingLicense,
                ComputerSkill = job.ComputerSkill,
                VacancyNumber = 1,
                JobFeatureList = new List<string>
                {
                    "(WS)國外駐點工作",
                    "(WS)彈性上下班",
                    "(WS)交通津貼",
                    "(WS)伙食津貼",
                    "(WS)週休二日",
                    "(WS)無須輪班",
                },
                UpdateAt = $"(F){job.UpdateAt.ToString("yyyy-MM-dd")}",
                ContactName = job.ContactName,
                ContactEmail = job.ContactEmail,
                ContactPhone = job.ContactPhone,
                ContactAddress = job.ContactAddress,
                PostScript = job.PostScript,
                SimilarJob = new WidgetJDViewModel
                {
                    Title = "(WS)看過此職缺的人也看了...",
                    CardList = GetSimilarJobs()

                },
                MostVisitedJob = new WidgetJDViewModel
                {
                    Title = "(WS)最多人瀏覽的職缺",
                    CardList = GetMostVisitedJobs()
                },
                VisitedJob = new WidgetJDViewModel
                {
                    Title = "(WS)瀏覽紀錄",
                    CardList = GetVisitedJobs()
                }
            }).ToList();

            return jDViewModels;
        }
        

        public JobDescriptionViewModel GetJobById(int id)
        {
            List<JobDescriptionViewModel> allJobs = TransformToJDViewModel();
            JobDescriptionViewModel job = allJobs.FirstOrDefault(j => j.Id == id);
            return job;
        }



        //public JobDescriptionViewModel GetJDViewModel()
        //{
        //    JobDescriptionViewModel viewModel = new JobDescriptionViewModel()
        //    {
        //        //Id = 1,
        //        //JobTitle = "(WS)(隔日匯185)晚班理貨員-近關渡大橋",
        //        //JobDescription = "(WS)四輪推車卸貨並將貨品依項目分類擺放、需搬運、疊放。",
        //        //SalaryPayment = "(WS)時薪",
        //        //MinSalary = 200,
        //        //MaxSalary = 250,
        //        //Address = "(WS)台北市北投區立德路111號",
        //        //JobShift = "(WS)晚班",
        //        //WorkingHours = "(WS)16:00-20:30",
        //        //JobCategoryList = new List<string>
        //        //{
        //        //    "(WS)廚師",
        //        //    "(WS)飯店工作人員",
        //        //},
        //        //EmploymentCategory = "(WS)兼職",
        //        //Management = "(WS)無",
        //        //Language = "(WS)英語、台語",
        //        //DrivingLicense = "(WS)汽車、機車",
        //        //ComputerSkill = "(WS)Word、Excel",
        //        //VacancyNumber = "(WS)1",
        //        //JobFeatureList = new List<string>
        //        //{
        //        //    "(WS)國外駐點工作",
        //        //    "(WS)彈性上下班",
        //        //    "(WS)交通津貼",
        //        //    "(WS)伙食津貼",
        //        //    "(WS)週休二日",
        //        //    "(WS)無須輪班",
        //        //},
        //        //ContactName = "(WS)李小姐",
        //        //ContactEmail = "(WS)aa@gmail.com",
        //        //ContactPhone = "(WS)0912-345-678",
        //        //ContactAddress = "(WS)台北市北投區立德路999號",
        //        //PostScript = "(WS)歡迎直接早上11:00後來電預約面試！",
        //        //SimilarJob = new WidgetJDViewModel
        //        //{
        //        //    Title = "(WS)看過此職缺的人也看了...",
        //        //    CardList = GetSimilarJobs()

        //        //},
        //        //MostVisitedJob = new WidgetJDViewModel
        //        //{
        //        //    Title = "(WS)最多人瀏覽的職缺",
        //        //    CardList = GetMostVisitedJobs()
        //        //},
        //        //VisitedJob = new WidgetJDViewModel
        //        //{
        //        //    Title = "(WS)瀏覽紀錄",
        //        //    CardList = GetVisitedJobs()
        //        //}
        //    };
        //    return viewModel;
        //}

        public List<WidgetJDCardViewModel> GetSimilarJobs()
        {
            var jobs = new List<WidgetJDCardViewModel>
            {
                new WidgetJDCardViewModel()
                {
                    Id = 1,
                    JobTitle = "(WS)(隔日匯185)晚班理貨員-近關渡大橋",
                    Company = "(WS)力信股份有限公司",
                    CompanyUrl = "https://www.google.com.tw/",
                    SalaryPayment = "(WS)時薪",
                    City = "(WS)新北市",
                    District = "(WS)淡水區",
                    JobTenure = "(WS)不拘",
                    Education = "(WS)高中"
                },
                new WidgetJDCardViewModel()
                {
                    Id = 2,
                    JobTitle = "(WS)配管工作夥伴-急徵有白卡優先錄取",
                    Company = "(WS)裕亞科技有限公司",
                    CompanyUrl = "https://www.google.com.tw/",
                    SalaryPayment = "(WS)月薪",
                    City = "(WS)台北市",
                    District = "(WS)中山區",
                    JobTenure = "(WS)三年以上",
                    Education = "(WS)專科"
                },
                    
               
            };
            return jobs;
        }

        public List<WidgetJDCardViewModel> GetMostVisitedJobs()
        {
            var jobs = new List<WidgetJDCardViewModel>
            {
                new WidgetJDCardViewModel()
                {
                    Id = 3,
                    JobTitle = "(WS)7-11晚班門市人員(板橋)",
                    Company = "(WS)統一超商(友銓企業社/百壽門市)",
                    CompanyUrl = "https://www.google.com.tw/",
                    SalaryPayment = "(WS)時薪",
                    City = "(WS)新北市",
                    District = "(WS)板橋區",
                    JobTenure = "(WS)不拘",
                    Education = "(WS)高中"
                },
                new WidgetJDCardViewModel()
                {
                    Id = 4,
                    JobTitle = "(WS)黑米義式餐廳 全職外場服務人員(萬隆店)(近公館)",
                    Company = "(WS)黑米餐廳_小黑米餐飲股份有限公司",
                    CompanyUrl = "https://www.google.com.tw/",
                    SalaryPayment = "(WS)月薪",
                    City = "(WS)台北市",
                    District = "(WS)文山區",
                    JobTenure = "(WS)不拘",
                    Education = "(WS)專科"
                },
            };
            return jobs;
        }

        public List<WidgetJDCardViewModel> GetVisitedJobs()
        {
            var jobs = new List<WidgetJDCardViewModel>
            {
                new WidgetJDCardViewModel()
                {
                    Id = 5,
                    JobTitle = "(WS)【BELLINI CAFFE】台北敦南店-內場實習主管-提供品牌獎金",
                    Company = "(WS)三澧企業股份有限公司",
                    CompanyUrl = "https://www.google.com.tw/",
                    SalaryPayment = "(WS)月薪",
                    //SalaryRange = $"(WS){request.MinSalary}~{request.MaxSalary}",
                    City = "(WS)台北市",
                    District = "(WS)大安區",
                    JobTenure = "(WS)不拘",
                    Education = "(WS)大學"
                },
                new WidgetJDCardViewModel()
                {
                    Id = 6,
                    JobTitle = "(WS)國旅領團人員",
                    Company = "(WS)尋憶旅行社有限公司",
                    CompanyUrl = "https://www.google.com.tw/",
                    SalaryPayment = "(WS)月薪",
                    //SalaryRange = $"(WS){request.MinSalary}~{request.MaxSalary}",
                    City = "(WS)台北市",
                    District = "(WS)中山區",
                    JobTenure = "(WS)不拘",
                    Education = "(WS)高中"
                }
            };
            return jobs;
        }
    }
}

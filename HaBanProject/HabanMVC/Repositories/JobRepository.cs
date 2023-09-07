using Haban.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace HabanMVC.Repositories
{
    public class JobRepository
    {
        private static List<JobDescriptions> _jobs = new List<JobDescriptions>
        {
            new JobDescriptions
            {
                Id = 1,
                JobId = "aaa111",
                JobTitle = "(F)(隔日匯)日班理貨員-近關渡大橋AAAAAAA",
                JobDescription = "(F)四輪推車卸貨並將貨品依項目分類擺放、需搬運、疊放。",
                SalaryPaymentId = 1,
                MinSalary = 200,
                MaxSalary = 250,
                Address = "(F)台北市北投區立德路1號",
                JobShiftId = 1,
                WorkingHours = "(F)16:00-20:30",
                //JobCategoryList = new List<string>
                //{
                //    "(F)廚師",
                //    "(F)飯店工作人員",
                //},
                EmploymentCategoryId = 2,
                Management = false,
                JobTenureId = 1,
                Language = "(F)英語、台語",
                DrivingLicense = "(F)汽車、機車",
                ComputerSkill = "(F)Word、Excel",
                VacancyNumber = 1,
                CreateAt = new DateTime(2023,8,1),
                UpdateAt = new DateTime(2023,8,11),
                PostStartAt = new DateTime(2023,8,21),
                PostEndAt = new DateTime(2023,8,31),
                BoostEndAt = new DateTime(2023,9,1),
                //JobFeatureList = new List<string>
                //{
                //    "(F)國外駐點工作",
                //    "(F)彈性上下班",
                //    "(F)交通津貼",
                //    "(F)伙食津貼",
                //    "(F)週休二日",
                //    "(F)無須輪班",
                //},
                PostStatus = true,
                DisplayOrder = 1,
                ContactName = "(F)李小姐",
                ContactEmail = "(F)aa@gmail.com",
                ContactPhone = "(F)0912-345-678",
                ContactAddress = "(F)台北市北投區立德路11號",
                PostScript = "(F)歡迎直接早上11:00後來電預約面試！",
            },
            new JobDescriptions
            {   
                Id = 2,
                JobId = "bbb222",
                JobTitle = "(F)日班正職/儲備幹部BBBBBBBBB",
                JobDescription = "(F)鍋貼水餃包製",
                SalaryPaymentId = 2,
                MinSalary = 32200,
                MaxSalary = 45000,
                Address = "(F)新北市中和區仁愛街2號",
                JobShiftId = 1,
                WorkingHours = "(F)05:00-16:00",
                //JobCategoryList = new List<string>
                //{
                //    "(F)廚師",
                //    "(F)飯店工作人員",
                //},
                EmploymentCategoryId = 1,
                Management = true,
                JobTenureId = 2,
                Language = "(F)台語、中文",
                DrivingLicense = "(F)機車",
                ComputerSkill = "(F)Word、Excel",
                VacancyNumber = 1,
                CreateAt = new DateTime(2023,8,1),
                UpdateAt = new DateTime(2023,8,11),
                PostStartAt = new DateTime(2023,8,21),
                PostEndAt = new DateTime(2023,8,31),
                BoostEndAt = new DateTime(2023,9,1),
                //JobFeatureList = new List<string>
                //{
                //    "(F)國外駐點工作",
                //    "(F)彈性上下班",
                //    "(F)交通津貼",
                //    "(F)伙食津貼",
                //    "(F)週休二日",
                //    "(F)無須輪班",
                //},
                PostStatus = true,
                DisplayOrder = 1,
                ContactName = "(F)張先生",
                ContactEmail = "(F)bb@gmail.com",
                ContactPhone = "(F)0912-345-678",
                ContactAddress = "(F)新北市中和區仁愛街22號",
                PostScript = "(F)無",
            }
        };

        public List<JobDescriptions> GetJobs()
        {
            return _jobs;
        }

        //public JobDescriptions GetJobById(int id)
        //{
        //    return _jobs.FirstOrDefault(job => job.Id == id);
        //}

    }
}

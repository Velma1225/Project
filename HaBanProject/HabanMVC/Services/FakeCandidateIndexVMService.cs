using ApplicationCore.Entities;
using HabanMVC.ViewModels.Candidate;
using Microsoft.AspNetCore.Http.HttpResults;
using System.Xml;

namespace HabanMVC.Services
{
    public class FakeCandidateIndexVMService : ICandidateIndexVMService
    {
        public async Task<CandidateIndexVM> GetCandidateViewModel()
        {
            return new CandidateIndexVM
            {
                CandidateInfo = await GetCandidateInfo(),
                ApplicationRecords = await GetApplicationRecords(),
                FavoriteJob = await GetFavoriteJob(),
                FavoriteCompany = await GetFavoriteCompany()
            };
        }

        private async Task<CandidateInfoVM> GetCandidateInfo()
        {
            return new CandidateInfoVM
            {
                PhotoURL = "Candidate-0001.png",
                Name = "Neil",
                ResumeName = "我的履歷1",
                OpenOrClosed = true,
                Email = "neil@gmail.com"
            };
        }
        private async Task<List<ApplicationRecordsVM>> GetApplicationRecords()
        {
            return new List<ApplicationRecordsVM>
            {
                new ApplicationRecordsVM
                {
                    AppliedPosition = "ASP.NET Core7 MVC C#後端工程師",
                    ResumeName = "我的履歷1",
                    ReadStatus = true,
                    CreateAt = new DateTime(2023, 9, 10)
                },
                new ApplicationRecordsVM
                {
                    AppliedPosition = "ASP.NET Core7 MVC C#後端工程師",
                    ResumeName = "我的履歷1",
                    ReadStatus = true,
                    CreateAt = new DateTime(2023, 9, 10)
                }
            };
        }
        private async Task<List<FavoriteJobVM>> GetFavoriteJob()
        {
            return new List<FavoriteJobVM>
            {
                new FavoriteJobVM
                {
                    JobTitle = "Build Shcool ASP.NET Core7 MVC 清潔工",
                    CompanyName = "Build Shcool",
                    CreateAt = new DateTime(2023, 9, 10)
                },
                new FavoriteJobVM
                {
                    JobTitle = "Build Shcool ASP.NET Core7 MVC 清潔工",
                    CompanyName = "Build Shcool",
                    CreateAt = new DateTime(2023, 9, 10)
                }
            };
        }
        private async Task<List<FavoriteCompanyVM>> GetFavoriteCompany()
        {
            return new List<FavoriteCompanyVM>
            {
                new FavoriteCompanyVM
                {
                    CompanyName = "Build Shcool ASP.NET Core7 MVC 前端工程師",
                    IndustryCategory = "資訊業",
                    CreateAt = new DateTime(2023, 9, 10)
                },
                new FavoriteCompanyVM
                {
                    CompanyName = "Build Shcool ASP.NET Core7 MVC 前端工程師",
                    IndustryCategory = "資訊業",
                    CreateAt = new DateTime(2023, 9, 10)
                }
            };
        }
    }
}

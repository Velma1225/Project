using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using Haban.Models;
using HabanMVC.ViewModels.Company;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Net;
using System.Xml;

namespace HabanMVC.Services
{
    public class CompanyService : ICompanyService
    {
        private readonly IRepository<Company> _companyRepo;
        private readonly IRepository<ApplicationCore.Entities.Candidate> _candidateRepo;
        private readonly IRepository<JobDescription> _jobDescRepo;
        private readonly IRepository<ApplicationRecord> _applicationRepo;
        private readonly IRepository<MembershipCategory> _membershipCategoryRepo;

        public CompanyService(
            IRepository<Company> companyRepo,
            IRepository<Candidate> candidateRepo,
            IRepository<JobDescription> jobDescRepo,
            IRepository<ApplicationRecord> applicationRepo,
            IRepository<MembershipCategory> membershipCategoryRepo)
        {
            _companyRepo = companyRepo;
            _candidateRepo = candidateRepo;
            _jobDescRepo = jobDescRepo;
            _applicationRepo = applicationRepo;
            _membershipCategoryRepo = membershipCategoryRepo;
        }
        public CompanyProfileViewModel GetCompanyProfile()
        {
            CompanyProfileViewModel viewModel = new CompanyProfileViewModel()
            {
                CompanyName = "FakeCoCo都可(億巨國際股份有限公司)",
                CompanyLogoPic = "/images/Company/CompanyProfile/cocologo.png",
                CompanyAccount = "Fake04690055",
                CompanyPhone = "Fake暫不提供",
                Fax = "暫不提供",
                PersonnelContact = "人資部",
                StaffNumber = "1000",
                IndustryCategory = "餐飲業",
                CompanySite = "http://www.coco-tea.com",
                Address = "Fake台北市士林區後港街116號3樓",
                Introduction = "FakeCoCo 源自於葡萄牙文，是笑臉，期許讓每個人喝了CoCo的飲品之後有發自內心的微笑；本著把飲品的美好分享給更多人的初心，我們在20 多年前，開創了CoCo都可第一家店。<br><br> CoCo都可是以每一杯的堅持累積出來的，沒有僥倖，也沒有運氣，源自這扎實地的基本功，讓我們始終跟隨市場的腳步持續創新；也因此，現今在全球市場上已坐擁4,500+間門市，分佈在上海、北京、東京、曼谷、馬尼拉、紐約、洛杉磯、舊金山、溫哥華、多倫多、倫敦及雪梨…等各大城市，成為橫跨各大洲的知名茶飲連鎖品牌<br>更於2017~18榮獲世界品牌論壇的首要獎項—“World Branding Awards”，廣為世人認可，實至名歸<br><br>經營理念<br>把CoCo的正能量傳遞到全世界，點亮每一刻!<br>Spark up every moment. It’s your drink. CoCo",
                ProductContent = "以提供「多元化創意飲品」為主要服務項目。<br> 總部設有專業的研發團隊與實驗室，以確保每杯飲品如出一轍，並依季節推出新品，提供消費者多元的選擇，保有產品競爭力，也為品牌注入源源不絕的生命力。",
                CompanyFeature = new List<CompanyFeatureViewModel>()
                {
                    new CompanyFeatureViewModel()
                    {
                        CompanyFeatureName ="外商公司"
                    },
                     new CompanyFeatureViewModel()
                    {
                        CompanyFeatureName ="員購優惠"
                    },

                },
                Gift = "禮品 、 績效獎金",
                Insurance = "員工/眷屬團保",
                WelfareDetail = "\r\n     (1)保險：享有勞保、健保及6%勞退金提撥<br>\r\n                            (2)員工福利：<br>\r\n                            ＊康樂福利：國內外旅遊補助、定期聚餐<br>\r\n                            ＊節慶福利：年節禮品、生日禮金、尾牙/春酒活動<br>\r\n                            ＊健檢福利：任職滿半年以上提供每年免費特約醫院健康檢查<br>\r\n                            ＊其他福利：舒壓按摩服務、婚喪喜慶補助、員工制服提供、特約商店<br>\r\n                            (3)制度項目<br>\r\n                            ＊完善獎金制度：績效獎金、全勤獎金、伙食費、業績獎金、年終獎金、介紹獎金<br>\r\n                            ＊教育訓練：管理職能訓練、店鋪專業職能訓練、E-learning線上學習平台<br>\r\n                            ＊休假制度：月休8-10天，特休假、生理假、同仁陪產假/育嬰假等<br>\r\n                            ＊透明的升遷管道，員工年度調薪\r\n                        ",

                WorkShare = new List<WorkShareViewModel>()
                {
                    new WorkShareViewModel()
                    {
                        PositionCategory ="Fake門市／店員／專櫃人員",
                        ShareEvaluation =3,
                        ShareContent ="Fake就自身以往待過的公司說,公司風氣還不錯~"
                    },
                    new WorkShareViewModel()
                    {
                        PositionCategory ="門市／店員／專櫃人員",
                        ShareEvaluation =5,
                        ShareContent ="就自身以往待過的公司說,公司風氣還不錯~"
                    },
                    new WorkShareViewModel()
                    {
                        PositionCategory ="門市／店員／專櫃人員",
                        ShareEvaluation =1,
                        ShareContent ="就自身以往待過的公司說,公司風氣還不錯~"
                    },


                },
                Work = new List<WorkViewModel>()
                {
                    new WorkViewModel()
                    {
                        WorkName ="Fake【香繼光集團】北區門市儲備主管薪37400元起",
                        SalaryRange ="Fake月薪 37,400 至 39,400 元",
                        WorkContent ="Fake●完整透明升遷制度 ●入股當股東(內創合作店、內創加盟店) ●績效獎金、年終獎金、生日獎金 ●春酒、季度聚餐、員工旅遊補助 ●海外門市外派機會",
                        Date =new DateTime(2023,09,05,15,00,00),
                        WorkDistrict ="Fake台北市-中山區"
                    },
                           new WorkViewModel()
                    {
                        WorkName ="【香繼光集團】北區門市儲備主管薪37400元起",
                        SalaryRange ="月薪 37,400 至 39,400 元",
                        WorkContent ="●完整透明升遷制度 ●入股當股東(內創合作店、內創加盟店) ●績效獎金、年終獎金、生日獎金 ●春酒、季度聚餐、員工旅遊補助 ●海外門市外派機會",
                        Date =new DateTime(2023,09,05,15,00,00),
                        WorkDistrict ="台北市-中山區"
                    },
                      new WorkViewModel()
                    {
                        WorkName ="【香繼光集團】北區門市儲備主管薪37400元起",
                        SalaryRange ="月薪 37,400 至 39,400 元",
                        WorkContent ="●完整透明升遷制度 ●入股當股東(內創合作店、內創加盟店) ●績效獎金、年終獎金、生日獎金 ●春酒、季度聚餐、員工旅遊補助 ●海外門市外派機會",
                        Date =new DateTime(2023,09,05,15,00,00),
                        WorkDistrict ="台北市-中山區"
                    },
                      new WorkViewModel()
                    {
                        WorkName ="【香繼光集團】北區門市儲備主管薪37400元起",
                        SalaryRange ="月薪 37,400 至 39,400 元",
                        WorkContent ="●完整透明升遷制度 ●入股當股東(內創合作店、內創加盟店) ●績效獎金、年終獎金、生日獎金 ●春酒、季度聚餐、員工旅遊補助 ●海外門市外派機會",
                         Date =new DateTime(2023,09,05,15,00,00),
                        WorkDistrict ="台北市-中山區"
                    }
                },
                EnvironmentPic = new List<EnvironmentPicViewModel>()
                {
                    new EnvironmentPicViewModel()
                    {
                        EnvironmentPicPath ="/images/Company/CompanyProfile/environment_pic.jpg"
                    },
                      new EnvironmentPicViewModel()
                    {
                        EnvironmentPicPath ="/images/Company/CompanyProfile/environment_pic_1.jpg"
                    },
                      new EnvironmentPicViewModel()
                    {
                        EnvironmentPicPath ="/images/Company/CompanyProfile/environment_3.jpg"
                    }
                },
                SimilarCompany = new List<SimilarCompanyViewModel>()
                {
                    new SimilarCompanyViewModel()
                    {
                        CompanyName = "華香有限公司",
                        CompanyDistrict = "台北市-中山區"
                    },
                     new SimilarCompanyViewModel()
                    {
                        CompanyName = "饗樂餐飲實業股份有限公司",
                        CompanyDistrict = "新北市-三重區"
                    },
                                  new SimilarCompanyViewModel()
                    {
                        CompanyName = "樂多多集團_樂多多世界股份有限公司",
                        CompanyDistrict = "新北市-汐止區"
                    },
                },
                DistrictList = new List<DistrictListViewModel>()
                {
                    new DistrictListViewModel()
                    {
                        District="台北市-中山區"
                    },
                       new DistrictListViewModel()
                    {
                        District="台北市-大安區"
                    },
                       new DistrictListViewModel()
                    {
                        District="台北市-松山區"
                    },

                },
                JobCategory = new List<JobCategoryViewModel>()
                {
                    new JobCategoryViewModel()
                    {
                        JobCategory="全職 - 餐飲服務人員",
                    },
                        new JobCategoryViewModel()
                    {
                        JobCategory="全職 - 門市／店員／專櫃人員",
                    },
                        new JobCategoryViewModel()
                    {
                        JobCategory="全職 - 飲品調製販售員",
                    },
                        new JobCategoryViewModel()
                    {
                        JobCategory="全職 - 儲備幹部",
                    },
                }




            };

            return viewModel;
        }

        public CompanyProfileEditViewModel GetCompanyProfileEdit()
        {
            CompanyProfileEditViewModel viewModel = new CompanyProfileEditViewModel()
            {
                CompanyName = "FakeCoCo都可(億巨國際股份有限公司)",
                CompanyLogoPic = "/images/Company/CompanyProfile/cocologo.png",
                CompanyAccount = "04690055",
                CompanyPhone = "暫不提供",
                Fax = "暫不提供",
                PersonnelContact = "人資部",
                StaffNumber = "1000",
                IndustryCategory = "餐飲業",
                CompanySite = "http://www.coco-tea.com",
                Address = "台北市士林區後港街116號3樓",
                Introduction = "FakeCoCo 源自於葡萄牙文，是笑臉，期許讓每個人喝了CoCo的飲品之後有發自內心的微笑；本著把飲品的美好分享給更多人的初心，我們在20 多年前，開創了CoCo都可第一家店。<br><br> CoCo都可是以每一杯的堅持累積出來的，沒有僥倖，也沒有運氣，源自這扎實地的基本功，讓我們始終跟隨市場的腳步持續創新；也因此，現今在全球市場上已坐擁4,500+間門市，分佈在上海、北京、東京、曼谷、馬尼拉、紐約、洛杉磯、舊金山、溫哥華、多倫多、倫敦及雪梨…等各大城市，成為橫跨各大洲的知名茶飲連鎖品牌<br>更於2017~18榮獲世界品牌論壇的首要獎項—“World Branding Awards”，廣為世人認可，實至名歸<br><br>經營理念<br>把CoCo的正能量傳遞到全世界，點亮每一刻!<br>Spark up every moment. It’s your drink. CoCo",
                ProductContent = "以提供「多元化創意飲品」為主要服務項目。<br> 總部設有專業的研發團隊與實驗室，以確保每杯飲品如出一轍，並依季節推出新品，提供消費者多元的選擇，保有產品競爭力，也為品牌注入源源不絕的生命力。",
                CompanyFeature = new List<CompanyFeatureViewModel>()
                {
                    new CompanyFeatureViewModel()
                    {
                        CompanyFeatureName ="外商公司"
                    },
                     new CompanyFeatureViewModel()
                    {
                        CompanyFeatureName ="員購優惠"
                    },

                },
                Gift = "Fake禮品 、 績效獎金",
                Insurance = "員工/眷屬團保",
                WelfareDetail = "\r\n     (1)保險：享有勞保、健保及6%勞退金提撥<br>\r\n                            (2)員工福利：<br>\r\n                            ＊康樂福利：國內外旅遊補助、定期聚餐<br>\r\n                            ＊節慶福利：年節禮品、生日禮金、尾牙/春酒活動<br>\r\n                            ＊健檢福利：任職滿半年以上提供每年免費特約醫院健康檢查<br>\r\n                            ＊其他福利：舒壓按摩服務、婚喪喜慶補助、員工制服提供、特約商店<br>\r\n                            (3)制度項目<br>\r\n                            ＊完善獎金制度：績效獎金、全勤獎金、伙食費、業績獎金、年終獎金、介紹獎金<br>\r\n                            ＊教育訓練：管理職能訓練、店鋪專業職能訓練、E-learning線上學習平台<br>\r\n                            ＊休假制度：月休8-10天，特休假、生理假、同仁陪產假/育嬰假等<br>\r\n                            ＊透明的升遷管道，員工年度調薪\r\n                        ",
                EnvironmentPic = new List<EnvironmentPicViewModel>()
                {
                    new EnvironmentPicViewModel()
                    {
                        EnvironmentPicPath ="environment_pic.jpg"
                    },
                    new EnvironmentPicViewModel()
                    {
                        EnvironmentPicPath ="environment_pic_1.jpg"
                    },
                     new EnvironmentPicViewModel()
                    {
                        EnvironmentPicPath ="environment_3.jpg"
                    }
                }
            };

            return viewModel;
        }

        //public async Task<List<JobList>> GetJobList()
        //{
        //    List<JobList> joblist = await _companyRepo.ReadAllJobList().OrderByDescending(j => j.OpenOrNot);

        //    List<JobList> joblist = await _companyRepo;
        //    joblist = joblist.OrderByDescending(j => j.OpenOrNot).ToList();

        //    return joblist;
        //}


        public async Task<List<CoverLetterViewModel>> GetCoverLetterList(int? jobID)
        {
            var application = await _applicationRepo.ListAsync(a => a.CompanyId == 1);//之後要判斷登入者(企業)的ID
            if (jobID.HasValue)
            {
                application.Where(ap => ap.JobDescriptionId == jobID.Value);
            }
            var jobDes = await _jobDescRepo.ListAsync(j => application.Select(ap => ap.JobDescriptionId).Contains(j.JobDescriptionId));
            var candidate = await _candidateRepo.ListAsync(c => application.Select(ap => ap.CandidateId).Contains(c.CandidateId));



            var coverLetters = application.Select(a =>
            new CoverLetterViewModel
            {
                CompanyId = a.CandidateId,
                CandidateId = a.CandidateId,
                JobDescriptionId = a.JobDescriptionId,
                JobTitle = jobDes.Where(j => j.JobDescriptionId == a.JobDescriptionId).First().JobTitle,
                CandidateName = candidate.Where(c => c.CandidateId == a.CandidateId).First().Name,
                ResumeSnapshotId = a.ResumeSnapshotId,
                ReadStatus = a.ReadStatus,
                InterviewStatus = a.InterviewStatus,
                CreateAt = a.CreateAt
            }).ToList();









            return coverLetters;
        }




        public BoostOrdersViewModel GetCompanyBuyTop()
        {
            BoostOrdersViewModel buytop = new BoostOrdersViewModel()
            {
                BoostOrderID = 8704711,
                Quantity = 1,
                Price = 1800
            };

            return buytop;
        }

        public AccountEditViewModel GetAccountEdit()
        {

            AccountEditViewModel accountEdit = new AccountEditViewModel()
            {
                CompanyId = 12345678,
                Password = "********",
                CompanyName = "Build School",
                IndustryCategory = "資訊業",
                Mobile = "0912345677",
                Email = "build@gmail"
            };

            return accountEdit;
        }

        public async Task<List<SelectListItem>> GetSelectListItems(int? jobID)
        {
            List<SelectListItem> jobSelectItems = new List<SelectListItem>()
            {
                new SelectListItem()
                {
                    Value= null,
                    Text = "請選擇"
                }
            };

            var jobDes = await _jobDescRepo.ListAsync(j => j.CompanyId == 1);//之後要判斷登入者(企業)的ID
            var application = await _applicationRepo.ListAsync(a => jobDes.Select(j => j.JobDescriptionId).Contains(a.JobDescriptionId));


            var coverLetters = jobDes.Select(j =>
            new SelectListItem
            {
                Value = j.JobDescriptionId.ToString(),
                Text = j.JobTitle,
                Selected = j.JobDescriptionId == jobID

            }).ToList();

            jobSelectItems.AddRange(coverLetters);

            return jobSelectItems;



        }



        public async Task<MembershipBuyVM> GetMembershipModel()
        {
            MembershipBuyVM vm = new MembershipBuyVM()
            {
                MembershipCateList = new List<MembershipCategoriesVM>()
                { }
            };


            return vm;




        }
    }
}

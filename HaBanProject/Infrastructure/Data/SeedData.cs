using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Infrastructure.Data
{
    internal class SeedData
    {

        //檢查事項:
        //1.各表的ID是識別規格 不用填寫

        //2.注意內容的合理性:
        //SeedData的產業 人員 職務類別ID必須是真實對應我們有列出來的選項!
        //不然之後篩選的結果會難以確認是否正確
        //有關聯的部分要參考其他人已寫好的內容
        //例如:
        //公司ID和職缺ID的匹配(餐廳找服務員、超商找店員)
        //職缺及履歷的內容要跟 產業ID/職務ID 匹配(工作經歷的職務分類、需求職缺的職務分類)

        //*SeedData就寫自己創資料表的那幾張


        //==================================== Neil 開始====================================
        //Neil updated at 9/3 15:42
        public static List<Candidate> ProduceCandidate()
        {
            return new List<Candidate>()
            {
                new Candidate
                {
                    CandidateId = 1,
                    CandidateAccount="F112233447",
                    Password = "Mary87654321",
                    Name = "王瑪莉",
                    Gender = 2,
                    MobilePhone = "0988888888",
                    Email = "Mary@gmail.com",
                    PhotoUrl = "Candidate-0001.png",
                    CreateAt = new DateTime(2023,04,03)
                },
                new Candidate
                {
                    CandidateId = 2,
                    CandidateAccount="F443322111",
                    Password = "Leo87654321",
                    Name = "黃小明",
                    Gender = 1,
                    MobilePhone = "0966666666",
                    Email = "Leo@gmail.com",
                    PhotoUrl = "Candidate-0002.jpg",
                    CreateAt = new DateTime(2023,06,03)
                }
            };
        }

        public static List<ApplicationRecord> ProduceApplicationRecord()
        {
            return new List<ApplicationRecord>()
            {
                new ApplicationRecord
                {
                    ApplicationRecordId = 1,
                    CompanyId = 1,
                    CandidateId= 1,
                    JobDescriptionId = 1,
                    ResumeSnapshotId = 1,
                    ReadStatus = true,
                    InterviewStatus = true,
                    CreateAt = new DateTime(2023,10,27)
                },
                new ApplicationRecord
                {
                    ApplicationRecordId = 2,
                    CompanyId = 2,
                    CandidateId= 2,
                    JobDescriptionId = 2,
                    ResumeSnapshotId = 2,
                    ReadStatus = false,
                    InterviewStatus = false,
                    CreateAt = new DateTime(2023,10,24)
                },
                 new ApplicationRecord
                {
                    ApplicationRecordId = 3,
                    CompanyId = 1,
                    CandidateId= 2,
                    JobDescriptionId = 1,
                    ResumeSnapshotId = 3,
                    ReadStatus = false,
                    InterviewStatus = false,
                    CreateAt = new DateTime(2023,10,30)
                }
            };
        }

        public static List<Company> ProduceCompany()
        {
            return new List<Company>()
            {
                new Company
                {
                    CompanyId = 1,
                    CompanyAccount="77881234",
                    Password = "wowprime87654321",
                    CompanyName = "王品餐飲股份有限公司",
                    LogoUrl = "wowprime.png",
                    CompanyPhone = "0911222333",
                    Email = "wowprime@gmail.com",
                    BoostNumber = 0,
                    MembershipDate = new DateTime(2023,10,03),
                    FreeDate = new DateTime(2023,09,08),
                    CreateAt = new DateTime(2023,09,03)
                },
                new Company
                {
                    CompanyId = 2,
                    CompanyAccount="88774321",
                    Password = "yungching87654321",
                    CompanyName = "永慶房產集團(永慶房屋仲介股份有限公司)",
                    LogoUrl = "yungching.png",
                    CompanyPhone = "0955333222",
                    Email = "yungching@gmail.com",
                    BoostNumber = 1,
                    MembershipDate = new DateTime(2023,10,03),
                    FreeDate = new DateTime(2023,09,08),
                    CreateAt = new DateTime(2023,09,03)
                }
            };
        }





        //==================================== Neil 結束====================================

        //==================================== Zoe 開始====================================
        //Zoe updated at 9/3 21:19
        public static List<JobCategory> ProduceJobCategory()
        {
            return new List<JobCategory>()
            {
               
               new JobCategory
                {
               JobCategoryId=1,
               EmployeeCategoryId=1,
               JobCategoryName="廚師",
               CreateAt=new DateTime(2023,9,2)
                 },
               new JobCategory
                {
               JobCategoryId=2,
               EmployeeCategoryId=1,
               JobCategoryName="服務員",
               CreateAt=new DateTime(2023,9,2)
                },
                 new JobCategory
                {
               JobCategoryId=3,
               EmployeeCategoryId=1,
               JobCategoryName="麵包師",
               CreateAt=new DateTime(2023,9,2)
                },
               new JobCategory
                {
               JobCategoryId=4,
               EmployeeCategoryId=2,
               JobCategoryName="飯店工作人員",
               CreateAt=new DateTime(2023,9,2)
                },
               new JobCategory
                {
               JobCategoryId=5,
               EmployeeCategoryId=2,
               JobCategoryName="領隊/導遊",
               CreateAt=new DateTime(2023,9,2)
                },
                new JobCategory
                {
               JobCategoryId=6,
               EmployeeCategoryId=2,
               JobCategoryName="空服/地勤人員",
               CreateAt=new DateTime(2023,9,2)
                },
                new JobCategory
                {
               JobCategoryId=7,
               EmployeeCategoryId=3,
               JobCategoryName="美容/美髮師",
               CreateAt=new DateTime(2023,9,2)
                },
                new JobCategory
                {
               JobCategoryId=8,
               EmployeeCategoryId=3,
               JobCategoryName="醫美諮詢師",
               CreateAt=new DateTime(2023,9,2)
                },
                 new JobCategory
                {
               JobCategoryId=9,
               EmployeeCategoryId=3,
               JobCategoryName="美甲師",
               CreateAt=new DateTime(2023,9,2)
                },
                 new JobCategory
                {
               JobCategoryId=10,
               EmployeeCategoryId=4,
               JobCategoryName="軟體工程師",
               CreateAt=new DateTime(2023,9,2)
                },
                 new JobCategory
                {
               JobCategoryId=11,
               EmployeeCategoryId=4,
               JobCategoryName="資料工程師",
               CreateAt=new DateTime(2023,9,2)
                },
                   new JobCategory
                {
               JobCategoryId=12,
               EmployeeCategoryId=4,
               JobCategoryName="Android/iOS工程師",
               CreateAt=new DateTime(2023,9,2)
                },
                 new JobCategory
                {
               JobCategoryId=13,
               EmployeeCategoryId=5,
               JobCategoryName="系統工程師",
               CreateAt=new DateTime(2023,9,2)
                },
                 new JobCategory
                {
               JobCategoryId=14,
               EmployeeCategoryId=5,
               JobCategoryName="網路管理工程師",
               CreateAt=new DateTime(2023,9,2)
                },
                   new JobCategory
                {
               JobCategoryId=15,
               EmployeeCategoryId=5,
               JobCategoryName="資安工程師",
               CreateAt=new DateTime(2023,9,2)
                },
                new JobCategory
                {
               JobCategoryId=16,
               EmployeeCategoryId=6,
               JobCategoryName="電話客服",
               CreateAt=new DateTime(2023,9,2)
                },
                new JobCategory
                {
               JobCategoryId=17,
               EmployeeCategoryId=6,
               JobCategoryName="文字客服",
               CreateAt=new DateTime(2023,9,2)
                },
                new JobCategory
                {
               JobCategoryId=18,
               EmployeeCategoryId=7,
               JobCategoryName="門市/店員/專櫃人員",
               CreateAt=new DateTime(2023,9,2)
                },
                 new JobCategory
                {
               JobCategoryId=19,
               EmployeeCategoryId=7,
               JobCategoryName="售票/收銀人員",
               CreateAt=new DateTime(2023,9,2)
                },
                  new JobCategory
                {
               JobCategoryId=20,
               EmployeeCategoryId=8,
               JobCategoryName="電話行銷人員",
               CreateAt=new DateTime(2023,9,2)
                },
                  new JobCategory
                {
               JobCategoryId=21,
               EmployeeCategoryId=8,
               JobCategoryName="不動產經紀人",
               CreateAt=new DateTime(2023,9,2)
                },
                   new JobCategory
                {
               JobCategoryId=22,
               EmployeeCategoryId=8,
               JobCategoryName="國內外業務人員",
               CreateAt=new DateTime(2023,9,2)
                },
                new JobCategory
                {
               JobCategoryId=23,
               EmployeeCategoryId=9,
               JobCategoryName="船務/報關人員",
               CreateAt=new DateTime(2023,9,2)
                },
                new JobCategory
                {
               JobCategoryId=24,
               EmployeeCategoryId=9,
               JobCategoryName="國貿人員",
               CreateAt=new DateTime(2023,9,2)
                },
                new JobCategory
                {
               JobCategoryId=25,
               EmployeeCategoryId=10,
               JobCategoryName="作業員/包裝員",
               CreateAt=new DateTime(2023,9,2)
                },
                new JobCategory
                {
               JobCategoryId=26,
               EmployeeCategoryId=10,
               JobCategoryName="電機工程技術員",
               CreateAt=new DateTime(2023,9,2)
                },
                  new JobCategory
                {
               JobCategoryId=27,
               EmployeeCategoryId=10,
               JobCategoryName="領班",
               CreateAt=new DateTime(2023,9,2)
                },
                    new JobCategory
                {
               JobCategoryId=28,
               EmployeeCategoryId=11,
               JobCategoryName="產品維修人員",
               CreateAt=new DateTime(2023,9,2)
                },
                     new JobCategory
                {
               JobCategoryId=29,
               EmployeeCategoryId=11,
               JobCategoryName="電機裝修工",
               CreateAt=new DateTime(2023,9,2)
                },
              new JobCategory
                {
               JobCategoryId=30,
               EmployeeCategoryId=11,
               JobCategoryName="汽車/機車技術人員",
               CreateAt=new DateTime(2023,9,2)
                },
               new JobCategory
                {
               JobCategoryId=31,
               EmployeeCategoryId=12,
               JobCategoryName="醫師",
               CreateAt=new DateTime(2023,9,2)
                },
                 new JobCategory
                {
               JobCategoryId=32,
               EmployeeCategoryId=12,
               JobCategoryName="藥師",
               CreateAt=new DateTime(2023,9,2)
                },
                  new JobCategory
                {
               JobCategoryId=33,
               EmployeeCategoryId=12,
               JobCategoryName="護理師及護士",
               CreateAt=new DateTime(2023,9,2)
                },
                  new JobCategory
                {
               JobCategoryId=34,
               EmployeeCategoryId=13,
               JobCategoryName="按摩/推拿師",
               CreateAt=new DateTime(2023,9,2)
                },
                    new JobCategory
                {
               JobCategoryId=35,
               EmployeeCategoryId=13,
               JobCategoryName="診所助理",
               CreateAt=new DateTime(2023,9,2)
                },
                      new JobCategory
                {
               JobCategoryId=36,
               EmployeeCategoryId=13,
               JobCategoryName="醫院行政管理人員",
               CreateAt=new DateTime(2023,9,2)
                },
            };

        }


        public static List<EmployeeCategory> ProduceEmployeeCategory()
        {
            return new List<EmployeeCategory>()
            {
                new EmployeeCategory
                 {
                    EmployeeCategoryId = 1,
                    IndustryCategoryId = 1,
                    EmployeeCategoryName = "餐飲類人員",
                    CreateAt = new DateTime(2023, 9, 2)

                    },
                 new EmployeeCategory
                    {
                    EmployeeCategoryId = 2,
                    IndustryCategoryId = 1,
                    EmployeeCategoryName = "旅遊休閒類人員",
                    CreateAt = new DateTime(2023, 9, 2)

                    },
                 new EmployeeCategory
                    {
                    EmployeeCategoryId = 3,
                    IndustryCategoryId = 1,
                    EmployeeCategoryName = "美容美髮類人員",
                    CreateAt = new DateTime(2023, 9, 2)

                    },
                  new EmployeeCategory
                    {
                    EmployeeCategoryId = 4,
                    IndustryCategoryId = 2,
                    EmployeeCategoryName = "軟體/工程類人員",
                    CreateAt = new DateTime(2023, 9, 2)

                    },
                  new EmployeeCategory
                    {
                    EmployeeCategoryId = 5,
                    IndustryCategoryId = 2,
                    EmployeeCategoryName = "MIS／網管類人員",
                    CreateAt = new DateTime(2023, 9, 2)

                     },
                  new EmployeeCategory
                   {
                    EmployeeCategoryId = 6,
                    IndustryCategoryId = 3,
                    EmployeeCategoryName = "客戶服務類人員",
                    CreateAt = new DateTime(2023, 9, 2)

                    },
                  new EmployeeCategory
                  {
                    EmployeeCategoryId = 7,
                    IndustryCategoryId = 3,
                    EmployeeCategoryName = "門市營業類人員",
                    CreateAt = new DateTime(2023, 9, 2)

                    },
                   new EmployeeCategory
                    {
                    EmployeeCategoryId = 8,
                    IndustryCategoryId = 3,
                    EmployeeCategoryName = "業務銷售類人員",
                    CreateAt = new DateTime(2023, 9, 2)

                     },
                    new EmployeeCategory
                    {
                    EmployeeCategoryId = 9,
                    IndustryCategoryId = 3,
                    EmployeeCategoryName = "貿易類人員",
                    CreateAt = new DateTime(2023, 9, 2)

                    },
                    new EmployeeCategory
                     {
                    EmployeeCategoryId = 10,
                    IndustryCategoryId = 4,
                    EmployeeCategoryName = "操作／技術類人員",
                    CreateAt = new DateTime(2023, 9, 2)

                    },

                    new EmployeeCategory
                    {
                    EmployeeCategoryId = 11,
                    IndustryCategoryId = 4,
                    EmployeeCategoryName = "維修／技術服務類人員",
                    CreateAt = new DateTime(2023, 9, 2)

                    },
                    new EmployeeCategory
                    {
                    EmployeeCategoryId = 12,
                    IndustryCategoryId = 5,
                    EmployeeCategoryName = "醫療專業類人員",
                    CreateAt = new DateTime(2023, 9, 2)

                    },
                     new EmployeeCategory
                    {
                    EmployeeCategoryId = 13,
                    IndustryCategoryId = 5,
                    EmployeeCategoryName = "醫療／保健服務人員",
                    CreateAt = new DateTime(2023, 9, 2)

                    },
            };
        }


        public static List<IndustryCategory> ProduceIndustryCategory()
        {
            return new List<IndustryCategory>()
            {
                 new IndustryCategory {
                    IndustryCategoryId=1,
                    IndustryCategoryName="餐飲／旅遊 ／美容美髮類",
                    CreateAt=new DateTime(2023,9,2),
                    UpdateAt =new DateTime(2023,9,3)
                    },
                 new IndustryCategory {
                    IndustryCategoryId=2,
                    IndustryCategoryName="資訊軟體系統類",
                    CreateAt=new DateTime(2023,9,2),
                    UpdateAt =new DateTime(2023,9,3)
                    },
                   new IndustryCategory {
                    IndustryCategoryId=3,
                    IndustryCategoryName="客服／門市／業務／貿易類",
                    CreateAt=new DateTime(2023,9,2),
                    UpdateAt =new DateTime(2023,9,3)
                     },
                new IndustryCategory {
                    IndustryCategoryId=4,
                    IndustryCategoryName="操作／技術／維修類",
                    CreateAt=new DateTime(2023,9,2),
                    UpdateAt =new DateTime(2023,9,3)
                    },
                new IndustryCategory
                {
                    IndustryCategoryId=5,
                    IndustryCategoryName="醫療/保健服務類",
                    CreateAt=new DateTime(2023,9,2),
                    UpdateAt =new DateTime(2023,9,3)
                },
            };

        }


        public static List<District> ProduceDistrict()
        {
            return new List<District>()
            {
                 new District {
                      DistrictId=1,
                      CityId=2,
                      DistrictName="松山區",
                      CreateAt=new DateTime(2023,9,2)
                  },
                  new District {
                      DistrictId=2,
                      CityId=2,
                      DistrictName="信義區",
                      CreateAt=new DateTime(2023,9,2)
                  },
                   new District {
                      DistrictId=3,
                      CityId=2,
                      DistrictName="大安區",
                      CreateAt=new DateTime(2023,9,2)
                  },
                    new District {
                      DistrictId=4,
                      CityId=2,
                      DistrictName="中山區",
                      CreateAt=new DateTime(2023,9,2)
                  },
                    new District {
                      DistrictId=5,
                      CityId=2,
                      DistrictName="中正區",
                      CreateAt=new DateTime(2023,9,2)
                  },
                    new District {
                      DistrictId=6,
                      CityId=2,
                      DistrictName="大同區",
                      CreateAt=new DateTime(2023,9,2)
                  },
                     new District {
                      DistrictId=7,
                      CityId=2,
                      DistrictName="萬華區",
                      CreateAt=new DateTime(2023,9,2)
                  },
                      new District {
                      DistrictId=8,
                      CityId=2,
                      DistrictName="文山區",
                      CreateAt=new DateTime(2023,9,2)
                  },
                      new District {
                      DistrictId=9,
                      CityId=2,
                      DistrictName="南港區",
                      CreateAt=new DateTime(2023,9,2)
                  },
                      new District {
                      DistrictId=10,
                      CityId=2,
                      DistrictName="內湖區",
                      CreateAt=new DateTime(2023,9,2)
                  },
                      new District {
                      DistrictId=11,
                      CityId=2,
                      DistrictName="士林區",
                      CreateAt=new DateTime(2023,9,2)
                  },
                      new District {
                      DistrictId=12,
                      CityId=2,
                      DistrictName="北投區",
                      CreateAt=new DateTime(2023,9,2)
                  },
            };

        }

        public static List<City> ProduceCity()
        {
            return new List<City>()
            {
                 new City {
                     CityId=1,
                     CityName="基隆市",
                     CreateAt=new DateTime(2023,9,2),
                     UpdateAt =new DateTime(2023,9,3)
                     },
                  new City {
                     CityId=2,
                     CityName="台北市",
                     CreateAt=new DateTime(2023,9,2),
                     UpdateAt =new DateTime(2023,9,3)
                     },
                   new City {
                     CityId=3,
                     CityName="新北市",
                     CreateAt=new DateTime(2023,9,2),
                     UpdateAt =new DateTime(2023,9,3)
                     },
                     new City {
                     CityId=4,
                     CityName="桃園市",
                     CreateAt=new DateTime(2023,9,2),
                     UpdateAt =new DateTime(2023,9,3)
                     },
                       new City {
                     CityId=5,
                     CityName="新竹市",
                     CreateAt=new DateTime(2023,9,2),
                     UpdateAt =new DateTime(2023,9,3)
                     },
                        new City {
                     CityId=6,
                     CityName="新竹縣",
                     CreateAt=new DateTime(2023,9,2),
                     UpdateAt =new DateTime(2023,9,3)
                     }
            };

        }


        public static List<MembershipCategory> ProduceMembershipCategory()
        {
            return new List<MembershipCategory>()
            {
                new MembershipCategory {
                 MembershipCategoryId=1,
                 MembershipName="月繳/30天",
                 UnitPrice=4200,
                 DiscountPrice=2800,
                 TotalDate=30,
                 CreateAt=new DateTime(2023,9,2)
                 },
                new MembershipCategory {
                 MembershipCategoryId=2,
                 MembershipName="季繳/90天",
                 UnitPrice=9000,
                 DiscountPrice=5200,
                 TotalDate=120,
                 CreateAt=new DateTime(2023,9,2)
                 },
                 new MembershipCategory {
                 MembershipCategoryId=3,
                 MembershipName="年繳/365天",
                 UnitPrice=32000,
                 DiscountPrice=18000,
                 TotalDate=455,
                 CreateAt=new DateTime(2023,9,2)
                 },
            };
        }

        public static List<MembershipOrder> ProduceMembershipOrder()
        {
            return new List<MembershipOrder>()
            {
              new MembershipOrder {
              MembershipOrderId=1,
              MembershipCategoryId=1,
              CompanyId=1,
              UnitPrice=2800,
              OrderAt=new DateTime(2023,9,1),
              DueAt=new DateTime(2023,9,30),
              Online=true
               },
              new MembershipOrder {
              MembershipOrderId=2,
              MembershipCategoryId=2,
              CompanyId=2,
              UnitPrice=5200,
              OrderAt=new DateTime(2023,9,2),
              DueAt=new DateTime(2023,12,1),
              Online=true
                 },
            };
        }

        public static List<BoostOrder> ProduceBoostOrder()
        {
            return new List<BoostOrder>()
            {
              new BoostOrder {
                BoostOrderId=1,
                CompanyId=1,
                Quantity=1,
                Price=1800,
                OrderAt=new DateTime(2023,9,10),
                DueAt=new DateTime(2023,9,7)
                },
                new BoostOrder {
                BoostOrderId=2,
                CompanyId=2,
                Quantity=2,
                Price=3600,
                                Online=false,
                OrderAt=new DateTime(2023,9,10),
                DueAt=new DateTime(2023,9,17)
                 },
            };
        }

        public static List<BoostUsed> ProduceBoostUsed()
        {
            return new List<BoostUsed>()
            {
              new BoostUsed {
              BoostUsedId=1,
              Quantity=1,
              JobDescriptionId=1,
              CompanyId=1,
              UnitPrice=1800,
              UsedAt=new DateTime(2023,9,10),
              },
              new BoostUsed {
              BoostUsedId=2,
              Quantity=1,
              JobDescriptionId=2,
              CompanyId=2,
              UnitPrice=1800,
              UsedAt=new DateTime(2023,9,11),
              },
               new BoostUsed {
              BoostUsedId=3,
              Quantity=1,
              JobDescriptionId=3,
              CompanyId=2,
              UnitPrice=1800,
              UsedAt=new DateTime(2023,9,11),
              },
            };
        }


        //==================================== Zoe 結束====================================

        //==================================== Wei 開始====================================
        //Wei updated at 9/3 17:00
        //職缺1: 陶板屋永和中正店-廚藝助理 https://www.518.com.tw/job-GZB77K.html
        //職缺2: ASP.NET MVC C# 網站後端工程師 https://www.518.com.tw/job-yORrB4.html
        public static List<AddressRelation> ProduceAddressRelation()
        {
            return new List<AddressRelation>()
            {
            new AddressRelation {AddressRelationId=1, AddressId = 1, CompanyId = 1, JobDescriptionId = 1, ResumeId = null },
            new AddressRelation {AddressRelationId=2, AddressId = 2, CompanyId = 2, JobDescriptionId = 2, ResumeId = null },
            new AddressRelation {AddressRelationId=3, AddressId = 3, CompanyId = null, JobDescriptionId = null, ResumeId = 1 },
            new AddressRelation {AddressRelationId=4, AddressId = 4, CompanyId = null, JobDescriptionId = null, ResumeId = 2 },
            };
        }

        public static List<JobDescription> ProduceJobDescription()
        {
            return new List<JobDescription>()
            {
                new JobDescription
                {
                    JobDescriptionId = 1,
                    JobId = "aaa111",
                    CompanyId = 1,
                    JobTitle = "陶板屋永和中正店-廚藝助理",
                    JobDetail = "各項餐點製作、內場相關事務等",
                    SalaryPaymentId = 1,
                    MinSalary = 200,
                    MaxSalary = 250,
                    Address = "新北市永和區中正路179之1號及181號2樓",
                    JobShiftId = 2,
                    WorkingHours = "10:00~14:00 及 16:30~21:30",
                    JobCategoryId = 1,
                    EmploymentCategoryId = 1,
                    IsManager = false,
                    JobTenureId = 1,
                    EducationId = 1,
                    Language = "[{\"英語\":\"false\"},{\"日語\":\"false\"},{\"台語\":\"true\"}]",
                    DrivingLicense = "[{\"汽車\":\"false\"},{\"機車\":\"true\"}]",
                    ComputerSkill = "[{\"HTML\":\"false\"},{\"CSS\":\"false\"},{\"JS\":\"false\"},{\"C#\":\"false\"},{\"SQL\":\"false\"}]",
                    VacancyNumber = 1,
                    ContactName = "李小姐",
                    ContactEmail = "wp_lee@gmail.com",
                    ContactPhone = "0912-345-678",
                    ContactAddress = "新北市永和區中正路179之1號及181號2樓",
                    PostScript = "即日起提供【視訊面試】選項 ，履歷經初審通過後，由專人電話連繫安排面試，讓你在家求職安心防疫。",
                    CreateAt = new DateTime(2023,8,1),
                    UpdateAt = new DateTime(2023,8,11),
                    PostStartAt = new DateTime(2023,8,21),
                    PostEndAt = new DateTime(2023,8,31),
                    BoostEndAt = new DateTime(2023,9,1),
                    IsPosted = true,
                    DisplayOrder = 1,
                },
                new JobDescription
                {
                    JobDescriptionId = 2,
                    JobId = "bbb222",
                    CompanyId =2,
                    JobTitle = "ASP.NET MVC C# 網站後端工程師",
                    JobDetail = "使用 C# 程式語言開發\r\n- 運用 ASP.NET Framework MVC、ASP.NET Core MVC、Web API 架構\r\n- 運用 Dapper、Entity Framework等 ORM 框架\r\n- 採用 TDD、DDD、DI、IoC、分層設計等開發方法論",
                    SalaryPaymentId = 2,
                    MinSalary = 40000,
                    MaxSalary = 70000,
                    Address = "台北市大安區敦化南路二段77號12樓",
                    JobShiftId = 1,
                    WorkingHours = "08:30-18:00",
                    JobCategoryId = 10,
                    EmploymentCategoryId = 1,
                    IsManager = true,
                    JobTenureId = 2,
                    EducationId = 2,
                    Language = "[{\"英語\":\"true\"},{\"日語\":\"false\"},{\"台語\":\"true\"}]",
                    DrivingLicense = "[{\"汽車\":\"false\"},{\"機車\":\"false\"}]",
                    ComputerSkill = "[{\"HTML\":\"true\"},{\"CSS\":\"true\"},{\"JS\":\"true\"},{\"C#\":\"false\"},{\"SQL\":\"true\"}]",
                    VacancyNumber = 2,
                    ContactName = "張先生",
                    ContactEmail = "yc_chang@gmail.com",
                    ContactPhone = "0912-345-678",
                    ContactAddress = "台北市大安區敦化南路二段77號12樓",
                    PostScript = "請直接透過網站上的「我要應徵」進行應徵，可加快處理速度，讓您更快得到回覆。",
                    CreateAt = new DateTime(2023,8,1),
                    UpdateAt = new DateTime(2023,8,11),
                    PostStartAt = new DateTime(2023,8,21),
                    PostEndAt = new DateTime(2023,8,31),
                    BoostEndAt = new DateTime(2023,9,1),
                    IsPosted = true,
                    DisplayOrder = 2,
                },
                new JobDescription
                {
                    JobDescriptionId = 3,
                    JobId = "ccc333",
                    CompanyId = 1,
                    JobTitle = "西堤信義101店-主廚",
                    JobDetail = "各項餐點製作、內場相關事務等",
                    SalaryPaymentId = 1,
                    MinSalary = 200,
                    MaxSalary = 280,
                    Address = "台北市信義區市府路45號",
                    JobShiftId = 2,
                    WorkingHours = "10:00~14:00 及 16:30~21:30",
                    JobCategoryId = 1,
                    EmploymentCategoryId = 1,
                    IsManager = false,
                    JobTenureId = 1,
                    EducationId = 1,
                    Language = "[{\"英語\":\"false\"},{\"日語\":\"false\"},{\"台語\":\"true\"}]",
                    DrivingLicense = "[{\"汽車\":\"false\"},{\"機車\":\"true\"}]",
                    ComputerSkill = "[{\"HTML\":\"false\"},{\"CSS\":\"false\"},{\"JS\":\"false\"},{\"C#\":\"false\"},{\"SQL\":\"false\"}]",
                    VacancyNumber = 1,
                    ContactName = "李小姐",
                    ContactEmail = "wp_lee@gmail.com",
                    ContactPhone = "0912-345-678",
                    ContactAddress = "新北市永和區中正路179之1號及181號2樓",
                    PostScript = "即日起提供【視訊面試】選項 ，履歷經初審通過後，由專人電話連繫安排面試，讓你在家求職安心防疫。",
                    CreateAt = new DateTime(2023,8,1),
                    UpdateAt = new DateTime(2023,8,11),
                    PostStartAt = new DateTime(2023,8,21),
                    PostEndAt = new DateTime(2023,8,31),
                    BoostEndAt = new DateTime(2023,9,1),
                    IsPosted = true,
                    DisplayOrder = 1,
                }
            };
        }

        public static List<JobFeature> ProduceJobFeature()
        {
            return new List<JobFeature>()
            {
            new JobFeature{JobFeatureId=1,JobFeatures="國外駐點工作"},
            new JobFeature{JobFeatureId=2,JobFeatures="彈性上下班"},
            new JobFeature{JobFeatureId=3,JobFeatures="交通津貼"},
            new JobFeature{JobFeatureId=4,JobFeatures="伙食津貼"},
            new JobFeature{JobFeatureId=5,JobFeatures="週休二日"},
            new JobFeature{JobFeatureId=6,JobFeatures="無須輪班"},
            };
        }

        public static List<JobFeaturesRelation> ProduceJobFeaturesRelation()
        {
            return new List<JobFeaturesRelation>()
            {
            new JobFeaturesRelation {JobFeaturesRelationId=1, JobDescriptionId=1, JobFeatureId=2},
            new JobFeaturesRelation {JobFeaturesRelationId=2,JobDescriptionId=1, JobFeatureId=3},
            new JobFeaturesRelation {JobFeaturesRelationId=3,JobDescriptionId=1, JobFeatureId=4},
            new JobFeaturesRelation {JobFeaturesRelationId=4,JobDescriptionId=2, JobFeatureId=1},
            new JobFeaturesRelation {JobFeaturesRelationId=5,JobDescriptionId=2, JobFeatureId=2},
            new JobFeaturesRelation {JobFeaturesRelationId=6,JobDescriptionId=2, JobFeatureId=5},
            new JobFeaturesRelation {JobFeaturesRelationId=7,JobDescriptionId=2, JobFeatureId=6},
            };
        }

        public static List<AddressDetail> ProduceAddressDetail()
        {
            return new List<AddressDetail>()
            {
            new AddressDetail{AddressDetailId=1,Address="新北市永和區中正路179之1號及181號2樓", Latitude=24.99905m, Longitude=121.51681m, DistrictId=1},
            new AddressDetail{AddressDetailId=2,Address="台北市大安區敦化南路二段77號12樓", Latitude=25.03042m, Longitude=121.54925m, DistrictId=2},
            new AddressDetail{AddressDetailId=3,Address="履歷1的地址", Latitude=24.98977m, Longitude=121.51039m, DistrictId=2},
            new AddressDetail{AddressDetailId=4,Address="履歷2的地址", Latitude=24.98977m, Longitude=121.51039m, DistrictId=2},
            };
        }


        //==================================== Wei 結束====================================
        //==================================== Shon 開始====================================
        //Shon updated at 9/3 16:00

        public static List<WorkExperience> ProduceWorkExperience()
        {
            return new List<WorkExperience>()
            {
                new WorkExperience{
                    WorkExperienceId =1,
                    ResumeId = 1,
                    CompanyName="Build School",
                    IndustryCategoryId=2,
                    JobTitle="實習軟體工程師",
                    JobNature=2,
                    JobCategoryId=10,
                    Management=false,
                    TenureStart=new DateTime(2022,02,15),
                    TenureEnd=new DateTime(2023,02,15),
                    CreateAt= new DateTime(2023,04,11),
                    UpdateAt= null

                },
                new WorkExperience{
                    WorkExperienceId =2,
                    ResumeId = 1,
                    CompanyName="全家超商",
                    IndustryCategoryId=3,
                    JobTitle="門市店員",
                    JobNature=3,
                    JobCategoryId=18,
                    Management=true,
                    TenureStart=new DateTime(2022,01,15),
                    TenureEnd=new DateTime(2023,02,10),
                    CreateAt= new DateTime(2023,04,11),
                    UpdateAt= new DateTime(2023,04,13)
                },
                new WorkExperience{
                    WorkExperienceId =3,
                    ResumeId = 3,
                    CompanyName="鼎泰豐Din Tai Fung",
                    IndustryCategoryId=1,
                    JobTitle="餐廳外場人員",
                    JobNature=1,
                    JobCategoryId=2,
                    Management=false,
                    TenureStart=new DateTime(2022,06,15),
                    TenureEnd=new DateTime(2022,09,15),
                    CreateAt= new DateTime(2023,06,25),
                    UpdateAt= null
                }
            };
        }

        public static List<Resume> ProduceResume()
        {
            return new List<Resume>()
            {
                new Resume{
                    ResumeId =1,
                    CandidateId =1,
                    ResumeName = "我的履歷",
                    Age=28,
                    EmploymentCategoryId=1,
                    Address="台北市大安區",
                    GraduationSchool="國立臺北科技大學",
                    MajorIn="資訊工程系",
                    EducationId=2,
                    Autobiography="我是國立臺北科技大學資訊工程系的學生。我充滿活力，精通英語和台語，並擅長HTML、JS和CSS。我的熱情和專業知識準備好為您的團隊貢獻。我期待著與您共同創造成功的未來！",
                    Language="[{\"英語\":\"true\"},{\"日語\":\"false\"},{\"台語\":\"true\"}]",
                    DrivingLicense="[{\"汽車\":\"true\"},{\"機車\":\"true\"}]",
                    ComputerSkill="[{\"HTML\":\"true\"},{\"CSS\":\"true\"},{\"JS\":\"true\"},{\"C#\":\"false\"},{\"SQL\":\"false\"}]",
                    CreateAt= new DateTime(2023,04,03),
                    UpdateAt= new DateTime(2023,04,22),
                    OpenOrClosed=true,
                    Rank=1
                },
                new Resume{
                    ResumeId =2,
                    CandidateId =1,
                    ResumeName = "備用履歷",
                    Age=28,
                    EmploymentCategoryId=1,
                    Address="台北市大安區",
                    GraduationSchool="國立臺北科技大學",
                    MajorIn="資訊工程系",
                    EducationId=2,
                    Autobiography="我是一位資訊工程系的學生，充滿求知慾望。除了流利的英語和台語，我還擁有軟體工程師實習的經驗，以及在超商當店員的實際工作經驗。這些經驗讓我具備團隊合作、問題解決和溝通技能。我期待在您的團隊中貢獻我的多元背景和積極態度。",
                    Language="[{\"英語\":\"true\"},{\"日語\":\"false\"},{\"台語\":\"true\"}]",
                    DrivingLicense="[{\"汽車\":\"true\"},{\"機車\":\"true\"}]",
                    ComputerSkill="[{\"HTML\":\"true\"},{\"CSS\":\"true\"},{\"JS\":\"true\"},{\"C#\":\"false\"},{\"SQL\":\"false\"}]",
                    CreateAt= new DateTime(2023,04,03),
                    UpdateAt= new DateTime(2023,04,22),
                    OpenOrClosed=false,
                    Rank=2
                },
                new Resume{
                    ResumeId =3,
                    CandidateId =2,
                    ResumeName = "我的履歷",
                    Age=35,
                    EmploymentCategoryId=2,
                    Address="新北市新店區",
                    GraduationSchool="國立臺灣大學",
                    MajorIn="外國語文學系",
                    EducationId=2,
                    Autobiography="我是國立臺灣大學外國語文學系的學生，熟練英語、日語，並精通JS、C#和SQL。我充滿熱情，渴望為您的團隊帶來價值，一同追求卓越。期待與您攜手實現成功！",
                    Language="[{\"英語\":\"true\"},{\"日語\":\"true\"},{\"台語\":\"false\"}]",
                    DrivingLicense="[{\"汽車\":\"false\"},{\"機車\":\"true\"}]",
                    ComputerSkill="[{\"HTML\":\"false\"},{\"CSS\":\"false\"},{\"JS\":\"true\"},{\"C#\":\"true\"},{\"SQL\":\"true\"}]",
                    CreateAt= new DateTime(2023,06,03),
                    UpdateAt= new DateTime(2023,06,30),
                    OpenOrClosed=true,
                    Rank=1
                }


            };
        }

        public static List<WorkExpSnapshot> ProduceWorkExpSnapshot()
        {
            return new List<WorkExpSnapshot>()
            {
                new WorkExpSnapshot{
                    WorkExpSnapshotId = 1,
                    ResumeSnapshotId = 1,
                    CompanyName="Build School",
                    IndustryCategoryId=2,
                    JobTitle="實習軟體工程師",
                    JobNature=2,
                    JobCategoryId=10,
                    Management=false,
                    TenureStart=new DateTime(2022,02,15),
                    TenureEnd=new DateTime(2023,02,15)

                },
                new WorkExpSnapshot{
                    WorkExpSnapshotId = 2,
                    ResumeSnapshotId = 1,
                    CompanyName="全家超商",
                    IndustryCategoryId=3,
                    JobTitle="門市店員",
                    JobNature=3,
                    JobCategoryId=18,
                    Management=true,
                    TenureStart=new DateTime(2022,01,15),
                    TenureEnd=new DateTime(2023,02,10)
                },
                new WorkExpSnapshot{
                    WorkExpSnapshotId = 3,
                    ResumeSnapshotId = 2,
                    CompanyName="鼎泰豐Din Tai Fung",
                    IndustryCategoryId=1,
                    JobTitle="餐廳外場人員",
                    JobNature=1,
                    JobCategoryId=2,
                    Management=false,
                    TenureStart=new DateTime(2022,06,15),
                    TenureEnd=new DateTime(2022,09,15)

                }
            };
        }

        public static List<ResumeSnapshot> ProduceResumeSnapshot()
        {
            return new List<ResumeSnapshot>()
            {
                new ResumeSnapshot{
                    ResumeSnapshotId =1,
                    ApplicationRecordId=1,
                    Name="王瑪莉",
                    Gender=2,
                    Age=28,
                    EmploymentCategoryId=1,
                    Address="台北市大安區",
                    GraduationSchool="國立臺北科技大學",
                    MajorIn="資訊工程系",
                    EducationId=2,
                    PhotoUrl="Candidate-0001.png",
                    Autobiography="我是國立臺北科技大學資訊工程系的學生。我充滿活力，精通英語和台語，並擅長HTML、JS和CSS。我的熱情和專業知識準備好為您的團隊貢獻。我期待著與您共同創造成功的未來！",
                    Language="[{\"英語\":\"true\"},{\"日語\":\"false\"},{\"台語\":\"true\"}]",
                    DrivingLicense="[{\"汽車\":\"true\"},{\"機車\":\"true\"}]",
                    ComputerSkill="[{\"HTML\":\"true\"},{\"CSS\":\"true\"},{\"JS\":\"true\"},{\"C#\":\"false\"},{\"SQL\":\"false\"}]"

                },
                new ResumeSnapshot{
                    ResumeSnapshotId =2,
                    ApplicationRecordId=2,
                    Name="黃小明",
                    Gender=1,
                    Age=35,
                    EmploymentCategoryId=2,
                    Address="新北市新店區",
                    GraduationSchool="國立臺灣大學",
                    MajorIn="外國語文學系",
                    EducationId=2,
                    PhotoUrl="Candidate-0002.jpg",
                    Autobiography="我是國立臺灣大學外國語文學系的學生，熟練英語、日語，並精通JS、C#和SQL。我充滿熱情，渴望為您的團隊帶來價值，一同追求卓越。期待與您攜手實現成功！",
                    Language="[{\"英語\":\"true\"},{\"日語\":\"true\"},{\"台語\":\"false\"}]",
                    DrivingLicense="[{\"汽車\":\"false\"},{\"機車\":\"true\"}]",
                    ComputerSkill="[{\"HTML\":\"false\"},{\"CSS\":\"false\"},{\"JS\":\"true\"},{\"C#\":\"true\"},{\"SQL\":\"true\"}]"

                },
                new ResumeSnapshot{
                    ResumeSnapshotId =3,
                    ApplicationRecordId=3,
                    Name="黃小明",
                    Gender=1,
                    Age=35,
                    EmploymentCategoryId=2,
                    Address="新北市新店區",
                    GraduationSchool="國立臺灣大學",
                    MajorIn="外國語文學系",
                    EducationId=2,
                    PhotoUrl="Candidate-0002.jpg",
                    Autobiography="我是國立臺灣大學外國語文學系的學生，熟練英語、日語，並精通JS、C#和SQL。我充滿熱情，渴望為您的團隊帶來價值，一同追求卓越。期待與您攜手實現成功！",
                    Language="[{\"英語\":\"true\"},{\"日語\":\"true\"},{\"台語\":\"false\"}]",
                    DrivingLicense="[{\"汽車\":\"false\"},{\"機車\":\"true\"}]",
                    ComputerSkill="[{\"HTML\":\"false\"},{\"CSS\":\"false\"},{\"JS\":\"true\"},{\"C#\":\"true\"},{\"SQL\":\"true\"}]"

                }
            };
        }


        //==================================== Shon 結束====================================


        //==================================== PonPon 開始====================================
        //PonPon updated at 9/3 15:56

        public static List<CompanyFeatureRelation> ProduceCompanyFeatureRelation()
        {
            return new List<CompanyFeatureRelation>()
            {
                new CompanyFeatureRelation
                {
                    CompanyFeatureRelationId = 1,
                    CompanyId = 1,
                    CompanyFeatureCategoryId=1,
                   CreateAt=new DateTime(2023,9,3),
                    UpdateAt= new DateTime(2023,9,3)
                },
                  new CompanyFeatureRelation
                {
                    CompanyFeatureRelationId = 2,
                    CompanyId = 2,
                    CompanyFeatureCategoryId=2,
                    CreateAt=new DateTime(2023,9,3),
                    UpdateAt= new DateTime(2023,9,3)
                }

            };

        }

        public static List<CompanyFeatureCategory> ProduceCompanyFeatureCategory()
        {
            return new List<CompanyFeatureCategory>()
            {
                new CompanyFeatureCategory
                {
                    CompanyFeatureCategoryId = 1,
                    CompanyFeatureCategoryName= "上市櫃公司",
                    CreateAt=new DateTime(2023,9,3),
                    UpdateAt= new DateTime(2023,9,3)
                },
                 new CompanyFeatureCategory
                {
                    CompanyFeatureCategoryId = 2,
                    CompanyFeatureCategoryName= "外商公司",
                    CreateAt=new DateTime(2023,9,3),
                    UpdateAt= new DateTime(2023,9,3)
                },
                 new CompanyFeatureCategory
                {
                    CompanyFeatureCategoryId = 3,
                    CompanyFeatureCategoryName= "進修補助",
                    CreateAt=new DateTime(2023,9,3),
                    UpdateAt= new DateTime(2023,9,3)
                },
                 new CompanyFeatureCategory
                {
                    CompanyFeatureCategoryId = 4,
                    CompanyFeatureCategoryName= "員購優惠",
                    CreateAt=new DateTime(2023,9,3),
                    UpdateAt= new DateTime(2023,9,3)
                },

            };

        }

        public static List<EnvironmentPic> ProduceEnvironmentPic()
        {
            return new List<EnvironmentPic>()
            {
                new EnvironmentPic
                {
                    EnvironmentPicId = 1,
                    CompanyId=2,
                    EnvironmentPicPath="house_environPic_1.jpg",
                    CreateAt=new DateTime(2023,9,3),
                    UpdateAt= new DateTime(2023,9,3)

                },
                 new EnvironmentPic
                {
                    EnvironmentPicId = 2,
                    CompanyId=2,
                    EnvironmentPicPath="house_environPic_2.jpg",
                    CreateAt=new DateTime(2023,9,3),
                    UpdateAt= new DateTime(2023,9,3)

                },
                 new EnvironmentPic
                {
                    EnvironmentPicId = 3,
                    CompanyId=2,
                    EnvironmentPicPath="house_environPic_3.jpg",
                    CreateAt=new DateTime(2023,9,3),
                    UpdateAt= new DateTime(2023,9,3)

                },

            };
        }

        public static List<WorkShare> ProduceWorkShare()
        {
            return new List<WorkShare>()
            {
                new WorkShare
                {
                    WorkShareId=1,
                    CompanyId=1,
                    CandidateId=1,
                    Evaluation=5,
                    ShareContent="有尾牙，不定期員工訓練，公司團結合作力很強",
                    JobCategoryId=1,
                    CreateAt=new DateTime(2023,9,3),
                    UpdateAt= new DateTime(2023,9,3)
                },
                 new WorkShare
                {
                    WorkShareId=2,
                    CompanyId=1,
                    CandidateId=1,
                    Evaluation=4,
                    ShareContent="公司福利多，同事大家都和樂融融",
                    JobCategoryId=1,
                    CreateAt=new DateTime(2023,9,3),
                    UpdateAt= new DateTime(2023,9,3)
                },
                 new WorkShare
                {
                    WorkShareId=3,
                    CompanyId=2,
                    CandidateId=1,
                    Evaluation=4,
                    ShareContent="三節獎金,年終獎金，品牌大，客戶優先指名，公司誠信好，同事好相處，主管親切，公司地點好，網路行銷好，員工福利好，分紅福利高，未來一片光明",
                    JobCategoryId=1,
                    CreateAt=new DateTime(2023,9,3),
                    UpdateAt= new DateTime(2023,9,3)
                },
                   new WorkShare
                {
                    WorkShareId=4,
                    CompanyId=2,
                    CandidateId=1,
                    Evaluation=4,
                    ShareContent="對於社會新鮮人給的底薪算高(50000)，學長學弟制讓新人不用擔心，學長姐直接一對一指導外加帶你出去拜訪客戶，但是抗壓性要夠強明",
                    JobCategoryId=1,
                    CreateAt=new DateTime(2023,9,3),
                    UpdateAt= new DateTime(2023,9,3)
                },

            };
        }

        public static List<CompanyProfile> ProduceCompanyProfile()
        {
            return new List<CompanyProfile>()
            {
                 new CompanyProfile
                {
                    CompanyId = 1,
                    StaffQuantity = 9000,
                    IndustryCategoryId=1,
                    PersonnelContact= "黃小姐",
                    Fax= "暫不提供",
                    CompanySite= "http://www.wowprime.com/",
                    Address= "台中市西區台灣大道2段218號29樓",
                    Introduction= "王品集團成立於1993年，全球總店數已超過400家，餐廳經營發展跨足不同類型，包括西式、日式、中式、火鍋、燒肉等領域，致力於多品牌經營與服務創新，不斷精進與突破，躍居台灣第一大餐飲集團，成為同業標竿，被譽為餐飲業經營的典範。<br />\r\n<br />\r\n王品集團多年的努力和表現，受到許多獎項的肯定，於國際廚藝競賽中獲獎超過50座，屢獲天下雜誌、遠見雜誌服務業大調查評選第一名，並榮獲台灣經濟部頒發優良品牌獎。<br />\r\n<br />\r\n王品集團擁有優質的企業文化與連鎖餐飲管理制度，歡迎有志從事餐飲業的伙伴加入，與我們一起實現偉大願景，傳遞餐桌上的美味關係，成為最具影響力的餐飲集團。<br />\r\n<br />\r\n<br />\r\n【反詐騙聲明】<br />\r\n提醒您，本網站僅提供應徵服務，履歷來源由求職者主動應徵或系統配對，不會要求您在面試前提供其他個人資料，履歷資料僅限王品集團台灣關係企業使用；面試地點將會安排在總部、各門店、公立就業服務機構或其他公共場地。若接獲冒用王品集團之名義要求提供個人資料或至可疑地點面試等，請來信至hr@wowprime.com&nbsp;或客服信箱service@wowprime.com，或與警政署「反詐騙諮詢專線165」查詢，謝謝。<br />\r\n<br />\r\n經營理念<br />\r\n1.【顧客是恩人】：以「熱忱」的心『款待』顧客。　<br />\r\n2.【同仁是家人】：以「關懷」的心『了解』同仁。　<br />\r\n3.【廠商是貴人】：以「尊重」的心『面對』廠商。</div>",
                    ProductContent= "【台灣事業群】<br />\r\n王品牛排：www.wangsteak.com.tw<br />\r\nTASTy西堤牛排：www.tasty.com.tw<br />\r\n陶板屋和風創作料理：www.tokiya.com.tw<br />\r\n原燒優質原味燒肉：www.yakiyan.com<br />\r\n聚北海道昆布鍋：www.giguo.com.tw<br />\r\n藝奇新日本料理：www.ikki.com.tw<br />\r\n夏慕尼新香榭鉄板燒：www.chamonix.com.tw<br />\r\n品田牧場日式豬排咖哩：www.pinnada.com.tw<br />\r\n石二鍋&nbsp;石頭鍋.涮涮鍋：www.12hotpot.com.tw<br />\r\nhot&nbsp;7新鉄板料理：www.hot-7.com<br />\r\nPUTIEN&nbsp;莆田-新加坡最佳亞洲餐廳：www.putien.com.tw<br />\r\n青花驕&nbsp;麻辣鍋：www.chinhuajiao.com<br />\r\n享鴨&nbsp;烤鴨與中華料理：www.xiangduck.com.tw<br />\r\n丰禾台式小館：www.veggtable.com<br />",
                    Gift="三節禮物",
                    Insurance="健保,勞保",
                    WelfareDesc="【薪滿意足】&nbsp;<br />\r\n月月有感-具競爭力的薪資、全勤獎金、績效獎金、每月晉升機會、管理津貼、技能津貼*、外語津貼*、夜間津貼*<br />\r\n年年滿足-每年2次績效調薪機會、年終獎金(視營運狀況發放)<br />\r\n不定期-內部推薦獎勵*&nbsp;<br />\r\n<br />\r\n【安心保障】&nbsp;<br />\r\n法定保障-勞保、健保、勞退提撥&nbsp;<br />\r\n公司保障-團保、定期健康檢查&nbsp;<br />\r\n貼心保障-結婚及生育禮金、孕婦友善工作環境、同仁重大傷病慰問金*&nbsp;<br />\r\n<br />\r\n【專屬為你】&nbsp;<br />\r\n即享樂-同仁及家人用餐八折優惠、上班免費供餐*&nbsp;<br />\r\n獨享樂-正職加碼放鬆假&nbsp;每年多4天!&nbsp;三節禮券、生日祝福餐、同仁及同仁子女教育獎學金*<br />\r\n眾享樂-國外旅遊補助、尾牙活動、不定期歡聚活動、除夕公休*&nbsp;<br />\r\n<br />\r\n【實力升級】&nbsp;<br />\r\n系統化培訓課程-集團訓練、事業處訓練、門店訓練<br />\r\n線上學習平台-王品wow!學院<br />\r\n其它-專業證照/執照輔導、外部教育訓練費用補助*、鼓勵在職進修<br />\r\n<br />\r\n【同仁國內外旅遊足跡】&nbsp;<br />\r\n2016-&nbsp;關島、西班牙&nbsp;<br />\r\n2017-&nbsp;首爾、大阪、北歐四國<br />\r\n2018-&nbsp;新加坡、四國、克羅埃西亞<br />\r\n2019-&nbsp;泰國、九州、土耳其<br />\r\n2020-&nbsp;宜蘭龜山島、花蓮太魯閣、台南墾丁、金門<br />\r\n2021-&nbsp;阿里山、小琉球<br />\r\n2022-&nbsp;環島、澎湖、台東<br />\r\n2023-&nbsp;馬來西亞、日本關西、土耳其<br />\r\n<br />\r\n【新鐵人養成計畫】&nbsp;<br />\r\n初級養成-日行萬步好健康&nbsp;<br />\r\n進階挑戰-鐵騎貫寶島、泳渡日月潭、半程馬拉松、登玉山&nbsp;<br />\r\n超級挑戰-聖母峰基地營登山活動(EBC)&nbsp;<br />\r\n<br />\r\n【計時人員&nbsp;享福又給利】&nbsp;<br />\r\n認真享全勤&nbsp;-&nbsp;達出勤標準即享津貼1,000元起&nbsp;<br />\r\n快樂享津貼&nbsp;-&nbsp;國定假日出勤雙薪&nbsp;<br />\r\n安心享休假&nbsp;-&nbsp;法定給薪休假(特休假等….)&nbsp;<br />\r\n一起享獎金&nbsp;–&nbsp;每月績效獎金、年終獎金(視營運狀況發放)<br />\r\n相聚享歡樂&nbsp;-&nbsp;國外旅遊補助、不定期歡聚活動、尾牙活動<br />\r\n<br />\r\n&nbsp;(*)星號表示依各事業處規定;上述福利(含國內外旅遊)等視整體營運或環境狀況公司保留調整權利。",
                    CreateAt=new DateTime(2023,9,3),
                    UpdateAt= new DateTime(2023,9,3)
                },
                 new CompanyProfile
                 {
                    CompanyId = 2,
                    StaffQuantity = 3000,
                    IndustryCategoryId=1,
                    PersonnelContact= "鄭小姐",
                    Fax= "暫不提供",
                    CompanySite= "https://www.yungching.tw/",
                    Address= "台北市大安區敦化南路二段77號12樓",
                    Introduction= "【永慶房產集團五大第一】<br />\r\n■全台第一大房仲集團，全台店數突破1600家<br />\r\n房仲第一品牌&nbsp;-&nbsp;永慶房產集團於1988年正式成立，迄今已超過30年，一路走來，不斷致力於推動交易安全及發展e化服務系統與工具，滿足消費者安心購售屋及提升交易效率的基本需求，並積極整合集團資源，拓展市場規模，除提供客戶各項不動產仲介及諮詢的全方位服務外，更建構全國龐大且綿密的門市通路網絡，將永慶的服務深入社區、扎根基層。集團旗下共有直營品牌永慶房屋，及四個加盟品牌：永慶不動產、永義房屋、有巢氏房屋、台慶不動產等五個品牌，集團全台店數突破1600店，是台灣最大的房產集團。<br />\r\n<br />\r\n■第一位推動「新式仲介」的領航者<br />\r\n孫慶餘董事長從美日引進「新式仲介」主張不賺差價，只收取固定服務費，改變房仲的格局與遊戲規則；創立台灣第一個房仲加盟平台：大台北不動產仲介聯盟(現住商不動產的前身)&nbsp;，推動產業進入「房仲1.0-新式仲介時代」。後成立永慶房屋，投入十年推動《不動產仲介經紀業管理條例》立法通過，並不斷創新服務推動產業升級，帶領產業進入「房仲2.0-法制仲介時代」。<br />\r\n<br />\r\n■第一家獲頒「地政貢獻獎」的業者<br />\r\n在孫董事長的帶領下，永慶房產集團以「先誠實再成交」的核心理念，以提供消費者一個「公平的房產交易平台」為己任。為了落實對消費者的承諾，永慶房屋在不僅在2007年時率先於永慶房仲網上率先公開成交行情，並主動提供成交資訊給政府，因此促成「實價登錄1.0」於2012年立法成功。孫慶餘董事長也在2014年，因協助推動《不動產經紀業管理條例》立法、主動提供成交資訊，讓實價登錄政策順利實施、推動新式仲介、法制仲介到科技仲介，引領產業進步，成為台灣第一位獲得地政貢獻獎的房仲業者。<br />\r\n<br />\r\n■第一家揭露成交行情至門牌的業者<br />\r\n2019年「實價登錄2.0」於立法院闖關失敗，永慶房屋領先政府及同業，率先推「實價登錄3.0－成交行情揭露至門牌」，並陸續推至集團下所有房仲品牌，深獲各界認同。永慶房屋2020年8月，永慶房屋再推「兩大誠實房價保證」，承諾若未能落實提供成交行情揭露至門牌，造成客戶損失，永慶房屋將做出賠償，此創舉贏得客戶讚賞更震撼業界。<br />\r\n<br />\r\n■唯一提供消費者買賣屋「全保障」<br />\r\n2021年9月，永慶房屋再創買賣屋保障新標竿！重磅推出「真房價保證」服務，保證不炒房不賺差價，若未落實最高將賠償買方400萬元；賠償賣方最高四倍服務費，用實際的行動和服務，展現「房仲第一品牌」保障消費者權益的決心，以落實孫慶餘董事長為消費者打造公平房產交易平台的承諾，推升產業進入「房仲3.0-誠實仲介時代」。",
                    ProductContent= "■營運版圖橫跨房產、仲介、網路,服務一次到位,職涯發展空間更寬廣<br />\r\n<br />\r\n永慶房產事業集團橫跨三大事業群及永慶慈善基金會,提供客戶房地產上中下游的完整服務,集團內完善的升遷制度,則讓每一個永慶的同仁,都可依自己的興趣、專長,擁有更寬闊的一片天。<br />\r\n<br />\r\n【直營事業體】(永慶房屋、首席顧問團隊、永慶豪宅、永慶店面)<br />\r\n-不動產買賣仲介服務<br />\r\n-不動產租賃仲介服務<br />\r\n-不動產處理顧問諮詢服務<br />\r\n<br />\r\n【加盟事業體】(永慶不動產、有巢氏房屋、台慶不動產、永義房屋)<br />\r\n-加盟品牌授權、營運輔導<br />\r\n<br />\r\n【代銷事業體】(永慶代銷)<br />\r\n-預售屋推案、企劃銷售、餘屋銷售及現場管理業務<br />\r\n<br />\r\n【建設事業體】(永慶建設)<br />\r\n-土地開發、都市更新、建築管理等業務<br />\r\n<br />\r\n【交安事業體】(永慶代書)<br />\r\n-產權審查<br />\r\n-代書服務(簽約簽訂、成交過戶、銀行貸款設定、節稅規劃)<br />\r\n-不動產交易簽證及契約鑑證<br />\r\n-不動產徵信及評估<br />\r\n-不動產買賣履約保證<br />\r\n<br />\r\n【網路事業體】(永慶房仲網)&nbsp;<br />\r\n-提供房產物件、居家裝潢、修繕服務搜尋&nbsp;<br />\r\n-提供物件成交行情,涵蓋全台各縣市、行政區到社區大樓等<br />\r\n<br />\r\n【永慶慈善基金會】<br />\r\n-推廣全齡通用住宅,倡導通用生活、居住平權<br />\r\n-推動無障礙觀念,照顧身心障礙者<br />\r\n-扶助社會弱勢人口,協助改善生活現況<br />\r\n-喚醒大眾對弱勢之重視,爭取必要的社會資源<br />\r\n-發揮人間的溫暖情誼,創造盡善盡美的生活環境",
                    Gift="三節禮物",
                    Insurance="健保,勞保",
                    WelfareDesc="■&nbsp;兼顧工作與生活的真幸福，在永慶房屋找到幸福的新定義<br />\r\n<br />\r\n「有幸福的員工，才有滿意的客戶！」<br />\r\n除了對消費者的服務，更持續「致力打造友善職場」，透過學長姐輔導、師徒達人制度，建立團隊合作共享的職場文化；善用創新科技及企業優勢，成功推動彈性工作8小時制度，讓員工能夠工作與生活平衡；有感的薪獎福利，提供業界最優保障前12個月每月5萬元收入、每人每年最高250萬「幸福成家基金」；以能力為導向的月月晉升制度，成為房仲業唯一連續六年獲得HR&nbsp;Asia「亞洲最佳企業雇主獎」肯定(<a style=\"display: inline;\" href=\"https://house.udn.com/house/story/11067/7311723\" rel=\"ugc nofollow\" target=\"_blank\">https://house.udn.com/house/story/11067/7311723</a>)&nbsp;，同時，更連續11年獲得「台灣服務業大評鑑」連鎖服務業金獎的肯定。<br />\r\n<br />\r\n《永慶，真的不一樣》<br />\r\n聰明工作，高效率、完善培訓<br />\r\n經紀人員彈性工作8小時、搭配遊戲化制度，工作高效率。<br />\r\nI&nbsp;pad行動服務工具，協助經紀人員快速上手、即時提供房產服務。<br />\r\n完整教育訓練，另更補助指派受訓及經核准之內外訓課程。<br />\r\n輔導考取不動產經紀人國家證照。<br />\r\n慰勞員工之年終獎金，依公司營運狀況及年資、職級及個人表現之不同提供。<br />\r\n行政績優同仁可獲頒考核獎金及獎牌、獎座。<br />\r\n經紀人員除薪資及業績獎金外，公司定期舉辦激勵活動獎勵，提供高額獎金。<br />\r\n<br />\r\n【健康生活，打造幸福職場】<br />\r\n-提供經紀人員最高250萬元的購屋基金，圓三年購屋夢。<br />\r\n-海內外獎勵旅遊，生活更多采。&nbsp;<br />\r\n-免費紓壓按摩，員工好放鬆。<br />\r\n-生日津貼、三節禮金/禮券，員工好窩心。<br />\r\n<br />\r\n【團隊合作，打造歸屬感】<br />\r\n-專屬學長學姊制，帶領新人上手。<br />\r\n-首創聯賣系統，同仁互相幫忙不藏私。<br />\r\n-團隊合作創高績效，經紀人除可獲得個人業績獎金，還可分配團體獎金。<br />\r\n-多元社團活動，如籃球賽、壘球賽、羽球賽，紓解工作壓力。<br />\r\n-員工休息室與聯誼廳，平日紓壓打氣，互相交流情感。<br />\r\n<br />\r\n【成家到安家，幸福百分百】<br />\r\n-舉辦大型尾牙，及免費返鄉專車。<br />\r\n-鼓勵班對，在永慶一圓成功及成家的夢想。<br />\r\n-提供經紀人員租屋補助、購置機車、ipad之無息貸款，打拼更安心。<br />\r\n-導入EAP員工協助方案，舉辦「幸福講座」，分享交流生活點滴。<br />\r\n-提供勞保、健保及團保(意外傷害、住院醫療及意外險)多重的保障。",
                    CreateAt=new DateTime(2023,9,3),
                    UpdateAt= new DateTime(2023,9,3)
                 }

            };


        }

        //==================================== PonPon 結束====================================

        //==================================== Gina 開始====================================
        //Gina updated at 9/3 20:12
        public static List<ChatMessage> ProduceChatMessage()
        {
            return new List<ChatMessage>()
            {
                 new ChatMessage
                {
                    MessageId = 1,
                    //JobId = "aaa111",
                    CreateAt = new DateTime(2023,9,3),
                    MessageContent = "請問職缺的詳細工作內容有哪些?",
                    CompanyId = 1,
                    CandidateId = 1,
                    JobDescriptionId = 1,
                    SenderAccount = true,
                    ReadStatus = true
                },
                 new ChatMessage
                {
                    MessageId = 2,
                    //JobId = "bbb222",
                    CreateAt = new DateTime(2023,9,3),
                    MessageContent = "請問是否對本公司職缺有興趣?",
                    CompanyId = 2,
                    CandidateId = 2,
                    JobDescriptionId = 2,
                    SenderAccount = false,
                    ReadStatus = false
                }
            };
        }
        public static List<CollectionCompany> ProduceCollectionCompany()
        {
            return new List<CollectionCompany>()
            {
                 new CollectionCompany
                {
                    CollectionCompanyId = 1,
                    CandidateId = 1,
                    CreateAt = new DateTime(2023,9,3),
                    CompanyId = 1,
                },
                 new CollectionCompany
                {
                    CollectionCompanyId = 2,
                    CandidateId = 2,
                    CreateAt = new DateTime(2023,9,3),
                    CompanyId = 2,
                }
            };
        }
        public static List<CollectionJob> ProduceCollectionJob()
        {
            return new List<CollectionJob>()
            {
                 new CollectionJob
                {
                    CollectionJobId = 1,
                    CandidateId = 1,
                    CreateAt = new DateTime(2023,9,3),
                    JobDescriptionId = 1,
                },
                 new CollectionJob
                {
                    CollectionJobId =2,
                    CandidateId = 2,
                    CreateAt = new DateTime(2023,9,3),
                    JobDescriptionId = 2,
                }
            };
        }

        //==================================== Gina 結束====================================



    }//==========SeedData結束


}

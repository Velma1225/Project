using System.Collections.Generic;
using System.Net;
using System.Reflection;
using System.Xml;
using ApplicationCore.Entities;
using HabanMVC.ViewModels.Candidate;
using Microsoft.AspNetCore.Http.HttpResults;

namespace HabanMVC.Services
{
    public class CandidateService
    {
        //private readonly CandidateRepository _memberFavoriteJobsRepository;
        //public CandidateService(CandidateRepository memberFavoriteJobsRepository)
        //{
        //    _memberFavoriteJobsRepository = memberFavoriteJobsRepository;
        //}

        public CandidateIndexViewModel GetAllCandidate()
        {
            CandidateIndexViewModel results = new CandidateIndexViewModel()
            {
                JobSliderViewModel = new List<JobSliderViewModel>
                {
                        new JobSliderViewModel()
                    {
                    Id = 1,
                    JobName = "(Fake).net工程師[全台最大辦公用品供應商]",
                    Company = "(Fake)BuildSchool股份有限公司",
                    CreationDate = new DateTime(2023, 9, 10, 13, 3, 54)
                    },
                        new JobSliderViewModel()
                    {
                    Id = 2,
                    JobName = "(Fake)ASP.NET C#程式設計師(新鮮人可)",
                    Company = "(Fake)BuildSchool股份有限公司",
                    CreationDate = new DateTime(2023, 8, 31, 11, 14, 12)
                    },
                        new JobSliderViewModel()
                    {
                    Id = 3,
                    JobName = "(Fake)C# winform 工程師",
                    Company = "(Fake)BuildSchool股份有限公司",
                    CreationDate = new DateTime(2023, 8, 31, 10, 21, 35)
                    },
                        new JobSliderViewModel()
                    {
                    Id = 4,
                    JobName = "(Fake).Net C# Web.Net C# Web",
                    Company = "(Fake)BuildSchool股份有限公司",
                    CreationDate = new DateTime(2023, 8, 31, 8, 23, 59)
                    },
                    new JobSliderViewModel()
                    {
                    Id = 5,
                    JobName = "(Fake).Net C# Web.Net C# Web",
                    Company = "(Fake)BuildSchool股份有限公司",
                    CreationDate = new DateTime(2023, 8, 31, 8, 23, 59)
                    }
                },

                ApplicationRecordViewModel = new List<ApplicationRecordViewModel>
                {
                    new ApplicationRecordViewModel()
                    {
                    CompanyName = "(Fake)BuildSchool股份有限公司",
                    AppliedPosition = "(Fake).Net C# Web.Net C# Web",
                    ReadStatus = "(Fake)已讀取",
                    Resume = "(Fake)我的履歷1",
                    CreationDate =  new DateTime(2023, 9, 10, 13, 3, 54),
                    ResponseDate = new DateTime(2023, 9, 10, 13, 3, 54)
                    },

                    new ApplicationRecordViewModel()
                    {
                    CompanyName = "(Fake)BuildSchool股份有限公司",
                    AppliedPosition = "(Fake).Net C# Web.Net C# Web",
                    Resume = "(Fake)我的履歷1",
                    ReadStatus = "(Fake)已讀取",
                    CreationDate =  new DateTime(2023, 9, 10, 13, 3, 54),
                    ResponseDate = new DateTime(2023, 9, 10, 13, 3, 54)
                    },
                                        new ApplicationRecordViewModel()
                    {
                    CompanyName = "(Fake)BuildSchool股份有限公司",
                    AppliedPosition = "(Fake).Net C# Web.Net C# Web",
                    ReadStatus = "(Fake)已讀取",
                    Resume = "(Fake)我的履歷1",
                    CreationDate =  new DateTime(2023, 9, 10, 13, 3, 54),
                    ResponseDate = new DateTime(2023, 9, 10, 13, 3, 54)
                    },

                    new ApplicationRecordViewModel()
                    {
                    CompanyName = "(Fake)BuildSchool股份有限公司",
                    AppliedPosition = "(Fake).Net C# Web.Net C# Web",
                    Resume = "(Fake)我的履歷1",
                    ReadStatus = "(Fake)已讀取",
                    CreationDate =  new DateTime(2023, 9, 10, 13, 3, 54),
                    ResponseDate = new DateTime(2023, 9, 10, 13, 3, 54)
                    },
                                        new ApplicationRecordViewModel()
                    {
                    CompanyName = "(Fake)BuildSchool股份有限公司",
                    AppliedPosition = "(Fake).Net C# Web.Net C# Web",
                    ReadStatus = "(Fake)已讀取",
                    Resume = "(Fake)我的履歷1",
                    CreationDate =  new DateTime(2023, 9, 10, 13, 3, 54),
                    ResponseDate = new DateTime(2023, 9, 10, 13, 3, 54)
                    },

                    new ApplicationRecordViewModel()
                    {
                    CompanyName = "(Fake)BuildSchool股份有限公司",
                    AppliedPosition = "(Fake).Net C# Web.Net C# Web",
                    Resume = "(Fake)我的履歷1",
                    ReadStatus = "(Fake)已讀取",
                    CreationDate =  new DateTime(2023, 9, 10, 13, 3, 54),
                    ResponseDate = new DateTime(2023, 9, 10, 13, 3, 54)
                    },
                                        new ApplicationRecordViewModel()
                    {
                    CompanyName = "(Fake)BuildSchool股份有限公司",
                    AppliedPosition = "(Fake).Net C# Web.Net C# Web",
                    ReadStatus = "(Fake)已讀取",
                    Resume = "(Fake)我的履歷1",
                    CreationDate =  new DateTime(2023, 9, 10, 13, 3, 54),
                    ResponseDate = new DateTime(2023, 9, 10, 13, 3, 54)
                    },

                    new ApplicationRecordViewModel()
                    {
                    CompanyName = "(Fake)BuildSchool股份有限公司",
                    AppliedPosition = "(Fake).Net C# Web.Net C# Web",
                    Resume = "(Fake)我的履歷1",
                    ReadStatus = "(Fake)已讀取",
                    CreationDate =  new DateTime(2023, 9, 10, 13, 3, 54),
                    ResponseDate = new DateTime(2023, 9, 10, 13, 3, 54)
                    },
                                        new ApplicationRecordViewModel()
                    {
                    CompanyName = "(Fake)BuildSchool股份有限公司",
                    AppliedPosition = "(Fake).Net C# Web.Net C# Web",
                    ReadStatus = "(Fake)已讀取",
                    Resume = "(Fake)我的履歷1",
                    CreationDate =  new DateTime(2023, 9, 10, 13, 3, 54),
                    ResponseDate = new DateTime(2023, 9, 10, 13, 3, 54)
                    },

                    new ApplicationRecordViewModel()
                    {
                    CompanyName = "(Fake)BuildSchool股份有限公司",
                    AppliedPosition = "(Fake).Net C# Web.Net C# Web",
                    Resume = "(Fake)我的履歷1",
                    ReadStatus = "(Fake)已讀取",
                    CreationDate =  new DateTime(2023, 9, 10, 13, 3, 54),
                    ResponseDate = new DateTime(2023, 9, 10, 13, 3, 54)
                    },
                                        new ApplicationRecordViewModel()
                    {
                    CompanyName = "(Fake)BuildSchool股份有限公司",
                    AppliedPosition = "(Fake).Net C# Web.Net C# Web",
                    ReadStatus = "(Fake)已讀取",
                    Resume = "(Fake)我的履歷1",
                    CreationDate =  new DateTime(2023, 9, 10, 13, 3, 54),
                    ResponseDate = new DateTime(2023, 9, 10, 13, 3, 54)
                    },

                    new ApplicationRecordViewModel()
                    {
                    CompanyName = "(Fake)BuildSchool股份有限公司",
                    AppliedPosition = "(Fake).Net C# Web.Net C# Web",
                    Resume = "(Fake)我的履歷1",
                    ReadStatus = "(Fake)已讀取",
                    CreationDate =  new DateTime(2023, 9, 10, 13, 3, 54),
                    ResponseDate = new DateTime(2023, 9, 10, 13, 3, 54)
                    },
                                        new ApplicationRecordViewModel()
                    {
                    CompanyName = "(Fake)BuildSchool股份有限公司",
                    AppliedPosition = "(Fake).Net C# Web.Net C# Web",
                    ReadStatus = "(Fake)已讀取",
                    Resume = "(Fake)我的履歷1",
                    CreationDate =  new DateTime(2023, 9, 10, 13, 3, 54),
                    ResponseDate = new DateTime(2023, 9, 10, 13, 3, 54)
                    },

                    new ApplicationRecordViewModel()
                    {
                    CompanyName = "(Fake)BuildSchool股份有限公司",
                    AppliedPosition = "(Fake).Net C# Web.Net C# Web",
                    Resume = "(Fake)我的履歷1",
                    ReadStatus = "(Fake)已讀取",
                    CreationDate =  new DateTime(2023, 9, 10, 13, 3, 54),
                    ResponseDate = new DateTime(2023, 9, 10, 13, 3, 54)
                    },
                                        new ApplicationRecordViewModel()
                    {
                    CompanyName = "(Fake)BuildSchool股份有限公司",
                    AppliedPosition = "(Fake).Net C# Web.Net C# Web",
                    ReadStatus = "(Fake)已讀取",
                    Resume = "(Fake)我的履歷1",
                    CreationDate =  new DateTime(2023, 9, 10, 13, 3, 54),
                    ResponseDate = new DateTime(2023, 9, 10, 13, 3, 54)
                    },

                    new ApplicationRecordViewModel()
                    {
                    CompanyName = "(Fake)BuildSchool股份有限公司",
                    AppliedPosition = "(Fake).Net C# Web.Net C# Web",
                    Resume = "(Fake)我的履歷1",
                    ReadStatus = "(Fake)已讀取",
                    CreationDate =  new DateTime(2023, 9, 10, 13, 3, 54),
                    ResponseDate = new DateTime(2023, 9, 10, 13, 3, 54)
                    },
                                        new ApplicationRecordViewModel()
                    {
                    CompanyName = "(Fake)BuildSchool股份有限公司",
                    AppliedPosition = "(Fake).Net C# Web.Net C# Web",
                    ReadStatus = "(Fake)已讀取",
                    Resume = "(Fake)我的履歷1",
                    CreationDate =  new DateTime(2023, 9, 10, 13, 3, 54),
                    ResponseDate = new DateTime(2023, 9, 10, 13, 3, 54)
                    },

                    new ApplicationRecordViewModel()
                    {
                    CompanyName = "(Fake)BuildSchool股份有限公司",
                    AppliedPosition = "(Fake).Net C# Web.Net C# Web",
                    Resume = "(Fake)我的履歷1",
                    ReadStatus = "(Fake)已讀取",
                    CreationDate =  new DateTime(2023, 9, 10, 13, 3, 54),
                    ResponseDate = new DateTime(2023, 9, 10, 13, 3, 54)
                    },
                                        new ApplicationRecordViewModel()
                    {
                    CompanyName = "(Fake)BuildSchool股份有限公司",
                    AppliedPosition = "(Fake).Net C# Web.Net C# Web",
                    ReadStatus = "(Fake)已讀取",
                    Resume = "(Fake)我的履歷1",
                    CreationDate =  new DateTime(2023, 9, 10, 13, 3, 54),
                    ResponseDate = new DateTime(2023, 9, 10, 13, 3, 54)
                    },

                    new ApplicationRecordViewModel()
                    {
                    CompanyName = "(Fake)BuildSchool股份有限公司",
                    AppliedPosition = "(Fake).Net C# Web.Net C# Web",
                    Resume = "(Fake)我的履歷1",
                    ReadStatus = "(Fake)已讀取",
                    CreationDate =  new DateTime(2023, 9, 10, 13, 3, 54),
                    ResponseDate = new DateTime(2023, 9, 10, 13, 3, 54)
                    },
                                        new ApplicationRecordViewModel()
                    {
                    CompanyName = "(Fake)BuildSchool股份有限公司",
                    AppliedPosition = "(Fake).Net C# Web.Net C# Web",
                    ReadStatus = "(Fake)已讀取",
                    Resume = "(Fake)我的履歷1",
                    CreationDate =  new DateTime(2023, 9, 10, 13, 3, 54),
                    ResponseDate = new DateTime(2023, 9, 10, 13, 3, 54)
                    },

                    new ApplicationRecordViewModel()
                    {
                    CompanyName = "(Fake)BuildSchool股份有限公司",
                    AppliedPosition = "(Fake).Net C# Web.Net C# Web",
                    Resume = "(Fake)我的履歷1",
                    ReadStatus = "(Fake)已讀取",
                    CreationDate =  new DateTime(2023, 9, 10, 13, 3, 54),
                    ResponseDate = new DateTime(2023, 9, 10, 13, 3, 54)
                    },
                                        new ApplicationRecordViewModel()
                    {
                    CompanyName = "(Fake)BuildSchool股份有限公司",
                    AppliedPosition = "(Fake).Net C# Web.Net C# Web",
                    ReadStatus = "(Fake)已讀取",
                    Resume = "(Fake)我的履歷1",
                    CreationDate =  new DateTime(2023, 9, 10, 13, 3, 54),
                    ResponseDate = new DateTime(2023, 9, 10, 13, 3, 54)
                    },

                    new ApplicationRecordViewModel()
                    {
                    CompanyName = "(Fake)BuildSchool股份有限公司",
                    AppliedPosition = "(Fake).Net C# Web.Net C# Web",
                    Resume = "(Fake)我的履歷1",
                    ReadStatus = "(Fake)已讀取",
                    CreationDate =  new DateTime(2023, 9, 10, 13, 3, 54),
                    ResponseDate = new DateTime(2023, 9, 10, 13, 3, 54)
                    },
                                        new ApplicationRecordViewModel()
                    {
                    CompanyName = "(Fake)BuildSchool股份有限公司",
                    AppliedPosition = "(Fake).Net C# Web.Net C# Web",
                    ReadStatus = "(Fake)已讀取",
                    Resume = "(Fake)我的履歷1",
                    CreationDate =  new DateTime(2023, 9, 10, 13, 3, 54),
                    ResponseDate = new DateTime(2023, 9, 10, 13, 3, 54)
                    },
                                                            new ApplicationRecordViewModel()
                    {
                    CompanyName = "(Fake)BuildSchool股份有限公司",
                    AppliedPosition = "(Fake).Net C# Web.Net C# Web",
                    ReadStatus = "(Fake)已讀取",
                    Resume = "(Fake)我的履歷1",
                    CreationDate =  new DateTime(2023, 9, 10, 13, 3, 54),
                    ResponseDate = new DateTime(2023, 9, 10, 13, 3, 54)
                    },
                                        new ApplicationRecordViewModel()
                    {
                    CompanyName = "(Fake)BuildSchool股份有限公司",
                    AppliedPosition = "(Fake).Net C# Web.Net C# Web",
                    ReadStatus = "(Fake)已讀取",
                    Resume = "(Fake)我的履歷1",
                    CreationDate =  new DateTime(2023, 9, 10, 13, 3, 54),
                    ResponseDate = new DateTime(2023, 9, 10, 13, 3, 54)
                    },
                                        new ApplicationRecordViewModel()
                    {
                    CompanyName = "(Fake)BuildSchool股份有限公司",
                    AppliedPosition = "(Fake).Net C# Web.Net C# Web",
                    ReadStatus = "(Fake)已讀取",
                    Resume = "(Fake)我的履歷1",
                    CreationDate =  new DateTime(2023, 9, 10, 13, 3, 54),
                    ResponseDate = new DateTime(2023, 9, 10, 13, 3, 54)
                    },
                                        new ApplicationRecordViewModel()
                    {
                    CompanyName = "(Fake)BuildSchool股份有限公司",
                    AppliedPosition = "(Fake).Net C# Web.Net C# Web",
                    ReadStatus = "(Fake)已讀取",
                    Resume = "(Fake)我的履歷1",
                    CreationDate =  new DateTime(2023, 9, 10, 13, 3, 54),
                    ResponseDate = new DateTime(2023, 9, 10, 13, 3, 54)
                    },
                                        new ApplicationRecordViewModel()
                    {
                    CompanyName = "(Fake)BuildSchool股份有限公司",
                    AppliedPosition = "(Fake).Net C# Web.Net C# Web",
                    ReadStatus = "(Fake)已讀取",
                    Resume = "(Fake)我的履歷1",
                    CreationDate =  new DateTime(2023, 9, 10, 13, 3, 54),
                    ResponseDate = new DateTime(2023, 9, 10, 13, 3, 54)
                    },
                                        new ApplicationRecordViewModel()
                    {
                    CompanyName = "(Fake)BuildSchool股份有限公司",
                    AppliedPosition = "(Fake).Net C# Web.Net C# Web",
                    ReadStatus = "(Fake)已讀取",
                    Resume = "(Fake)我的履歷1",
                    CreationDate =  new DateTime(2023, 9, 10, 13, 3, 54),
                    ResponseDate = new DateTime(2023, 9, 10, 13, 3, 54)
                    },
                                        new ApplicationRecordViewModel()
                    {
                    CompanyName = "(Fake)BuildSchool股份有限公司",
                    AppliedPosition = "(Fake).Net C# Web.Net C# Web",
                    ReadStatus = "(Fake)已讀取",
                    Resume = "(Fake)我的履歷1",
                    CreationDate =  new DateTime(2023, 9, 10, 13, 3, 54),
                    ResponseDate = new DateTime(2023, 9, 10, 13, 3, 54)
                    },
                                        new ApplicationRecordViewModel()
                    {
                    CompanyName = "(Fake)BuildSchool股份有限公司",
                    AppliedPosition = "(Fake).Net C# Web.Net C# Web",
                    ReadStatus = "(Fake)已讀取",
                    Resume = "(Fake)我的履歷1",
                    CreationDate =  new DateTime(2023, 9, 10, 13, 3, 54),
                    ResponseDate = new DateTime(2023, 9, 10, 13, 3, 54)
                    },
                                        new ApplicationRecordViewModel()
                    {
                    CompanyName = "(Fake)BuildSchool股份有限公司",
                    AppliedPosition = "(Fake).Net C# Web.Net C# Web",
                    ReadStatus = "(Fake)已讀取",
                    Resume = "(Fake)我的履歷1",
                    CreationDate =  new DateTime(2023, 9, 10, 13, 3, 54),
                    ResponseDate = new DateTime(2023, 9, 10, 13, 3, 54)
                    },
                                        new ApplicationRecordViewModel()
                    {
                    CompanyName = "(Fake)BuildSchool股份有限公司",
                    AppliedPosition = "(Fake).Net C# Web.Net C# Web",
                    ReadStatus = "(Fake)已讀取",
                    Resume = "(Fake)我的履歷1",
                    CreationDate =  new DateTime(2023, 9, 10, 13, 3, 54),
                    ResponseDate = new DateTime(2023, 9, 10, 13, 3, 54)
                    },

                    new ApplicationRecordViewModel()
                    {
                    CompanyName = "(Fake)BuildSchool股份有限公司",
                    AppliedPosition = "(Fake).Net C# Web.Net C# Web",
                    Resume = "(Fake)我的履歷1",
                    ReadStatus = "(Fake)已讀取",
                    CreationDate =  new DateTime(2023, 9, 10, 13, 3, 54),
                    ResponseDate = new DateTime(2023, 9, 10, 13, 3, 54)
                    }
                },
                CollectionCompanyViewModel = new List<CollectionCompanyViewModel>()
                {
                    new CollectionCompanyViewModel()
                    {
                        CreationDate =  new DateTime(2023, 9, 10, 13, 3, 54),
                        Name = "(Fake)BuildSchool股份有限公司",
                        Category = "(Fake)科技業"
                    },
                                        new CollectionCompanyViewModel()
                    {
                        CreationDate =  new DateTime(2023, 9, 10, 13, 3, 54),
                        Name = "(Fake)BuildSchool股份有限公司",
                        Category = "(Fake)零售業"
                    },
                                new CollectionCompanyViewModel()
                    {
                        CreationDate =  new DateTime(2023, 9, 10, 13, 3, 54),
                        Name = "(Fake)BuildSchool股份有限公司",
                        Category = "(Fake)科技業"
                    },
                           new CollectionCompanyViewModel()
                    {
                        CreationDate =  new DateTime(2023, 9, 10, 13, 3, 54),
                        Name = "(Fake)BuildSchool股份有限公司",
                        Category = "(Fake)科技業"
                    },
                          new CollectionCompanyViewModel()
                    {
                        CreationDate =  new DateTime(2023, 9, 10, 13, 3, 54),
                        Name = "(Fake)BuildSchool股份有限公司",
                        Category = "(Fake)科技業"
                    },
new CollectionCompanyViewModel()
                    {
                        CreationDate =  new DateTime(2023, 9, 10, 13, 3, 54),
                        Name = "(Fake)BuildSchool股份有限公司",
                        Category = "(Fake)科技業"
                    },
                                        new CollectionCompanyViewModel()
                    {
                        CreationDate =  new DateTime(2023, 9, 10, 13, 3, 54),
                        Name = "(Fake)BuildSchool股份有限公司",
                        Category = "(Fake)零售業"
                    },
                                new CollectionCompanyViewModel()
                    {
                        CreationDate =  new DateTime(2023, 9, 10, 13, 3, 54),
                        Name = "(Fake)BuildSchool股份有限公司",
                        Category = "(Fake)科技業"
                    },
                           new CollectionCompanyViewModel()
                    {
                        CreationDate =  new DateTime(2023, 9, 10, 13, 3, 54),
                        Name = "(Fake)BuildSchool股份有限公司",
                        Category = "(Fake)科技業"
                    },
                          new CollectionCompanyViewModel()
                    {
                        CreationDate =  new DateTime(2023, 9, 10, 13, 3, 54),
                        Name = "(Fake)BuildSchool股份有限公司",
                        Category = "(Fake)科技業"
                    },
new CollectionCompanyViewModel()
                    {
                        CreationDate =  new DateTime(2023, 9, 10, 13, 3, 54),
                        Name = "(Fake)BuildSchool股份有限公司",
                        Category = "(Fake)科技業"
                    },
                                        new CollectionCompanyViewModel()
                    {
                        CreationDate =  new DateTime(2023, 9, 10, 13, 3, 54),
                        Name = "(Fake)BuildSchool股份有限公司",
                        Category = "(Fake)零售業"
                    },
                                new CollectionCompanyViewModel()
                    {
                        CreationDate =  new DateTime(2023, 9, 10, 13, 3, 54),
                        Name = "(Fake)BuildSchool股份有限公司",
                        Category = "(Fake)科技業"
                    },
                           new CollectionCompanyViewModel()
                    {
                        CreationDate =  new DateTime(2023, 9, 10, 13, 3, 54),
                        Name = "(Fake)BuildSchool股份有限公司",
                        Category = "(Fake)科技業"
                    },
                          new CollectionCompanyViewModel()
                    {
                        CreationDate =  new DateTime(2023, 9, 10, 13, 3, 54),
                        Name = "(Fake)BuildSchool股份有限公司",
                        Category = "(Fake)科技業"
                    },
        new CollectionCompanyViewModel()
                    {
                        CreationDate =  new DateTime(2023, 9, 10, 13, 3, 54),
                        Name = "(Fake)BuildSchool股份有限公司",
                        Category = "(Fake)科技業"
                    },
                                        new CollectionCompanyViewModel()
                    {
                        CreationDate =  new DateTime(2023, 9, 10, 13, 3, 54),
                        Name = "(Fake)BuildSchool股份有限公司",
                        Category = "(Fake)零售業"
                    },
                                new CollectionCompanyViewModel()
                    {
                        CreationDate =  new DateTime(2023, 9, 10, 13, 3, 54),
                        Name = "(Fake)BuildSchool股份有限公司",
                        Category = "(Fake)科技業"
                    },
                           new CollectionCompanyViewModel()
                    {
                        CreationDate =  new DateTime(2023, 9, 10, 13, 3, 54),
                        Name = "(Fake)BuildSchool股份有限公司",
                        Category = "(Fake)科技業"
                    },
                          new CollectionCompanyViewModel()
                    {
                        CreationDate =  new DateTime(2023, 9, 10, 13, 3, 54),
                        Name = "(Fake)BuildSchool股份有限公司",
                        Category = "(Fake)科技業"
                    },
     new CollectionCompanyViewModel()
                    {
                        CreationDate =  new DateTime(2023, 9, 10, 13, 3, 54),
                        Name = "(Fake)BuildSchool股份有限公司",
                        Category = "(Fake)科技業"
                    },
                                        new CollectionCompanyViewModel()
                    {
                        CreationDate =  new DateTime(2023, 9, 10, 13, 3, 54),
                        Name = "(Fake)BuildSchool股份有限公司",
                        Category = "(Fake)零售業"
                    },
                                new CollectionCompanyViewModel()
                    {
                        CreationDate =  new DateTime(2023, 9, 10, 13, 3, 54),
                        Name = "(Fake)BuildSchool股份有限公司",
                        Category = "(Fake)科技業"
                    },
                           new CollectionCompanyViewModel()
                    {
                        CreationDate =  new DateTime(2023, 9, 10, 13, 3, 54),
                        Name = "(Fake)BuildSchool股份有限公司",
                        Category = "(Fake)科技業"
                    },
                          new CollectionCompanyViewModel()
                    {
                        CreationDate =  new DateTime(2023, 9, 10, 13, 3, 54),
                        Name = "(Fake)BuildSchool股份有限公司",
                        Category = "(Fake)科技業"
                    },
new CollectionCompanyViewModel()
                    {
                        CreationDate =  new DateTime(2023, 9, 10, 13, 3, 54),
                        Name = "(Fake)BuildSchool股份有限公司",
                        Category = "(Fake)科技業"
                    },
                                        new CollectionCompanyViewModel()
                    {
                        CreationDate =  new DateTime(2023, 9, 10, 13, 3, 54),
                        Name = "(Fake)BuildSchool股份有限公司",
                        Category = "(Fake)零售業"
                    },
                                new CollectionCompanyViewModel()
                    {
                        CreationDate =  new DateTime(2023, 9, 10, 13, 3, 54),
                        Name = "(Fake)BuildSchool股份有限公司",
                        Category = "(Fake)科技業"
                    },
                                 new CollectionCompanyViewModel()
                    {
                        CreationDate =  new DateTime(2023, 9, 10, 13, 3, 54),
                        Name = "(Fake)BuildSchool股份有限公司",
                        Category = "(Fake)科技業"
                    },
                                        new CollectionCompanyViewModel()
                    {
                        CreationDate =  new DateTime(2023, 9, 10, 13, 3, 54),
                        Name = "(Fake)BuildSchool股份有限公司",
                        Category = "(Fake)零售業"
                    },
                                new CollectionCompanyViewModel()
                    {
                        CreationDate =  new DateTime(2023, 9, 10, 13, 3, 54),
                        Name = "(Fake)BuildSchool股份有限公司",
                        Category = "(Fake)科技業"
                    },
                           new CollectionCompanyViewModel()
                    {
                        CreationDate =  new DateTime(2023, 9, 10, 13, 3, 54),
                        Name = "(Fake)BuildSchool股份有限公司",
                        Category = "(Fake)科技業"
                    },
                          new CollectionCompanyViewModel()
                    {
                        CreationDate =  new DateTime(2023, 9, 10, 13, 3, 54),
                        Name = "(Fake)BuildSchool股份有限公司",
                        Category = "(Fake)科技業"
                    },
new CollectionCompanyViewModel()
                    {
                        CreationDate =  new DateTime(2023, 9, 10, 13, 3, 54),
                        Name = "(Fake)BuildSchool股份有限公司",
                        Category = "(Fake)科技業"
                    },
                                        new CollectionCompanyViewModel()
                    {
                        CreationDate =  new DateTime(2023, 9, 10, 13, 3, 54),
                        Name = "(Fake)BuildSchool股份有限公司",
                        Category = "(Fake)零售業"
                    },
                                new CollectionCompanyViewModel()
                    {
                        CreationDate =  new DateTime(2023, 9, 10, 13, 3, 54),
                        Name = "(Fake)BuildSchool股份有限公司",
                        Category = "(Fake)科技業"
                    },
         new CollectionCompanyViewModel()
                    {
                        CreationDate =  new DateTime(2023, 9, 10, 13, 3, 54),
                        Name = "(Fake)BuildSchool股份有限公司",
                        Category = "(Fake)科技業"
                    },
                                        new CollectionCompanyViewModel()
                    {
                        CreationDate =  new DateTime(2023, 9, 10, 13, 3, 54),
                        Name = "(Fake)BuildSchool股份有限公司",
                        Category = "(Fake)零售業"
                    },
                                new CollectionCompanyViewModel()
                    {
                        CreationDate =  new DateTime(2023, 9, 10, 13, 3, 54),
                        Name = "(Fake)BuildSchool股份有限公司",
                        Category = "(Fake)科技業"
                    }
                }

            };
            return results;
        }

        public List<JobSliderViewModel> GetAllSlider()
        {
            //List<JobSlider> jobSliders = _memberFavoriteJobsRepository.ReadAllSlider();

            List<JobSliderViewModel> result = new List<JobSliderViewModel>()
            {
                new JobSliderViewModel()
                {
                    Id = 1,
                    JobName = "(Fake).net工程師[全台最大辦公用品供應商]",
                    Company = "(Fake)BuildSchool股份有限公司",
                    CreationDate = new DateTime(2023, 9, 10, 13, 3, 54)
                },
                new JobSliderViewModel()
                {
                    Id = 2,
                    JobName = "(Fake)ASP.NET C#程式設計師(新鮮人可)",
                    Company = "(Fake)BuildSchool股份有限公司",
                    CreationDate = new DateTime(2023, 8, 31, 11, 14, 12)
                },
                new JobSliderViewModel()
                {
                    Id = 3,
                    JobName = "(Fake)C# winform 工程師",
                    Company = "(Fake)BuildSchool股份有限公司",
                    CreationDate = new DateTime(2023, 8, 31, 10, 21, 35)
                },
                new JobSliderViewModel()
                {
                    Id = 4,
                    JobName = "(Fake).Net C# Web.Net C# Web",
                    Company = "(Fake)BuildSchool股份有限公司",
                    CreationDate = new DateTime(2023, 8, 31, 8, 23, 59)
                },
                new JobSliderViewModel()
                {
                    Id = 5,
                    JobName = "(Fake).Net 軟體工程師",
                    Company = "(Fake)BuildSchool股份有限公司",
                    CreationDate = new DateTime(2023, 8, 31, 7, 24, 13)
                },
                new JobSliderViewModel()
                {
                    Id = 6,
                    JobName = "(Fake).Net Software Programmer：C#.Net軟體工程師",
                    Company = "(Fake)BuildSchool股份有限公司",
                    CreationDate = new DateTime(2023, 8, 31, 6, 10, 22)
                },
                new JobSliderViewModel()
                {
                    Id = 7,
                    JobName = "(Fake)架構師/遊戲研發主管架構師",
                    Company = "(Fake)BuildSchool股份有限公司",
                    CreationDate = new DateTime(2023, 8, 30, 12, 15, 33)
                },
                new JobSliderViewModel()
                {
                    Id = 8,
                    JobName = "(Fake)第一事業群- 產品開發處-開發二組-工程師(程式開發／C#)",
                    Company = "(Fake)BuildSchool股份有限公司",
                    CreationDate = new DateTime(2023, 8, 30, 23, 9, 13)
                },
                new JobSliderViewModel()
                {
                    Id = 9,
                    JobName = "(Fake)程式設計師 MVC Team程式設計師 MVC",
                    Company = "(Fake)BuildSchool股份有限公司",
                    CreationDate = new DateTime(2023, 8, 30, 11, 6, 13)
                },
                new JobSliderViewModel()
                {
                    Id = 10,
                    JobName = "(Fake)程式設計專員",
                    Company = "(Fake)BuildSchool股份有限公司",
                    CreationDate = new DateTime(2023, 8, 29, 14, 14, 12)
                },
                new JobSliderViewModel()
                {
                    Id = 11,
                    JobName = "(Fake)後端工程師",
                    Company = "(Fake)BuildSchool股份有限公司",
                    CreationDate = new DateTime(2023, 8, 29, 11, 2, 11)
                },
                new JobSliderViewModel()
                {
                    Id = 12,
                    JobName = "(Fake)初級C#軟體工程師",
                    Company = "(Fake)BuildSchool股份有限公司",
                    CreationDate = new DateTime(2023, 8, 28, 11, 11, 55)
                },
                new JobSliderViewModel()
                {
                    Id = 13,
                    JobName = "(Fake)物流技術部-C#工程師",
                    Company = "(Fake)BuildSchool股份有限公司",
                    CreationDate = new DateTime(2023, 8, 28, 9, 13, 33)
                },
                new JobSliderViewModel()
                {
                    Id = 14,
                    JobName = "(Fake)C# .NET 後端工程師",
                    Company = "(Fake)BuildSchool股份有限公司",
                    CreationDate = new DateTime(2023, 8, 28, 7, 18, 34)
                },
                new JobSliderViewModel()
                {
                    Id = 15,
                    JobName = "(Fake)(Sr.) C# Developer - Fully Remote",
                    Company = "(Fake)BuildSchool股份有限公司",
                    CreationDate = new DateTime(2023, 8, 27, 5, 12, 12)
                },
                new JobSliderViewModel()
                {
                    Id = 16,
                    JobName = "(Fake) 【海外儲備幹部】Software Engineer／Programmer 軟體工程師 (C#)",
                    Company = "(Fake)BuildSchool股份有限公司",
                    CreationDate = new DateTime(2023, 8, 26, 14, 10, 15)
                },
                new JobSliderViewModel()
                {
                    Id = 17,
                    JobName = "(Fake)C# MVC後端程式設計師",
                    Company = "(Fake)BuildSchool股份有限公司",
                    CreationDate = new DateTime(2023, 8, 26, 16, 9, 55)
                },
                new JobSliderViewModel()
                {
                    Id = 18,
                    JobName = "(Fake)Senior Software Engineer／Sr. Programmer 資深軟體工程師 (C#)",
                    Company = "(Fake)BuildSchool股份有限公司",
                    CreationDate = new DateTime(2023, 8, 26, 18, 6, 44)
                },
                new JobSliderViewModel()
                {
                    Id = 19,
                    JobName = "(Fake).net工程師[全台最大辦公用品供應商]",
                    Company = "(Fake)BuildSchool股份有限公司",
                    CreationDate = new DateTime(2023, 8, 25, 11, 4, 34)
                },
                new JobSliderViewModel()
                {
                    Id = 20,
                    JobName = "(Fake).net工程師[全台最大辦公用品供應商].net工程師[全台最大辦公用品供應商].net工程師[全台最大辦公用品供應商].net工程師[全台最大辦公用品供應商]",
                    Company = "(Fake)BuildSchool股份有限公司",
                    CreationDate = new DateTime(2023, 8, 24, 9, 13, 12)
                },
                new JobSliderViewModel()
                {
                    Id = 21,
                    JobName = "(Fake)Asp.Net ,C# 程式設計師",
                    Company = "(Fake)BuildSchool股份有限公司",
                    CreationDate = new DateTime(2023, 8, 24, 12, 15, 34)
                },
                new JobSliderViewModel()
                {
                    Id = 22,
                    JobName = "(Fake)後端工程師 Backend Engineer (C#)",
                    Company = "(Fake)BuildSchool股份有限公司",
                    CreationDate = new DateTime(2023, 8, 23, 11, 13, 54)
                },
                new JobSliderViewModel()
                {
                    Id = 23,
                    JobName = "(Fake)程式設計師(財富管理事業群)",
                    Company = "(Fake)BuildSchool股份有限公司",
                    CreationDate = new DateTime(2023, 8, 22, 11, 15, 43)
                },
                new JobSliderViewModel()
                {
                    Id = 24,
                    JobName = "(Fake)ASP.NET MVC C# 網站後端工程師",
                    Company = "(Fake)BuildSchool股份有限公司",
                    CreationDate = new DateTime(2023, 8, 22, 4, 11, 23)
                },
                new JobSliderViewModel()
                {
                    Id = 25,
                    JobName = "(Fake)【凱基證券/資訊部】C#/.Net 應用系統開發工程師",
                    Company = "(Fake)BuildSchool股份有限公司",
                    CreationDate = new DateTime(2023, 8, 21, 5, 10, 11)
                },
                new JobSliderViewModel()
                {
                    Id = 26,
                    JobName = "(Fake)軟體程式開發工程師 ( C# WinForm使用開發為主 )",
                    Company = "(Fake)BuildSchool股份有限公司",
                    CreationDate = new DateTime(2023, 8, 21, 6, 15, 13)
                },
                new JobSliderViewModel()
                {
                    Id = 27,
                    JobName = "(Fake)程式設計師 (ASP.NET C#)",
                    Company = "(Fake)BuildSchool股份有限公司",
                    CreationDate = new DateTime(2023, 8, 20, 8, 14, 56)
                },
                new JobSliderViewModel()
                {
                    Id = 28,
                    JobName = "(Fake)【凱基證券/資訊部】C#全端程式設計師",
                    Company = "(Fake)BuildSchool股份有限公司",
                    CreationDate = new DateTime(2023, 8, 18, 14, 12, 12)
                },
                new JobSliderViewModel()
                {
                    Id = 29,
                    JobName = "(Fake).net工程師[全台最大辦公用品供應商].net工程師[全台最大辦公用品供應商].net工程師[全台最大辦公用品供應商].net工程師[全台最大辦公用品供應商]",
                    Company = "(Fake)BuildSchool股份有限公司",
                    CreationDate = new DateTime(2023, 8, 24, 14, 30, 0)
                },
                new JobSliderViewModel()
                {
                    Id = 30,
                    JobName = "(Fake)【擴大招募！】 .NET C#軟體工程師",
                    Company = "(Fake)BuildSchool股份有限公司",
                    CreationDate = new DateTime(2023, 8, 22, 14, 30, 0)
                },
                new JobSliderViewModel()
                {
                    Id = 31,
                    JobName = "(Fake) Winform C# 軟體程式開發，工程師《台中》",
                    Company = "(Fake)BuildSchool股份有限公司",
                    CreationDate = new DateTime(2023, 8, 24, 14, 30, 0)
                },
                new JobSliderViewModel()
                {
                    Id = 32,
                    JobName = "(Fake)【視訊面試優先】.NET程式設計師(C#)",
                    Company = "(Fake)BuildSchool股份有限公司",
                    CreationDate = new DateTime(2023, 8, 22, 14, 30, 0)
                }
            };
            return result;
            //return jobSliders;
        }

        public List<ChatOverviewViewModel> GetChatOverviewView()
        {
            List<ChatOverviewViewModel> viewModel = new List<ChatOverviewViewModel>()
            { 
                new ChatOverviewViewModel() 
                {
                    Pic = "/images/Candidate/ChatOverview/kubuke.png",
                    SenderName = "Fake可不可熟成紅茶北區*******************",
                    MessageTime =new DateTime(2023,9,5,14,00,00),
                    JobName = "Fake可不可熟成紅茶-淡水北新店-工讀人員(早晚班)*******************************************",
                    ChatContent ="Fake下午一點到十點唷*******************************************"


                },
                    new ChatOverviewViewModel()
                {
                    Pic = "/images/Candidate/ChatOverview/kubuke.png",
                    SenderName = "可不可熟成紅茶北區*******************",
                    MessageTime =new DateTime(2023,9,5,14,00,00),
                    JobName = "可不可熟成紅茶-淡水北新店-工讀人員(早晚班)*******************************************",
                    ChatContent ="下午一點到十點唷*******************************************"


                },
                  new ChatOverviewViewModel()
                {
                    Pic = "/images/Candidate/ChatOverview/kubuke.png",
                    SenderName = "可不可熟成紅茶北區*******************",
                    MessageTime =new DateTime(2023,9,5,14,00,00),
                    JobName = "可不可熟成紅茶-淡水北新店-工讀人員(早晚班)*******************************************",
                    ChatContent ="下午一點到十點唷*******************************************"


                },
                  new ChatOverviewViewModel()
                {
                    Pic = "/images/Candidate/ChatOverview/kubuke.png",
                    SenderName = "可不可熟成紅茶北區*******************",
                    MessageTime =new DateTime(2023,9,5,14,00,00),
                    JobName = "可不可熟成紅茶-淡水北新店-工讀人員(早晚班)*******************************************",
                    ChatContent ="下午一點到十點唷*******************************************"


                },
                    new ChatOverviewViewModel()
                {
                    Pic = "/images/Candidate/ChatOverview/kubuke.png",
                    SenderName = "可不可熟成紅茶北區*******************",
                    MessageTime =new DateTime(2023,9,5,14,00,00),
                    JobName = "可不可熟成紅茶-淡水北新店-工讀人員(早晚班)*******************************************",
                    ChatContent ="下午一點到十點唷*******************************************"


                },
                            new ChatOverviewViewModel()
                {
                    Pic = "/images/Candidate/ChatOverview/kubuke.png",
                    SenderName = "可不可熟成紅茶北區*******************",
                    MessageTime =new DateTime(2023,9,5,14,00,00),
                    JobName = "可不可熟成紅茶-淡水北新店-工讀人員(早晚班)*******************************************",
                    ChatContent ="下午一點到十點唷*******************************************"


                },



            };
            return viewModel;
        }

        public List<ResumeCenterViewModel> GetResumeCenterViewModel()
        {
            List<ResumeCenterViewModel> result = new List<ResumeCenterViewModel>()
            {
                new ResumeCenterViewModel()
                {
                   ResumeName = "我的履歷",
                   CreateAt = new DateTime(2023, 9, 10).ToString("yyyy/MM/dd")
                },
                new ResumeCenterViewModel()
                {
                   ResumeName = "我的第二份履歷",
                   CreateAt = new DateTime(2023, 9, 11).ToString("yyyy/MM/dd")
                },
            };
            return result;
        }
        public List<ResumeEditViewModel> GetResumeEditViewModel()
        {
            List<ResumeEditViewModel> result = new List<ResumeEditViewModel>()
            {
                new ResumeEditViewModel()
                {
                    CreateAt = new DateTime(2023, 9, 10).ToString("yyyy/MM/dd"),
                    Name = "XXX",
                    Gender = "女",
                    Age = 18,
                    EmploymentStatus = "待業中",
                    Address = "台北市大安區忠孝東路三段xx號xx號樓之x",
                    Phonenumber ="09001234567",
                    Email = "BulidSchool@gmail.com",
                    SchoolName = "BulidSchool大學",
                    Majoring = "資工系 ",
                    RelatedMajoring = "資訊相關",
                    EducationalStatus = "畢業",
                    JobTitle = "軟體工程師",
                    CompanyName = "青杉人才有限公司",
                    StartTime = new DateTime(2023, 5, 1),
                    EndTime = new DateTime(2023, 10, 31),
                    JobNature = "全職",
                    JobCategory = "軟體資訊業",
                    DrvingLicense = "機車",
                    Autobiography = "我是一個充滿活力的年輕人，對於生活中的各種挑戰充滿熱情。我相信，每個人都有自己的獨特之處，而我最大的特點就是追求完美。無論是工作還是生活，我總是力求做到最好。\r\n我也擁有餐飲服務方面的經驗。我享受與客戶交流並提供他們最好的服務。我相信良好的溝通和細心的服務是滿足客戶需求的關鍵。\r\n另外值得一提的是，我擁有普通重型機車駕照，這讓我在運輸和外勤工作上更加靈活。\r\n如果您對我的申請感興趣，我非常期待有機會與您見面，謝謝您閱讀我的履歷自傳！"
                },
                new ResumeEditViewModel()
                {
                    CreateAt = new DateTime(2023, 9, 10).ToString("yyyy/MM/dd"),
                    Name = "XXX",
                    Gender = "女",
                    Age = 18,
                    EmploymentStatus = "待業中",
                    Address = "台北市大安區忠孝東路三段xx號xx號樓之x",
                    Phonenumber ="09001234567",
                    Email = "BulidSchool@gmail.com",
                    SchoolName = "BulidSchool大學",
                    Majoring = "資工系 ",
                    RelatedMajoring = "資訊相關",
                    EducationalStatus = "畢業",
                    JobTitle = "軟體工程師",
                    CompanyName = "青杉人才有限公司",
                    StartTime = new DateTime(2023, 5, 1),
                    EndTime = new DateTime(2023, 10, 31),
                    JobNature = "全職",
                    JobCategory = "軟體資訊業",
                    DrvingLicense = "機車",
                    Autobiography = "我是一個充滿活力的年輕人，對於生活中的各種挑戰充滿熱情。我相信，每個人都有自己的獨特之處，而我最大的特點就是追求完美。無論是工作還是生活，我總是力求做到最好。\r\n我也擁有餐飲服務方面的經驗。我享受與客戶交流並提供他們最好的服務。我相信良好的溝通和細心的服務是滿足客戶需求的關鍵。\r\n另外值得一提的是，我擁有普通重型機車駕照，這讓我在運輸和外勤工作上更加靈活。\r\n如果您對我的申請感興趣，我非常期待有機會與您見面，謝謝您閱讀我的履歷自傳！"
                },
            };
            return result;
        }

        public ChatViewModel GetChat()
        {
            var viewModel = new ChatViewModel()
            {
                ActiveCompany= "Fake可不可熟成紅茶北區",
                ActiveJobName = "Fake可不可熟成紅茶-淡水北新店-工讀人員(早晚班)",
                ChatList = new List<ChatListViewModel>()
              {
                new ChatListViewModel()
                {

                     Pic ="kubuke.png",
                     MessageTime=DateTime.UtcNow,
                     SenderName ="Fake可不可熟成紅茶北區",
                     JobName="Fake可不可熟成紅茶-淡水北新店-工讀人員(早晚班)",
                     ChatContent ="Fake嗨~想請問這份工作的上班及下班時間?",
                },
                 new ChatListViewModel()
                {

                     Pic ="kubuke.png",
                     MessageTime=DateTime.UtcNow,
                     SenderName ="可不可熟成紅茶北區",
                     JobName="可不可熟成紅茶-淡水北新店-工讀人員(早晚班)",
                     ChatContent ="嗨~想請問這份工作的上班及下班時間?",
                },
                 new ChatListViewModel()
                {

                     Pic ="kubuke.png",
                     MessageTime=DateTime.UtcNow,
                     SenderName ="可不可熟成紅茶北區",
                     JobName="可不可熟成紅茶-淡水北新店-工讀人員(早晚班)",
                     ChatContent ="嗨~想請問這份工作的上班及下班時間?",
                },
                         new ChatListViewModel()
                {

                     Pic ="kubuke.png",
                     MessageTime=DateTime.UtcNow,
                     SenderName ="可不可熟成紅茶北區",
                     JobName="可不可熟成紅茶-淡水北新店-工讀人員(早晚班)",
                     ChatContent ="嗨~想請問這份工作的上班及下班時間?",
                },
                        new ChatListViewModel()
                {

                     Pic ="kubuke.png",
                     MessageTime=DateTime.UtcNow,
                     SenderName ="可不可熟成紅茶北區",
                     JobName="可不可熟成紅茶-淡水北新店-工讀人員(早晚班)",
                     ChatContent ="嗨~想請問這份工作的上班及下班時間?",
                },
                        new ChatListViewModel()
                {

                     Pic ="kubuke.png",
                     MessageTime=DateTime.UtcNow,
                     SenderName ="可不可熟成紅茶北區",
                     JobName="可不可熟成紅茶-淡水北新店-工讀人員(早晚班)",
                     ChatContent ="嗨~想請問這份工作的上班及下班時間?",
                },
              },
                CurrentChat = new List<CurrentChatViewModel>() 
                {
                    new CurrentChatViewModel()
                    {
                        Pic="localuser_pic.jpg",
                        ChatContent="Fake嗨~想請問這份工作的上班及下班時間?",
                        MessageTime=new DateTime(2023,9,5,14,34,50),
                        readStatus=1,
                        SenderAccount=1

                    },
                       new CurrentChatViewModel()
                    {
                        Pic="kubuke.png",
                        ChatContent="下午一點到十點唷",
                        MessageTime=new DateTime(2023,9,6),
                        readStatus=1,
                        SenderAccount=0

                    },
                       new CurrentChatViewModel()
                    {
                        Pic="kubuke.png",
                        ChatContent="好的~謝謝尼",
                        MessageTime=new DateTime(2023,9,7),
                        readStatus=1,
                        SenderAccount=1

                    },
                }

           };

            return viewModel;
        }
        
    }
}

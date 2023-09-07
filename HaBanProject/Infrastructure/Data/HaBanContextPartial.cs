using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{

    public partial class HaBanContext
    {
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Candidate>()
                           .HasData(SeedData.ProduceCandidate());
            modelBuilder.Entity<CompanyFeatureCategory>()
             .HasData(SeedData.ProduceCompanyFeatureCategory());
            modelBuilder.Entity<Company>()
            .HasData(SeedData.ProduceCompany());

            
            modelBuilder.Entity<City>()
            .HasData(SeedData.ProduceCity());
            modelBuilder.Entity<District>()
              .HasData(SeedData.ProduceDistrict());
            modelBuilder.Entity<AddressDetail>()
                .HasData(SeedData.ProduceAddressDetail());
            modelBuilder.Entity<AddressRelation>()
               .HasData(SeedData.ProduceAddressRelation());


            modelBuilder.Entity<JobFeature>()
               .HasData(SeedData.ProduceJobFeature());
            modelBuilder.Entity<JobFeaturesRelation>()
                .HasData(SeedData.ProduceJobFeaturesRelation());

            modelBuilder.Entity<MembershipCategory>()
             .HasData(SeedData.ProduceMembershipCategory());


            modelBuilder.Entity<BoostOrder>()
              .HasData(SeedData.ProduceBoostOrder());
            modelBuilder.Entity<MembershipOrder>()
            .HasData(SeedData.ProduceMembershipOrder());
            modelBuilder.Entity<EnvironmentPic>()
             .HasData(SeedData.ProduceEnvironmentPic());



            modelBuilder.Entity<WorkExpSnapshot>()
             .HasData(SeedData.ProduceWorkExpSnapshot());
            modelBuilder.Entity<ResumeSnapshot>()
               .HasData(SeedData.ProduceResumeSnapshot());
            modelBuilder.Entity<ApplicationRecord>()
             .HasData(SeedData.ProduceApplicationRecord());

            modelBuilder.Entity<ChatMessage>()
            .HasData(SeedData.ProduceChatMessage());

            modelBuilder.Entity<WorkExperience>()
              .HasData(SeedData.ProduceWorkExperience());
            modelBuilder.Entity<Resume>()
               .HasData(SeedData.ProduceResume());




            //--不確定

            modelBuilder.Entity<CompanyProfile>()
            .HasData(SeedData.ProduceCompanyProfile());
            modelBuilder.Entity<CompanyFeatureRelation>()
              .HasData(SeedData.ProduceCompanyFeatureRelation());

            modelBuilder.Entity<IndustryCategory>()
            .HasData(SeedData.ProduceIndustryCategory());
            modelBuilder.Entity<EmployeeCategory>()
              .HasData(SeedData.ProduceEmployeeCategory());
            modelBuilder.Entity<JobCategory>()
              .HasData(SeedData.ProduceJobCategory());






            modelBuilder.Entity<JobDescription>()
                .HasData(SeedData.ProduceJobDescription());

            modelBuilder.Entity<WorkShare>()
              .HasData(SeedData.ProduceWorkShare());





            modelBuilder.Entity<CollectionCompany>()
              .HasData(SeedData.ProduceCollectionCompany());
            modelBuilder.Entity<CollectionJob>()
              .HasData(SeedData.ProduceCollectionJob());
            modelBuilder.Entity<BoostUsed>()
              .HasData(SeedData.ProduceBoostUsed());

        }
    }
}

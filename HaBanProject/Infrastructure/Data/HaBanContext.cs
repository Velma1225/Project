using System;
using System.Collections.Generic;
using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public partial class HaBanContext : DbContext
{
    public HaBanContext()
    {
    }

    public HaBanContext(DbContextOptions<HaBanContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AddressDetail> AddressDetails { get; set; }

    public virtual DbSet<AddressRelation> AddressRelations { get; set; }

    public virtual DbSet<ApplicationRecord> ApplicationRecords { get; set; }

    public virtual DbSet<BoostOrder> BoostOrders { get; set; }

    public virtual DbSet<BoostUsed> BoostUseds { get; set; }

    public virtual DbSet<Candidate> Candidates { get; set; }

    public virtual DbSet<ChatMessage> ChatMessages { get; set; }

    public virtual DbSet<City> Cities { get; set; }

    public virtual DbSet<CollectionCompany> CollectionCompanies { get; set; }

    public virtual DbSet<CollectionJob> CollectionJobs { get; set; }

    public virtual DbSet<Company> Companies { get; set; }

    public virtual DbSet<CompanyFeatureCategory> CompanyFeatureCategories { get; set; }

    public virtual DbSet<CompanyFeatureRelation> CompanyFeatureRelations { get; set; }

    public virtual DbSet<CompanyProfile> CompanyProfiles { get; set; }

    public virtual DbSet<District> Districts { get; set; }

    public virtual DbSet<EmployeeCategory> EmployeeCategories { get; set; }

    public virtual DbSet<EnvironmentPic> EnvironmentPics { get; set; }

    public virtual DbSet<IndustryCategory> IndustryCategories { get; set; }

    public virtual DbSet<JobCategory> JobCategories { get; set; }

    public virtual DbSet<JobDescription> JobDescriptions { get; set; }

    public virtual DbSet<JobFeature> JobFeatures { get; set; }

    public virtual DbSet<JobFeaturesRelation> JobFeaturesRelations { get; set; }

    public virtual DbSet<MembershipCategory> MembershipCategories { get; set; }

    public virtual DbSet<MembershipOrder> MembershipOrders { get; set; }

    public virtual DbSet<RecentlyViewedJob> RecentlyViewedJobs { get; set; }

    public virtual DbSet<Resume> Resumes { get; set; }

    public virtual DbSet<ResumeSnapshot> ResumeSnapshots { get; set; }

    public virtual DbSet<WorkExpSnapshot> WorkExpSnapshots { get; set; }

    public virtual DbSet<WorkExperience> WorkExperiences { get; set; }

    public virtual DbSet<WorkShare> WorkShares { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=ConnectionStrings:HaBanContext");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("SQL_Latin1_General_CP1_CI_AS");

        modelBuilder.Entity<AddressDetail>(entity =>
        {
            entity.HasKey(e => e.AddressDetailId).HasName("PK_Addresses");

            entity.HasIndex(e => e.DistrictId, "IX_AddressDetails_DistrictID");

            entity.Property(e => e.AddressDetailId).HasColumnName("AddressDetailID");
            entity.Property(e => e.Address).IsRequired();
            entity.Property(e => e.DistrictId).HasColumnName("DistrictID");
            entity.Property(e => e.Latitude).HasColumnType("decimal(10, 8)");
            entity.Property(e => e.Longitude).HasColumnType("decimal(11, 8)");

            entity.HasOne(d => d.District).WithMany(p => p.AddressDetails)
                .HasForeignKey(d => d.DistrictId)
                .HasConstraintName("FK_Addresses_Districts");
        });

        modelBuilder.Entity<AddressRelation>(entity =>
        {
            entity.HasKey(e => e.AddressRelationId).HasName("PK_AddressRealations");

            entity.HasIndex(e => e.AddressId, "IX_AddressRelations_AddressID");

            entity.Property(e => e.AddressRelationId).HasColumnName("AddressRelationID");
            entity.Property(e => e.AddressId).HasColumnName("AddressID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.JobDescriptionId).HasColumnName("JobDescriptionID");
            entity.Property(e => e.ResumeId).HasColumnName("ResumeID");

            entity.HasOne(d => d.Address).WithMany(p => p.AddressRelations)
                .HasForeignKey(d => d.AddressId)
                .HasConstraintName("FK_AddressRealations_Addresses");
        });

        modelBuilder.Entity<ApplicationRecord>(entity =>
        {
            entity.HasIndex(e => e.CandidateId, "IX_ApplicationRecords_CandidateID");

            entity.HasIndex(e => e.CompanyId, "IX_ApplicationRecords_CompanyID");

            entity.HasIndex(e => e.JobDescriptionId, "IX_ApplicationRecords_JobDescriptionID");

            entity.HasIndex(e => e.ResumeSnapshotId, "IX_ApplicationRecords_ResumeSnapshotID");

            entity.Property(e => e.ApplicationRecordId)
                .ValueGeneratedNever()
                .HasColumnName("ApplicationRecordID");
            entity.Property(e => e.CandidateId).HasColumnName("CandidateID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateAt).HasColumnType("datetime");
            entity.Property(e => e.JobDescriptionId).HasColumnName("JobDescriptionID");
            entity.Property(e => e.ResumeSnapshotId).HasColumnName("ResumeSnapshotID");

            entity.HasOne(d => d.Candidate).WithMany(p => p.ApplicationRecords)
                .HasForeignKey(d => d.CandidateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ApplicationRecords_Candidates");

            entity.HasOne(d => d.Company).WithMany(p => p.ApplicationRecords)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ApplicationRecords_Companies");

            entity.HasOne(d => d.JobDescription).WithMany(p => p.ApplicationRecords)
                .HasForeignKey(d => d.JobDescriptionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ApplicationRecords_JobDescriptions");

            entity.HasOne(d => d.ResumeSnapshot).WithMany(p => p.ApplicationRecords)
                .HasForeignKey(d => d.ResumeSnapshotId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ApplicationRecords_ResumeSnapshots");
        });

        modelBuilder.Entity<BoostOrder>(entity =>
        {
            entity.HasIndex(e => e.CompanyId, "IX_BoostOrders_CompanyID");

            entity.Property(e => e.BoostOrderId).HasColumnName("BoostOrderID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.DueAt).HasColumnType("datetime");
            entity.Property(e => e.OrderAt).HasColumnType("datetime");
            entity.Property(e => e.Price).HasColumnName("price");

            entity.HasOne(d => d.Company).WithMany(p => p.BoostOrders)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BoostOrders_Companies");
        });

        modelBuilder.Entity<BoostUsed>(entity =>
        {
            entity.ToTable("BoostUsed");

            entity.HasIndex(e => e.CompanyId, "IX_BoostUsed_CompanyID");

            entity.Property(e => e.BoostUsedId).HasColumnName("BoostUsedID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.JobDescriptionId).HasColumnName("JobDescriptionID");
            entity.Property(e => e.UsedAt).HasColumnType("datetime");

            entity.HasOne(d => d.Company).WithMany(p => p.BoostUseds)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BoostUsed_Companies");
        });

        modelBuilder.Entity<Candidate>(entity =>
        {
            entity.Property(e => e.CandidateId).HasColumnName("CandidateID");
            entity.Property(e => e.CandidateAccount)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.CreateAt).HasColumnType("datetime");
            entity.Property(e => e.Email)
                .IsRequired()
                .HasMaxLength(255);
            entity.Property(e => e.MobilePhone)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.Password)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.PhotoUrl).HasColumnName("PhotoURL");
        });

        modelBuilder.Entity<ChatMessage>(entity =>
        {
            entity.HasKey(e => e.MessageId);

            entity.HasIndex(e => e.CandidateId, "IX_ChatMessages_CandidateID");

            entity.HasIndex(e => e.CompanyId, "IX_ChatMessages_CompanyID");

            entity.Property(e => e.MessageId).HasColumnName("MessageID");
            entity.Property(e => e.CandidateId).HasColumnName("CandidateID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateAt).HasColumnType("datetime");
            entity.Property(e => e.JobDescriptionId).HasColumnName("JobDescriptionID");
            entity.Property(e => e.MessageContent).IsRequired();

            entity.HasOne(d => d.Candidate).WithMany(p => p.ChatMessages)
                .HasForeignKey(d => d.CandidateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ChatMessages_Candidates");

            entity.HasOne(d => d.Company).WithMany(p => p.ChatMessages)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ChatMessages_Companies");
        });

        modelBuilder.Entity<City>(entity =>
        {
            entity.Property(e => e.CityId).HasColumnName("CityID");
            entity.Property(e => e.CityName)
                .IsRequired()
                .HasMaxLength(20);
            entity.Property(e => e.CreateAt).HasColumnType("datetime");
            entity.Property(e => e.UpdateAt).HasColumnType("datetime");
        });

        modelBuilder.Entity<CollectionCompany>(entity =>
        {
            entity.HasIndex(e => e.CandidateId, "IX_CollectionCompanies_CandidateID");

            entity.HasIndex(e => e.CompanyId, "IX_CollectionCompanies_CompanyID");

            entity.Property(e => e.CollectionCompanyId).HasColumnName("CollectionCompanyID");
            entity.Property(e => e.CandidateId).HasColumnName("CandidateID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateAt).HasColumnType("datetime");

            entity.HasOne(d => d.Candidate).WithMany(p => p.CollectionCompanies)
                .HasForeignKey(d => d.CandidateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CollectionCompanies_Candidates");

            entity.HasOne(d => d.Company).WithMany(p => p.CollectionCompanies)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CollectionCompanies_Companies");
        });

        modelBuilder.Entity<CollectionJob>(entity =>
        {
            entity.HasIndex(e => e.CandidateId, "IX_CollectionJobs_CandidateID");

            entity.HasIndex(e => e.JobDescriptionId, "IX_CollectionJobs_JobDescriptionID");

            entity.Property(e => e.CollectionJobId).HasColumnName("CollectionJobID");
            entity.Property(e => e.CandidateId).HasColumnName("CandidateID");
            entity.Property(e => e.CreateAt).HasColumnType("datetime");
            entity.Property(e => e.JobDescriptionId).HasColumnName("JobDescriptionID");

            entity.HasOne(d => d.Candidate).WithMany(p => p.CollectionJobs)
                .HasForeignKey(d => d.CandidateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CollectionJobs_Candidates");

            entity.HasOne(d => d.JobDescription).WithMany(p => p.CollectionJobs)
                .HasForeignKey(d => d.JobDescriptionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CollectionJobs_JobDescriptions");
        });

        modelBuilder.Entity<Company>(entity =>
        {
            entity.Property(e => e.CompanyId)
                .ValueGeneratedNever()
                .HasColumnName("CompanyID");
            entity.Property(e => e.CompanyAccount)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.CompanyName)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.CompanyPhone)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.CreateAt).HasColumnType("datetime");
            entity.Property(e => e.Email)
                .IsRequired()
                .HasMaxLength(255);
            entity.Property(e => e.FreeDate).HasColumnType("datetime");
            entity.Property(e => e.MembershipDate).HasColumnType("datetime");
            entity.Property(e => e.Password)
                .IsRequired()
                .HasMaxLength(50);

            entity.HasOne(d => d.CompanyNavigation).WithOne(p => p.Company)
                .HasForeignKey<Company>(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Companies_CompanyProfiles");
        });

        modelBuilder.Entity<CompanyFeatureCategory>(entity =>
        {
            entity.HasKey(e => e.CompanyFeatureCategoryId).HasName("PK_CompanyWelfareCategories");

            entity.ToTable("CompanyFeatureCategory");

            entity.Property(e => e.CompanyFeatureCategoryId).HasColumnName("CompanyFeatureCategoryID");
            entity.Property(e => e.CompanyFeatureCategoryName)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.CreateAt).HasColumnType("datetime");
            entity.Property(e => e.UpdateAt).HasColumnType("datetime");
        });

        modelBuilder.Entity<CompanyFeatureRelation>(entity =>
        {
            entity.HasKey(e => e.CompanyFeatureRelationId).HasName("PK_CompanyWelfare");

            entity.HasIndex(e => e.CompanyFeatureCategoryId, "IX_CompanyFeatureRelations_CompanyFeatureCategoryID");

            entity.HasIndex(e => e.CompanyId, "IX_CompanyFeatureRelations_CompanyID");

            entity.Property(e => e.CompanyFeatureRelationId).HasColumnName("CompanyFeatureRelationID");
            entity.Property(e => e.CompanyFeatureCategoryId).HasColumnName("CompanyFeatureCategoryID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateAt).HasColumnType("datetime");
            entity.Property(e => e.UpdateAt).HasColumnType("datetime");

            entity.HasOne(d => d.CompanyFeatureCategory).WithMany(p => p.CompanyFeatureRelations)
                .HasForeignKey(d => d.CompanyFeatureCategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CompanyFeatureRelations_CompanyFeatureCategory");

            entity.HasOne(d => d.Company).WithMany(p => p.CompanyFeatureRelations)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CompanyFeatureRelations_CompanyProfiles");
        });

        modelBuilder.Entity<CompanyProfile>(entity =>
        {
            entity.HasKey(e => e.CompanyId);

            entity.HasIndex(e => e.IndustryCategoryId, "IX_CompanyProfiles_IndustryCategoryID");

            entity.Property(e => e.CompanyId)
                .ValueGeneratedNever()
                .HasColumnName("CompanyID");
            entity.Property(e => e.Address).IsRequired();
            entity.Property(e => e.CreateAt).HasColumnType("datetime");
            entity.Property(e => e.Fax).HasMaxLength(20);
            entity.Property(e => e.IndustryCategoryId).HasColumnName("IndustryCategoryID");
            entity.Property(e => e.Introduction).IsRequired();
            entity.Property(e => e.PersonnelContact)
                .IsRequired()
                .HasMaxLength(20);
            entity.Property(e => e.ProductContent).IsRequired();
            entity.Property(e => e.UpdateAt).HasColumnType("datetime");
            entity.Property(e => e.WelfareDesc).IsRequired();

            entity.HasOne(d => d.IndustryCategory).WithMany(p => p.CompanyProfiles)
                .HasForeignKey(d => d.IndustryCategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CompanyProfiles_IndustryCategories");
        });

        modelBuilder.Entity<District>(entity =>
        {
            entity.HasIndex(e => e.CityId, "IX_Districts_CityID");

            entity.Property(e => e.DistrictId).HasColumnName("DistrictID");
            entity.Property(e => e.CityId).HasColumnName("CityID");
            entity.Property(e => e.CreateAt).HasColumnType("datetime");
            entity.Property(e => e.DistrictName)
                .IsRequired()
                .HasMaxLength(20);
            entity.Property(e => e.UpdateAt).HasColumnType("datetime");

            entity.HasOne(d => d.City).WithMany(p => p.Districts)
                .HasForeignKey(d => d.CityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Districts_Cities");
        });

        modelBuilder.Entity<EmployeeCategory>(entity =>
        {
            entity.HasIndex(e => e.IndustryCategoryId, "IX_EmployeeCategories_IndustryCategoryID");

            entity.Property(e => e.EmployeeCategoryId).HasColumnName("EmployeeCategoryID");
            entity.Property(e => e.CreateAt).HasColumnType("datetime");
            entity.Property(e => e.EmployeeCategoryName)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.IndustryCategoryId).HasColumnName("IndustryCategoryID");

            entity.HasOne(d => d.IndustryCategory).WithMany(p => p.EmployeeCategories)
                .HasForeignKey(d => d.IndustryCategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeCategories_IndustryCategories");
        });

        modelBuilder.Entity<EnvironmentPic>(entity =>
        {
            entity.HasIndex(e => e.CompanyId, "IX_EnvironmentPics_CompanyID");

            entity.Property(e => e.EnvironmentPicId).HasColumnName("EnvironmentPicID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateAt).HasColumnType("datetime");
            entity.Property(e => e.EnvironmentPicPath).IsRequired();
            entity.Property(e => e.UpdateAt).HasColumnType("datetime");

            entity.HasOne(d => d.Company).WithMany(p => p.EnvironmentPics)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EnvironmentPics_Companies");
        });

        modelBuilder.Entity<IndustryCategory>(entity =>
        {
            entity.Property(e => e.IndustryCategoryId).HasColumnName("IndustryCategoryID");
            entity.Property(e => e.CreateAt).HasColumnType("datetime");
            entity.Property(e => e.IndustryCategoryName)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.UpdateAt).HasColumnType("datetime");
        });

        modelBuilder.Entity<JobCategory>(entity =>
        {
            entity.HasIndex(e => e.EmployeeCategoryId, "IX_JobCategories_EmployeeCategoryID");

            entity.Property(e => e.JobCategoryId).HasColumnName("JobCategoryID");
            entity.Property(e => e.CreateAt).HasColumnType("datetime");
            entity.Property(e => e.EmployeeCategoryId).HasColumnName("EmployeeCategoryID");
            entity.Property(e => e.JobCategoryName)
                .IsRequired()
                .HasMaxLength(100);

            entity.HasOne(d => d.EmployeeCategory).WithMany(p => p.JobCategories)
                .HasForeignKey(d => d.EmployeeCategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_JobCategories_EmployeeCategories");
        });

        modelBuilder.Entity<JobDescription>(entity =>
        {
            entity.HasIndex(e => e.CompanyId, "IX_JobDescriptions_CompanyID");

            entity.HasIndex(e => e.JobCategoryId, "IX_JobDescriptions_JobCategoryID");

            entity.Property(e => e.JobDescriptionId)
                .ValueGeneratedNever()
                .HasColumnName("JobDescriptionID");
            entity.Property(e => e.Address).IsRequired();
            entity.Property(e => e.BoostEndAt).HasColumnType("datetime");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.ComputerSkill).IsRequired();
            entity.Property(e => e.ContactAddress).IsRequired();
            entity.Property(e => e.ContactEmail).IsRequired();
            entity.Property(e => e.ContactName)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.ContactPhone)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.CreateAt).HasColumnType("datetime");
            entity.Property(e => e.DrivingLicense).IsRequired();
            entity.Property(e => e.EducationId).HasColumnName("EducationID");
            entity.Property(e => e.EmploymentCategoryId).HasColumnName("EmploymentCategoryID");
            entity.Property(e => e.JobCategoryId).HasColumnName("JobCategoryID");
            entity.Property(e => e.JobDetail).IsRequired();
            entity.Property(e => e.JobId)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("JobID");
            entity.Property(e => e.JobShiftId).HasColumnName("JobShiftID");
            entity.Property(e => e.JobTenureId).HasColumnName("JobTenureID");
            entity.Property(e => e.JobTitle).IsRequired();
            entity.Property(e => e.Language).IsRequired();
            entity.Property(e => e.PostEndAt).HasColumnType("datetime");
            entity.Property(e => e.PostStartAt).HasColumnType("datetime");
            entity.Property(e => e.SalaryPaymentId).HasColumnName("SalaryPaymentID");
            entity.Property(e => e.UpdateAt).HasColumnType("datetime");
            entity.Property(e => e.WorkingHours).IsRequired();

            entity.HasOne(d => d.Company).WithMany(p => p.JobDescriptions)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_JobDescriptions_CompanyProfiles");

            entity.HasOne(d => d.JobCategory).WithMany(p => p.JobDescriptions)
                .HasForeignKey(d => d.JobCategoryId)
                .HasConstraintName("FK_JobDescriptions_JobCategories");

            entity.HasOne(d => d.JobDescriptionNavigation).WithOne(p => p.JobDescription)
                .HasForeignKey<JobDescription>(d => d.JobDescriptionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_JobDescriptions_BoostUsed");
        });

        modelBuilder.Entity<JobFeature>(entity =>
        {
            entity.Property(e => e.JobFeatureId).HasColumnName("JobFeatureID");
            entity.Property(e => e.JobFeatures)
                .IsRequired()
                .HasMaxLength(50);
        });

        modelBuilder.Entity<JobFeaturesRelation>(entity =>
        {
            entity.HasIndex(e => e.JobDescriptionId, "IX_JobFeaturesRelations_JobDescriptionID");

            entity.HasIndex(e => e.JobFeatureId, "IX_JobFeaturesRelations_JobFeatureID");

            entity.Property(e => e.JobFeaturesRelationId).HasColumnName("JobFeaturesRelationID");
            entity.Property(e => e.JobDescriptionId).HasColumnName("JobDescriptionID");
            entity.Property(e => e.JobFeatureId).HasColumnName("JobFeatureID");

            entity.HasOne(d => d.JobDescription).WithMany(p => p.JobFeaturesRelations)
                .HasForeignKey(d => d.JobDescriptionId)
                .HasConstraintName("FK_JobFeaturesRelations_JobDescriptions");

            entity.HasOne(d => d.JobFeature).WithMany(p => p.JobFeaturesRelations)
                .HasForeignKey(d => d.JobFeatureId)
                .HasConstraintName("FK_JobFeaturesRelations_JobFeatures");
        });

        modelBuilder.Entity<MembershipCategory>(entity =>
        {
            entity.Property(e => e.MembershipCategoryId).HasColumnName("MembershipCategoryID");
            entity.Property(e => e.CreateAt).HasColumnType("datetime");
            entity.Property(e => e.MembershipName)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.UpdateAt).HasColumnType("datetime");
        });

        modelBuilder.Entity<MembershipOrder>(entity =>
        {
            entity.HasIndex(e => e.CompanyId, "IX_MembershipOrders_CompanyID");

            entity.Property(e => e.MembershipOrderId).HasColumnName("MembershipOrderID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.DueAt).HasColumnType("datetime");
            entity.Property(e => e.MembershipCategoryId).HasColumnName("MembershipCategoryID");
            entity.Property(e => e.OrderAt).HasColumnType("datetime");

            entity.HasOne(d => d.Company).WithMany(p => p.MembershipOrders)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MembershipOrders_Companies");
        });

        modelBuilder.Entity<RecentlyViewedJob>(entity =>
        {
            entity.HasKey(e => e.RecentlyViewedJobsId);

            entity.Property(e => e.RecentlyViewedJobsId)
                .ValueGeneratedNever()
                .HasColumnName("RecentlyViewedJobsID");
            entity.Property(e => e.BrowsingTime).HasColumnType("datetime");
            entity.Property(e => e.CandidateId)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("CandidateID");
            entity.Property(e => e.JobId)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("JobID");
        });

        modelBuilder.Entity<Resume>(entity =>
        {
            entity.HasIndex(e => e.CandidateId, "IX_Resumes_CandidateID");

            entity.Property(e => e.ResumeId).HasColumnName("ResumeID");
            entity.Property(e => e.Address)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.Autobiography).IsRequired();
            entity.Property(e => e.CandidateId).HasColumnName("CandidateID");
            entity.Property(e => e.CreateAt).HasColumnType("datetime");
            entity.Property(e => e.EducationId).HasColumnName("EducationID");
            entity.Property(e => e.EmploymentCategoryId).HasColumnName("EmploymentCategoryID");
            entity.Property(e => e.GraduationSchool)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.MajorIn)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.ResumeName)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.UpdateAt).HasColumnType("datetime");

            entity.HasOne(d => d.Candidate).WithMany(p => p.Resumes)
                .HasForeignKey(d => d.CandidateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Resumes_Candidates");
        });

        modelBuilder.Entity<ResumeSnapshot>(entity =>
        {
            entity.HasIndex(e => e.ApplicationRecordId, "IX_ResumeSnapshots_ApplicationRecordID");

            entity.Property(e => e.ResumeSnapshotId).HasColumnName("ResumeSnapshotID");
            entity.Property(e => e.Address)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.ApplicationRecordId).HasColumnName("ApplicationRecordID");
            entity.Property(e => e.Autobiography).IsRequired();
            entity.Property(e => e.EducationId).HasColumnName("EducationID");
            entity.Property(e => e.EmploymentCategoryId).HasColumnName("EmploymentCategoryID");
            entity.Property(e => e.GraduationSchool)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.MajorIn)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.PhotoUrl).IsRequired();
        });

        modelBuilder.Entity<WorkExpSnapshot>(entity =>
        {
            entity.HasIndex(e => e.ResumeSnapshotId, "IX_WorkExpSnapshots_ResumeSnapshotID");

            entity.Property(e => e.WorkExpSnapshotId).HasColumnName("WorkExpSnapshotID");
            entity.Property(e => e.CompanyName)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.IndustryCategoryId).HasColumnName("IndustryCategoryID");
            entity.Property(e => e.JobCategoryId).HasColumnName("JobCategoryID");
            entity.Property(e => e.JobTitle)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.ResumeSnapshotId).HasColumnName("ResumeSnapshotID");
            entity.Property(e => e.TenureEnd).HasColumnType("datetime");
            entity.Property(e => e.TenureStart).HasColumnType("datetime");

            entity.HasOne(d => d.ResumeSnapshot).WithMany(p => p.WorkExpSnapshots)
                .HasForeignKey(d => d.ResumeSnapshotId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WorkExpSnapshots_ResumeSnapshots");
        });

        modelBuilder.Entity<WorkExperience>(entity =>
        {
            entity.HasIndex(e => e.ResumeId, "IX_WorkExperiences_ResumeID");

            entity.Property(e => e.WorkExperienceId).HasColumnName("WorkExperienceID");
            entity.Property(e => e.CompanyName)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.CreateAt).HasColumnType("datetime");
            entity.Property(e => e.IndustryCategoryId).HasColumnName("IndustryCategoryID");
            entity.Property(e => e.JobCategoryId).HasColumnName("JobCategoryID");
            entity.Property(e => e.JobTitle)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.ResumeId).HasColumnName("ResumeID");
            entity.Property(e => e.TenureEnd).HasColumnType("datetime");
            entity.Property(e => e.TenureStart).HasColumnType("datetime");
            entity.Property(e => e.UpdateAt).HasColumnType("datetime");

            entity.HasOne(d => d.Resume).WithMany(p => p.WorkExperiences)
                .HasForeignKey(d => d.ResumeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WorkExperiences_Resumes");
        });

        modelBuilder.Entity<WorkShare>(entity =>
        {
            entity.HasIndex(e => e.CandidateId, "IX_WorkShares_CandidateID");

            entity.HasIndex(e => e.CompanyId, "IX_WorkShares_CompanyID");

            entity.HasIndex(e => e.JobCategoryId, "IX_WorkShares_JobCategoryID");

            entity.Property(e => e.WorkShareId).HasColumnName("WorkShareID");
            entity.Property(e => e.CandidateId).HasColumnName("CandidateID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateAt).HasColumnType("datetime");
            entity.Property(e => e.JobCategoryId).HasColumnName("JobCategoryID");
            entity.Property(e => e.ShareContent).IsRequired();
            entity.Property(e => e.UpdateAt).HasColumnType("datetime");

            entity.HasOne(d => d.Candidate).WithMany(p => p.WorkShares)
                .HasForeignKey(d => d.CandidateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WorkShares_Candidates");

            entity.HasOne(d => d.Company).WithMany(p => p.WorkShares)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WorkShares_Companies");

            entity.HasOne(d => d.JobCategory).WithMany(p => p.WorkShares)
                .HasForeignKey(d => d.JobCategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WorkShares_JobCategories");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

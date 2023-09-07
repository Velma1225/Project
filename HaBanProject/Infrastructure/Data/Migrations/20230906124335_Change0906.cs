using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class Change0906 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Candidates",
                columns: table => new
                {
                    CandidateID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CandidateAccount = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    MobilePhone = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    PhotoURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Candidates", x => x.CandidateID);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    CityID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.CityID);
                });

            migrationBuilder.CreateTable(
                name: "CompanyFeatureCategory",
                columns: table => new
                {
                    CompanyFeatureCategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyFeatureCategoryName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyWelfareCategories", x => x.CompanyFeatureCategoryID);
                });

            migrationBuilder.CreateTable(
                name: "IndustryCategories",
                columns: table => new
                {
                    IndustryCategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IndustryCategoryName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IndustryCategories", x => x.IndustryCategoryID);
                });

            migrationBuilder.CreateTable(
                name: "JobFeatures",
                columns: table => new
                {
                    JobFeatureID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobFeatures = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobFeatures", x => x.JobFeatureID);
                });

            migrationBuilder.CreateTable(
                name: "MembershipCategories",
                columns: table => new
                {
                    MembershipCategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MembershipName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UnitPrice = table.Column<int>(type: "int", nullable: false),
                    DiscountPrice = table.Column<int>(type: "int", nullable: false),
                    TotalDate = table.Column<int>(type: "int", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MembershipCategories", x => x.MembershipCategoryID);
                });

            migrationBuilder.CreateTable(
                name: "RecentlyViewedJobs",
                columns: table => new
                {
                    RecentlyViewedJobsID = table.Column<int>(type: "int", nullable: false),
                    CandidateID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BrowsingTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    JobID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecentlyViewedJobs", x => x.RecentlyViewedJobsID);
                });

            migrationBuilder.CreateTable(
                name: "ResumeSnapshots",
                columns: table => new
                {
                    ResumeSnapshotID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationRecordID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: true),
                    EmploymentCategoryID = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    GraduationSchool = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MajorIn = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EducationID = table.Column<int>(type: "int", nullable: false),
                    PhotoUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Autobiography = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Language = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DrivingLicense = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ComputerSkill = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResumeSnapshots", x => x.ResumeSnapshotID);
                });

            migrationBuilder.CreateTable(
                name: "Resumes",
                columns: table => new
                {
                    ResumeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CandidateID = table.Column<int>(type: "int", nullable: false),
                    ResumeName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Age = table.Column<int>(type: "int", nullable: true),
                    EmploymentCategoryID = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    GraduationSchool = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MajorIn = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EducationID = table.Column<int>(type: "int", nullable: false),
                    Autobiography = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Language = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DrivingLicense = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ComputerSkill = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    OpenOrClosed = table.Column<bool>(type: "bit", nullable: false),
                    Rank = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resumes", x => x.ResumeID);
                    table.ForeignKey(
                        name: "FK_Resumes_Candidates",
                        column: x => x.CandidateID,
                        principalTable: "Candidates",
                        principalColumn: "CandidateID");
                });

            migrationBuilder.CreateTable(
                name: "Districts",
                columns: table => new
                {
                    DistrictID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DistrictName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CityID = table.Column<int>(type: "int", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Districts", x => x.DistrictID);
                    table.ForeignKey(
                        name: "FK_Districts_Cities",
                        column: x => x.CityID,
                        principalTable: "Cities",
                        principalColumn: "CityID");
                });

            migrationBuilder.CreateTable(
                name: "CompanyProfiles",
                columns: table => new
                {
                    CompanyID = table.Column<int>(type: "int", nullable: false),
                    StaffQuantity = table.Column<int>(type: "int", nullable: true),
                    IndustryCategoryID = table.Column<int>(type: "int", nullable: false),
                    PersonnelContact = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Fax = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    CompanySite = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Introduction = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gift = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Insurance = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WelfareDesc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyProfiles", x => x.CompanyID);
                    table.ForeignKey(
                        name: "FK_CompanyProfiles_IndustryCategories",
                        column: x => x.IndustryCategoryID,
                        principalTable: "IndustryCategories",
                        principalColumn: "IndustryCategoryID");
                });

            migrationBuilder.CreateTable(
                name: "EmployeeCategories",
                columns: table => new
                {
                    EmployeeCategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeCategoryName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IndustryCategoryID = table.Column<int>(type: "int", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeCategories", x => x.EmployeeCategoryID);
                    table.ForeignKey(
                        name: "FK_EmployeeCategories_IndustryCategories",
                        column: x => x.IndustryCategoryID,
                        principalTable: "IndustryCategories",
                        principalColumn: "IndustryCategoryID");
                });

            migrationBuilder.CreateTable(
                name: "WorkExpSnapshots",
                columns: table => new
                {
                    WorkExpSnapshotID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResumeSnapshotID = table.Column<int>(type: "int", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IndustryCategoryID = table.Column<int>(type: "int", nullable: false),
                    JobTitle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    JobNature = table.Column<int>(type: "int", nullable: false),
                    JobCategoryID = table.Column<int>(type: "int", nullable: false),
                    Management = table.Column<bool>(type: "bit", nullable: false),
                    TenureStart = table.Column<DateTime>(type: "datetime", nullable: false),
                    TenureEnd = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkExpSnapshots", x => x.WorkExpSnapshotID);
                    table.ForeignKey(
                        name: "FK_WorkExpSnapshots_ResumeSnapshots",
                        column: x => x.ResumeSnapshotID,
                        principalTable: "ResumeSnapshots",
                        principalColumn: "ResumeSnapshotID");
                });

            migrationBuilder.CreateTable(
                name: "WorkExperiences",
                columns: table => new
                {
                    WorkExperienceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResumeID = table.Column<int>(type: "int", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IndustryCategoryID = table.Column<int>(type: "int", nullable: false),
                    JobTitle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    JobNature = table.Column<int>(type: "int", nullable: false),
                    JobCategoryID = table.Column<int>(type: "int", nullable: false),
                    Management = table.Column<bool>(type: "bit", nullable: false),
                    TenureStart = table.Column<DateTime>(type: "datetime", nullable: false),
                    TenureEnd = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkExperiences", x => x.WorkExperienceID);
                    table.ForeignKey(
                        name: "FK_WorkExperiences_Resumes",
                        column: x => x.ResumeID,
                        principalTable: "Resumes",
                        principalColumn: "ResumeID");
                });

            migrationBuilder.CreateTable(
                name: "AddressDetails",
                columns: table => new
                {
                    AddressDetailID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Latitude = table.Column<decimal>(type: "decimal(10,8)", nullable: false),
                    Longitude = table.Column<decimal>(type: "decimal(11,8)", nullable: false),
                    DistrictID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.AddressDetailID);
                    table.ForeignKey(
                        name: "FK_Addresses_Districts",
                        column: x => x.DistrictID,
                        principalTable: "Districts",
                        principalColumn: "DistrictID");
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    CompanyID = table.Column<int>(type: "int", nullable: false),
                    CompanyAccount = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LogoUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyPhone = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    BoostNumber = table.Column<int>(type: "int", nullable: false),
                    MembershipDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    FreeDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.CompanyID);
                    table.ForeignKey(
                        name: "FK_Companies_CompanyProfiles",
                        column: x => x.CompanyID,
                        principalTable: "CompanyProfiles",
                        principalColumn: "CompanyID");
                });

            migrationBuilder.CreateTable(
                name: "CompanyFeatureRelations",
                columns: table => new
                {
                    CompanyFeatureRelationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyID = table.Column<int>(type: "int", nullable: false),
                    CompanyFeatureCategoryID = table.Column<int>(type: "int", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyWelfare", x => x.CompanyFeatureRelationID);
                    table.ForeignKey(
                        name: "FK_CompanyFeatureRelations_CompanyFeatureCategory",
                        column: x => x.CompanyFeatureCategoryID,
                        principalTable: "CompanyFeatureCategory",
                        principalColumn: "CompanyFeatureCategoryID");
                    table.ForeignKey(
                        name: "FK_CompanyFeatureRelations_CompanyProfiles",
                        column: x => x.CompanyID,
                        principalTable: "CompanyProfiles",
                        principalColumn: "CompanyID");
                });

            migrationBuilder.CreateTable(
                name: "JobCategories",
                columns: table => new
                {
                    JobCategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobCategoryName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    EmployeeCategoryID = table.Column<int>(type: "int", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobCategories", x => x.JobCategoryID);
                    table.ForeignKey(
                        name: "FK_JobCategories_EmployeeCategories",
                        column: x => x.EmployeeCategoryID,
                        principalTable: "EmployeeCategories",
                        principalColumn: "EmployeeCategoryID");
                });

            migrationBuilder.CreateTable(
                name: "AddressRelations",
                columns: table => new
                {
                    AddressRelationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddressID = table.Column<int>(type: "int", nullable: true),
                    CompanyID = table.Column<int>(type: "int", nullable: true),
                    JobDescriptionID = table.Column<int>(type: "int", nullable: true),
                    ResumeID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddressRealations", x => x.AddressRelationID);
                    table.ForeignKey(
                        name: "FK_AddressRealations_Addresses",
                        column: x => x.AddressID,
                        principalTable: "AddressDetails",
                        principalColumn: "AddressDetailID");
                });

            migrationBuilder.CreateTable(
                name: "BoostOrders",
                columns: table => new
                {
                    BoostOrderID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyID = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    price = table.Column<int>(type: "int", nullable: false),
                    OrderAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    DueAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    Online = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BoostOrders", x => x.BoostOrderID);
                    table.ForeignKey(
                        name: "FK_BoostOrders_Companies",
                        column: x => x.CompanyID,
                        principalTable: "Companies",
                        principalColumn: "CompanyID");
                });

            migrationBuilder.CreateTable(
                name: "BoostUsed",
                columns: table => new
                {
                    BoostUsedID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    UsedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    JobDescriptionID = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<int>(type: "int", nullable: false),
                    CompanyID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BoostUsed", x => x.BoostUsedID);
                    table.ForeignKey(
                        name: "FK_BoostUsed_Companies",
                        column: x => x.CompanyID,
                        principalTable: "Companies",
                        principalColumn: "CompanyID");
                });

            migrationBuilder.CreateTable(
                name: "ChatMessages",
                columns: table => new
                {
                    MessageID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    MessageContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SenderAccount = table.Column<bool>(type: "bit", nullable: false),
                    ReadStatus = table.Column<bool>(type: "bit", nullable: false),
                    CandidateID = table.Column<int>(type: "int", nullable: false),
                    CompanyID = table.Column<int>(type: "int", nullable: false),
                    JobDescriptionID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChatMessages", x => x.MessageID);
                    table.ForeignKey(
                        name: "FK_ChatMessages_Candidates",
                        column: x => x.CandidateID,
                        principalTable: "Candidates",
                        principalColumn: "CandidateID");
                    table.ForeignKey(
                        name: "FK_ChatMessages_Companies",
                        column: x => x.CompanyID,
                        principalTable: "Companies",
                        principalColumn: "CompanyID");
                });

            migrationBuilder.CreateTable(
                name: "CollectionCompanies",
                columns: table => new
                {
                    CollectionCompanyID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyID = table.Column<int>(type: "int", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    CandidateID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CollectionCompanies", x => x.CollectionCompanyID);
                    table.ForeignKey(
                        name: "FK_CollectionCompanies_Candidates",
                        column: x => x.CandidateID,
                        principalTable: "Candidates",
                        principalColumn: "CandidateID");
                    table.ForeignKey(
                        name: "FK_CollectionCompanies_Companies",
                        column: x => x.CompanyID,
                        principalTable: "Companies",
                        principalColumn: "CompanyID");
                });

            migrationBuilder.CreateTable(
                name: "EnvironmentPics",
                columns: table => new
                {
                    EnvironmentPicID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyID = table.Column<int>(type: "int", nullable: false),
                    EnvironmentPicPath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnvironmentPics", x => x.EnvironmentPicID);
                    table.ForeignKey(
                        name: "FK_EnvironmentPics_Companies",
                        column: x => x.CompanyID,
                        principalTable: "Companies",
                        principalColumn: "CompanyID");
                });

            migrationBuilder.CreateTable(
                name: "MembershipOrders",
                columns: table => new
                {
                    MembershipOrderID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MembershipCategoryID = table.Column<int>(type: "int", nullable: false),
                    OrderAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    CompanyID = table.Column<int>(type: "int", nullable: false),
                    DueAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UnitPrice = table.Column<int>(type: "int", nullable: false),
                    Online = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MembershipOrders", x => x.MembershipOrderID);
                    table.ForeignKey(
                        name: "FK_MembershipOrders_Companies",
                        column: x => x.CompanyID,
                        principalTable: "Companies",
                        principalColumn: "CompanyID");
                });

            migrationBuilder.CreateTable(
                name: "WorkShares",
                columns: table => new
                {
                    WorkShareID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyID = table.Column<int>(type: "int", nullable: false),
                    CandidateID = table.Column<int>(type: "int", nullable: false),
                    Evaluation = table.Column<int>(type: "int", nullable: false),
                    ShareContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobCategoryID = table.Column<int>(type: "int", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkShares", x => x.WorkShareID);
                    table.ForeignKey(
                        name: "FK_WorkShares_Candidates",
                        column: x => x.CandidateID,
                        principalTable: "Candidates",
                        principalColumn: "CandidateID");
                    table.ForeignKey(
                        name: "FK_WorkShares_Companies",
                        column: x => x.CompanyID,
                        principalTable: "Companies",
                        principalColumn: "CompanyID");
                    table.ForeignKey(
                        name: "FK_WorkShares_JobCategories",
                        column: x => x.JobCategoryID,
                        principalTable: "JobCategories",
                        principalColumn: "JobCategoryID");
                });

            migrationBuilder.CreateTable(
                name: "JobDescriptions",
                columns: table => new
                {
                    JobDescriptionID = table.Column<int>(type: "int", nullable: false),
                    JobID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CompanyID = table.Column<int>(type: "int", nullable: false),
                    JobTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobDetail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SalaryPaymentID = table.Column<int>(type: "int", nullable: false),
                    MinSalary = table.Column<int>(type: "int", nullable: true),
                    MaxSalary = table.Column<int>(type: "int", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobShiftID = table.Column<int>(type: "int", nullable: false),
                    WorkingHours = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobCategoryID = table.Column<int>(type: "int", nullable: true),
                    EmploymentCategoryID = table.Column<int>(type: "int", nullable: false),
                    IsManager = table.Column<bool>(type: "bit", nullable: false),
                    JobTenureID = table.Column<int>(type: "int", nullable: false),
                    EducationID = table.Column<int>(type: "int", nullable: false),
                    Language = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DrivingLicense = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ComputerSkill = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VacancyNumber = table.Column<int>(type: "int", nullable: false),
                    ContactName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ContactEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactPhone = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ContactAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostScript = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    PostStartAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    PostEndAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    BoostEndAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsPosted = table.Column<bool>(type: "bit", nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobDescriptions", x => x.JobDescriptionID);
                    table.ForeignKey(
                        name: "FK_JobDescriptions_BoostUsed",
                        column: x => x.JobDescriptionID,
                        principalTable: "BoostUsed",
                        principalColumn: "BoostUsedID");
                    table.ForeignKey(
                        name: "FK_JobDescriptions_CompanyProfiles",
                        column: x => x.CompanyID,
                        principalTable: "CompanyProfiles",
                        principalColumn: "CompanyID");
                    table.ForeignKey(
                        name: "FK_JobDescriptions_JobCategories",
                        column: x => x.JobCategoryID,
                        principalTable: "JobCategories",
                        principalColumn: "JobCategoryID");
                });

            migrationBuilder.CreateTable(
                name: "ApplicationRecords",
                columns: table => new
                {
                    ApplicationRecordID = table.Column<int>(type: "int", nullable: false),
                    CompanyID = table.Column<int>(type: "int", nullable: false),
                    CandidateID = table.Column<int>(type: "int", nullable: false),
                    JobDescriptionID = table.Column<int>(type: "int", nullable: false),
                    ResumeSnapshotID = table.Column<int>(type: "int", nullable: false),
                    ReadStatus = table.Column<bool>(type: "bit", nullable: false),
                    InterviewStatus = table.Column<bool>(type: "bit", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationRecords", x => x.ApplicationRecordID);
                    table.ForeignKey(
                        name: "FK_ApplicationRecords_Candidates",
                        column: x => x.CandidateID,
                        principalTable: "Candidates",
                        principalColumn: "CandidateID");
                    table.ForeignKey(
                        name: "FK_ApplicationRecords_Companies",
                        column: x => x.CompanyID,
                        principalTable: "Companies",
                        principalColumn: "CompanyID");
                    table.ForeignKey(
                        name: "FK_ApplicationRecords_JobDescriptions",
                        column: x => x.JobDescriptionID,
                        principalTable: "JobDescriptions",
                        principalColumn: "JobDescriptionID");
                    table.ForeignKey(
                        name: "FK_ApplicationRecords_ResumeSnapshots",
                        column: x => x.ResumeSnapshotID,
                        principalTable: "ResumeSnapshots",
                        principalColumn: "ResumeSnapshotID");
                });

            migrationBuilder.CreateTable(
                name: "CollectionJobs",
                columns: table => new
                {
                    CollectionJobID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CandidateID = table.Column<int>(type: "int", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    JobDescriptionID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CollectionJobs", x => x.CollectionJobID);
                    table.ForeignKey(
                        name: "FK_CollectionJobs_Candidates",
                        column: x => x.CandidateID,
                        principalTable: "Candidates",
                        principalColumn: "CandidateID");
                    table.ForeignKey(
                        name: "FK_CollectionJobs_JobDescriptions",
                        column: x => x.JobDescriptionID,
                        principalTable: "JobDescriptions",
                        principalColumn: "JobDescriptionID");
                });

            migrationBuilder.CreateTable(
                name: "JobFeaturesRelations",
                columns: table => new
                {
                    JobFeaturesRelationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobDescriptionID = table.Column<int>(type: "int", nullable: true),
                    JobFeatureID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobFeaturesRelations", x => x.JobFeaturesRelationID);
                    table.ForeignKey(
                        name: "FK_JobFeaturesRelations_JobDescriptions",
                        column: x => x.JobDescriptionID,
                        principalTable: "JobDescriptions",
                        principalColumn: "JobDescriptionID");
                    table.ForeignKey(
                        name: "FK_JobFeaturesRelations_JobFeatures",
                        column: x => x.JobFeatureID,
                        principalTable: "JobFeatures",
                        principalColumn: "JobFeatureID");
                });

            migrationBuilder.InsertData(
                table: "Candidates",
                columns: new[] { "CandidateID", "CandidateAccount", "CreateAt", "Email", "Gender", "MobilePhone", "Name", "Password", "PhotoURL" },
                values: new object[,]
                {
                    { 1, "F112233447", new DateTime(2023, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mary@gmail.com", 2, "0988888888", "王瑪莉", "Mary87654321", "Candidate-0001.png" },
                    { 2, "F443322111", new DateTime(2023, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Leo@gmail.com", 1, "0966666666", "黃小明", "Leo87654321", "Candidate-0002.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityID", "CityName", "CreateAt", "UpdateAt" },
                values: new object[,]
                {
                    { 1, "基隆市", new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "台北市", new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "新北市", new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "桃園市", new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "新竹市", new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, "新竹縣", new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "CompanyFeatureCategory",
                columns: new[] { "CompanyFeatureCategoryID", "CompanyFeatureCategoryName", "CreateAt", "UpdateAt" },
                values: new object[,]
                {
                    { 1, "上市櫃公司", new DateTime(2023, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "外商公司", new DateTime(2023, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "進修補助", new DateTime(2023, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "員購優惠", new DateTime(2023, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "IndustryCategories",
                columns: new[] { "IndustryCategoryID", "CreateAt", "IndustryCategoryName", "UpdateAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "餐飲／旅遊 ／美容美髮類", new DateTime(2023, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "資訊軟體系統類", new DateTime(2023, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "客服／門市／業務／貿易類", new DateTime(2023, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "操作／技術／維修類", new DateTime(2023, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "醫療/保健服務類", new DateTime(2023, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "JobFeatures",
                columns: new[] { "JobFeatureID", "JobFeatures" },
                values: new object[,]
                {
                    { 1, "國外駐點工作" },
                    { 2, "彈性上下班" },
                    { 3, "交通津貼" },
                    { 4, "伙食津貼" },
                    { 5, "週休二日" },
                    { 6, "無須輪班" }
                });

            migrationBuilder.InsertData(
                table: "MembershipCategories",
                columns: new[] { "MembershipCategoryID", "CreateAt", "DiscountPrice", "MembershipName", "TotalDate", "UnitPrice", "UpdateAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2800, "月繳/30天", 30, 4200, null },
                    { 2, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 5200, "季繳/90天", 120, 9000, null },
                    { 3, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 18000, "年繳/365天", 455, 32000, null }
                });

            migrationBuilder.InsertData(
                table: "ResumeSnapshots",
                columns: new[] { "ResumeSnapshotID", "Address", "Age", "ApplicationRecordID", "Autobiography", "ComputerSkill", "DrivingLicense", "EducationID", "EmploymentCategoryID", "Gender", "GraduationSchool", "Language", "MajorIn", "Name", "PhotoUrl" },
                values: new object[,]
                {
                    { 1, "台北市大安區", 28, 1, "我是國立臺北科技大學資訊工程系的學生。我充滿活力，精通英語和台語，並擅長HTML、JS和CSS。我的熱情和專業知識準備好為您的團隊貢獻。我期待著與您共同創造成功的未來！", "[{\"HTML\":\"true\"},{\"CSS\":\"true\"},{\"JS\":\"true\"},{\"C#\":\"false\"},{\"SQL\":\"false\"}]", "[{\"汽車\":\"true\"},{\"機車\":\"true\"}]", 2, 1, 2, "國立臺北科技大學", "[{\"英語\":\"true\"},{\"日語\":\"false\"},{\"台語\":\"true\"}]", "資訊工程系", "王瑪莉", "Candidate-0001.png" },
                    { 2, "新北市新店區", 35, 2, "我是國立臺灣大學外國語文學系的學生，熟練英語、日語，並精通JS、C#和SQL。我充滿熱情，渴望為您的團隊帶來價值，一同追求卓越。期待與您攜手實現成功！", "[{\"HTML\":\"false\"},{\"CSS\":\"false\"},{\"JS\":\"true\"},{\"C#\":\"true\"},{\"SQL\":\"true\"}]", "[{\"汽車\":\"false\"},{\"機車\":\"true\"}]", 2, 2, 1, "國立臺灣大學", "[{\"英語\":\"true\"},{\"日語\":\"true\"},{\"台語\":\"false\"}]", "外國語文學系", "黃小明", "Candidate-0002.jpg" },
                    { 3, "新北市新店區", 35, 3, "我是國立臺灣大學外國語文學系的學生，熟練英語、日語，並精通JS、C#和SQL。我充滿熱情，渴望為您的團隊帶來價值，一同追求卓越。期待與您攜手實現成功！", "[{\"HTML\":\"false\"},{\"CSS\":\"false\"},{\"JS\":\"true\"},{\"C#\":\"true\"},{\"SQL\":\"true\"}]", "[{\"汽車\":\"false\"},{\"機車\":\"true\"}]", 2, 2, 1, "國立臺灣大學", "[{\"英語\":\"true\"},{\"日語\":\"true\"},{\"台語\":\"false\"}]", "外國語文學系", "黃小明", "Candidate-0002.jpg" }
                });

            migrationBuilder.InsertData(
                table: "CompanyProfiles",
                columns: new[] { "CompanyID", "Address", "CompanySite", "CreateAt", "Fax", "Gift", "IndustryCategoryID", "Insurance", "Introduction", "PersonnelContact", "ProductContent", "StaffQuantity", "UpdateAt", "WelfareDesc" },
                values: new object[,]
                {
                    { 1, "台中市西區台灣大道2段218號29樓", "http://www.wowprime.com/", new DateTime(2023, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "暫不提供", "三節禮物", 1, "健保,勞保", "王品集團成立於1993年，全球總店數已超過400家，餐廳經營發展跨足不同類型，包括西式、日式、中式、火鍋、燒肉等領域，致力於多品牌經營與服務創新，不斷精進與突破，躍居台灣第一大餐飲集團，成為同業標竿，被譽為餐飲業經營的典範。<br />\r\n<br />\r\n王品集團多年的努力和表現，受到許多獎項的肯定，於國際廚藝競賽中獲獎超過50座，屢獲天下雜誌、遠見雜誌服務業大調查評選第一名，並榮獲台灣經濟部頒發優良品牌獎。<br />\r\n<br />\r\n王品集團擁有優質的企業文化與連鎖餐飲管理制度，歡迎有志從事餐飲業的伙伴加入，與我們一起實現偉大願景，傳遞餐桌上的美味關係，成為最具影響力的餐飲集團。<br />\r\n<br />\r\n<br />\r\n【反詐騙聲明】<br />\r\n提醒您，本網站僅提供應徵服務，履歷來源由求職者主動應徵或系統配對，不會要求您在面試前提供其他個人資料，履歷資料僅限王品集團台灣關係企業使用；面試地點將會安排在總部、各門店、公立就業服務機構或其他公共場地。若接獲冒用王品集團之名義要求提供個人資料或至可疑地點面試等，請來信至hr@wowprime.com&nbsp;或客服信箱service@wowprime.com，或與警政署「反詐騙諮詢專線165」查詢，謝謝。<br />\r\n<br />\r\n經營理念<br />\r\n1.【顧客是恩人】：以「熱忱」的心『款待』顧客。　<br />\r\n2.【同仁是家人】：以「關懷」的心『了解』同仁。　<br />\r\n3.【廠商是貴人】：以「尊重」的心『面對』廠商。</div>", "黃小姐", "【台灣事業群】<br />\r\n王品牛排：www.wangsteak.com.tw<br />\r\nTASTy西堤牛排：www.tasty.com.tw<br />\r\n陶板屋和風創作料理：www.tokiya.com.tw<br />\r\n原燒優質原味燒肉：www.yakiyan.com<br />\r\n聚北海道昆布鍋：www.giguo.com.tw<br />\r\n藝奇新日本料理：www.ikki.com.tw<br />\r\n夏慕尼新香榭鉄板燒：www.chamonix.com.tw<br />\r\n品田牧場日式豬排咖哩：www.pinnada.com.tw<br />\r\n石二鍋&nbsp;石頭鍋.涮涮鍋：www.12hotpot.com.tw<br />\r\nhot&nbsp;7新鉄板料理：www.hot-7.com<br />\r\nPUTIEN&nbsp;莆田-新加坡最佳亞洲餐廳：www.putien.com.tw<br />\r\n青花驕&nbsp;麻辣鍋：www.chinhuajiao.com<br />\r\n享鴨&nbsp;烤鴨與中華料理：www.xiangduck.com.tw<br />\r\n丰禾台式小館：www.veggtable.com<br />", 9000, new DateTime(2023, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "【薪滿意足】&nbsp;<br />\r\n月月有感-具競爭力的薪資、全勤獎金、績效獎金、每月晉升機會、管理津貼、技能津貼*、外語津貼*、夜間津貼*<br />\r\n年年滿足-每年2次績效調薪機會、年終獎金(視營運狀況發放)<br />\r\n不定期-內部推薦獎勵*&nbsp;<br />\r\n<br />\r\n【安心保障】&nbsp;<br />\r\n法定保障-勞保、健保、勞退提撥&nbsp;<br />\r\n公司保障-團保、定期健康檢查&nbsp;<br />\r\n貼心保障-結婚及生育禮金、孕婦友善工作環境、同仁重大傷病慰問金*&nbsp;<br />\r\n<br />\r\n【專屬為你】&nbsp;<br />\r\n即享樂-同仁及家人用餐八折優惠、上班免費供餐*&nbsp;<br />\r\n獨享樂-正職加碼放鬆假&nbsp;每年多4天!&nbsp;三節禮券、生日祝福餐、同仁及同仁子女教育獎學金*<br />\r\n眾享樂-國外旅遊補助、尾牙活動、不定期歡聚活動、除夕公休*&nbsp;<br />\r\n<br />\r\n【實力升級】&nbsp;<br />\r\n系統化培訓課程-集團訓練、事業處訓練、門店訓練<br />\r\n線上學習平台-王品wow!學院<br />\r\n其它-專業證照/執照輔導、外部教育訓練費用補助*、鼓勵在職進修<br />\r\n<br />\r\n【同仁國內外旅遊足跡】&nbsp;<br />\r\n2016-&nbsp;關島、西班牙&nbsp;<br />\r\n2017-&nbsp;首爾、大阪、北歐四國<br />\r\n2018-&nbsp;新加坡、四國、克羅埃西亞<br />\r\n2019-&nbsp;泰國、九州、土耳其<br />\r\n2020-&nbsp;宜蘭龜山島、花蓮太魯閣、台南墾丁、金門<br />\r\n2021-&nbsp;阿里山、小琉球<br />\r\n2022-&nbsp;環島、澎湖、台東<br />\r\n2023-&nbsp;馬來西亞、日本關西、土耳其<br />\r\n<br />\r\n【新鐵人養成計畫】&nbsp;<br />\r\n初級養成-日行萬步好健康&nbsp;<br />\r\n進階挑戰-鐵騎貫寶島、泳渡日月潭、半程馬拉松、登玉山&nbsp;<br />\r\n超級挑戰-聖母峰基地營登山活動(EBC)&nbsp;<br />\r\n<br />\r\n【計時人員&nbsp;享福又給利】&nbsp;<br />\r\n認真享全勤&nbsp;-&nbsp;達出勤標準即享津貼1,000元起&nbsp;<br />\r\n快樂享津貼&nbsp;-&nbsp;國定假日出勤雙薪&nbsp;<br />\r\n安心享休假&nbsp;-&nbsp;法定給薪休假(特休假等….)&nbsp;<br />\r\n一起享獎金&nbsp;–&nbsp;每月績效獎金、年終獎金(視營運狀況發放)<br />\r\n相聚享歡樂&nbsp;-&nbsp;國外旅遊補助、不定期歡聚活動、尾牙活動<br />\r\n<br />\r\n&nbsp;(*)星號表示依各事業處規定;上述福利(含國內外旅遊)等視整體營運或環境狀況公司保留調整權利。" },
                    { 2, "台北市大安區敦化南路二段77號12樓", "https://www.yungching.tw/", new DateTime(2023, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "暫不提供", "三節禮物", 1, "健保,勞保", "【永慶房產集團五大第一】<br />\r\n■全台第一大房仲集團，全台店數突破1600家<br />\r\n房仲第一品牌&nbsp;-&nbsp;永慶房產集團於1988年正式成立，迄今已超過30年，一路走來，不斷致力於推動交易安全及發展e化服務系統與工具，滿足消費者安心購售屋及提升交易效率的基本需求，並積極整合集團資源，拓展市場規模，除提供客戶各項不動產仲介及諮詢的全方位服務外，更建構全國龐大且綿密的門市通路網絡，將永慶的服務深入社區、扎根基層。集團旗下共有直營品牌永慶房屋，及四個加盟品牌：永慶不動產、永義房屋、有巢氏房屋、台慶不動產等五個品牌，集團全台店數突破1600店，是台灣最大的房產集團。<br />\r\n<br />\r\n■第一位推動「新式仲介」的領航者<br />\r\n孫慶餘董事長從美日引進「新式仲介」主張不賺差價，只收取固定服務費，改變房仲的格局與遊戲規則；創立台灣第一個房仲加盟平台：大台北不動產仲介聯盟(現住商不動產的前身)&nbsp;，推動產業進入「房仲1.0-新式仲介時代」。後成立永慶房屋，投入十年推動《不動產仲介經紀業管理條例》立法通過，並不斷創新服務推動產業升級，帶領產業進入「房仲2.0-法制仲介時代」。<br />\r\n<br />\r\n■第一家獲頒「地政貢獻獎」的業者<br />\r\n在孫董事長的帶領下，永慶房產集團以「先誠實再成交」的核心理念，以提供消費者一個「公平的房產交易平台」為己任。為了落實對消費者的承諾，永慶房屋在不僅在2007年時率先於永慶房仲網上率先公開成交行情，並主動提供成交資訊給政府，因此促成「實價登錄1.0」於2012年立法成功。孫慶餘董事長也在2014年，因協助推動《不動產經紀業管理條例》立法、主動提供成交資訊，讓實價登錄政策順利實施、推動新式仲介、法制仲介到科技仲介，引領產業進步，成為台灣第一位獲得地政貢獻獎的房仲業者。<br />\r\n<br />\r\n■第一家揭露成交行情至門牌的業者<br />\r\n2019年「實價登錄2.0」於立法院闖關失敗，永慶房屋領先政府及同業，率先推「實價登錄3.0－成交行情揭露至門牌」，並陸續推至集團下所有房仲品牌，深獲各界認同。永慶房屋2020年8月，永慶房屋再推「兩大誠實房價保證」，承諾若未能落實提供成交行情揭露至門牌，造成客戶損失，永慶房屋將做出賠償，此創舉贏得客戶讚賞更震撼業界。<br />\r\n<br />\r\n■唯一提供消費者買賣屋「全保障」<br />\r\n2021年9月，永慶房屋再創買賣屋保障新標竿！重磅推出「真房價保證」服務，保證不炒房不賺差價，若未落實最高將賠償買方400萬元；賠償賣方最高四倍服務費，用實際的行動和服務，展現「房仲第一品牌」保障消費者權益的決心，以落實孫慶餘董事長為消費者打造公平房產交易平台的承諾，推升產業進入「房仲3.0-誠實仲介時代」。", "鄭小姐", "■營運版圖橫跨房產、仲介、網路,服務一次到位,職涯發展空間更寬廣<br />\r\n<br />\r\n永慶房產事業集團橫跨三大事業群及永慶慈善基金會,提供客戶房地產上中下游的完整服務,集團內完善的升遷制度,則讓每一個永慶的同仁,都可依自己的興趣、專長,擁有更寬闊的一片天。<br />\r\n<br />\r\n【直營事業體】(永慶房屋、首席顧問團隊、永慶豪宅、永慶店面)<br />\r\n-不動產買賣仲介服務<br />\r\n-不動產租賃仲介服務<br />\r\n-不動產處理顧問諮詢服務<br />\r\n<br />\r\n【加盟事業體】(永慶不動產、有巢氏房屋、台慶不動產、永義房屋)<br />\r\n-加盟品牌授權、營運輔導<br />\r\n<br />\r\n【代銷事業體】(永慶代銷)<br />\r\n-預售屋推案、企劃銷售、餘屋銷售及現場管理業務<br />\r\n<br />\r\n【建設事業體】(永慶建設)<br />\r\n-土地開發、都市更新、建築管理等業務<br />\r\n<br />\r\n【交安事業體】(永慶代書)<br />\r\n-產權審查<br />\r\n-代書服務(簽約簽訂、成交過戶、銀行貸款設定、節稅規劃)<br />\r\n-不動產交易簽證及契約鑑證<br />\r\n-不動產徵信及評估<br />\r\n-不動產買賣履約保證<br />\r\n<br />\r\n【網路事業體】(永慶房仲網)&nbsp;<br />\r\n-提供房產物件、居家裝潢、修繕服務搜尋&nbsp;<br />\r\n-提供物件成交行情,涵蓋全台各縣市、行政區到社區大樓等<br />\r\n<br />\r\n【永慶慈善基金會】<br />\r\n-推廣全齡通用住宅,倡導通用生活、居住平權<br />\r\n-推動無障礙觀念,照顧身心障礙者<br />\r\n-扶助社會弱勢人口,協助改善生活現況<br />\r\n-喚醒大眾對弱勢之重視,爭取必要的社會資源<br />\r\n-發揮人間的溫暖情誼,創造盡善盡美的生活環境", 3000, new DateTime(2023, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "■&nbsp;兼顧工作與生活的真幸福，在永慶房屋找到幸福的新定義<br />\r\n<br />\r\n「有幸福的員工，才有滿意的客戶！」<br />\r\n除了對消費者的服務，更持續「致力打造友善職場」，透過學長姐輔導、師徒達人制度，建立團隊合作共享的職場文化；善用創新科技及企業優勢，成功推動彈性工作8小時制度，讓員工能夠工作與生活平衡；有感的薪獎福利，提供業界最優保障前12個月每月5萬元收入、每人每年最高250萬「幸福成家基金」；以能力為導向的月月晉升制度，成為房仲業唯一連續六年獲得HR&nbsp;Asia「亞洲最佳企業雇主獎」肯定(<a style=\"display: inline;\" href=\"https://house.udn.com/house/story/11067/7311723\" rel=\"ugc nofollow\" target=\"_blank\">https://house.udn.com/house/story/11067/7311723</a>)&nbsp;，同時，更連續11年獲得「台灣服務業大評鑑」連鎖服務業金獎的肯定。<br />\r\n<br />\r\n《永慶，真的不一樣》<br />\r\n聰明工作，高效率、完善培訓<br />\r\n經紀人員彈性工作8小時、搭配遊戲化制度，工作高效率。<br />\r\nI&nbsp;pad行動服務工具，協助經紀人員快速上手、即時提供房產服務。<br />\r\n完整教育訓練，另更補助指派受訓及經核准之內外訓課程。<br />\r\n輔導考取不動產經紀人國家證照。<br />\r\n慰勞員工之年終獎金，依公司營運狀況及年資、職級及個人表現之不同提供。<br />\r\n行政績優同仁可獲頒考核獎金及獎牌、獎座。<br />\r\n經紀人員除薪資及業績獎金外，公司定期舉辦激勵活動獎勵，提供高額獎金。<br />\r\n<br />\r\n【健康生活，打造幸福職場】<br />\r\n-提供經紀人員最高250萬元的購屋基金，圓三年購屋夢。<br />\r\n-海內外獎勵旅遊，生活更多采。&nbsp;<br />\r\n-免費紓壓按摩，員工好放鬆。<br />\r\n-生日津貼、三節禮金/禮券，員工好窩心。<br />\r\n<br />\r\n【團隊合作，打造歸屬感】<br />\r\n-專屬學長學姊制，帶領新人上手。<br />\r\n-首創聯賣系統，同仁互相幫忙不藏私。<br />\r\n-團隊合作創高績效，經紀人除可獲得個人業績獎金，還可分配團體獎金。<br />\r\n-多元社團活動，如籃球賽、壘球賽、羽球賽，紓解工作壓力。<br />\r\n-員工休息室與聯誼廳，平日紓壓打氣，互相交流情感。<br />\r\n<br />\r\n【成家到安家，幸福百分百】<br />\r\n-舉辦大型尾牙，及免費返鄉專車。<br />\r\n-鼓勵班對，在永慶一圓成功及成家的夢想。<br />\r\n-提供經紀人員租屋補助、購置機車、ipad之無息貸款，打拼更安心。<br />\r\n-導入EAP員工協助方案，舉辦「幸福講座」，分享交流生活點滴。<br />\r\n-提供勞保、健保及團保(意外傷害、住院醫療及意外險)多重的保障。" }
                });

            migrationBuilder.InsertData(
                table: "Districts",
                columns: new[] { "DistrictID", "CityID", "CreateAt", "DistrictName", "UpdateAt" },
                values: new object[,]
                {
                    { 1, 2, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "松山區", null },
                    { 2, 2, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "信義區", null },
                    { 3, 2, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "大安區", null },
                    { 4, 2, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "中山區", null },
                    { 5, 2, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "中正區", null },
                    { 6, 2, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "大同區", null },
                    { 7, 2, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "萬華區", null },
                    { 8, 2, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "文山區", null },
                    { 9, 2, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "南港區", null },
                    { 10, 2, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "內湖區", null },
                    { 11, 2, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "士林區", null },
                    { 12, 2, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "北投區", null }
                });

            migrationBuilder.InsertData(
                table: "EmployeeCategories",
                columns: new[] { "EmployeeCategoryID", "CreateAt", "EmployeeCategoryName", "IndustryCategoryID" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "餐飲類人員", 1 },
                    { 2, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "旅遊休閒類人員", 1 },
                    { 3, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "美容美髮類人員", 1 },
                    { 4, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "軟體/工程類人員", 2 },
                    { 5, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "MIS／網管類人員", 2 },
                    { 6, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "客戶服務類人員", 3 },
                    { 7, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "門市營業類人員", 3 },
                    { 8, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "業務銷售類人員", 3 },
                    { 9, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "貿易類人員", 3 },
                    { 10, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "操作／技術類人員", 4 },
                    { 11, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "維修／技術服務類人員", 4 },
                    { 12, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "醫療專業類人員", 5 },
                    { 13, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "醫療／保健服務人員", 5 }
                });

            migrationBuilder.InsertData(
                table: "Resumes",
                columns: new[] { "ResumeID", "Address", "Age", "Autobiography", "CandidateID", "ComputerSkill", "CreateAt", "DrivingLicense", "EducationID", "EmploymentCategoryID", "GraduationSchool", "Language", "MajorIn", "OpenOrClosed", "Rank", "ResumeName", "UpdateAt" },
                values: new object[,]
                {
                    { 1, "台北市大安區", 28, "我是國立臺北科技大學資訊工程系的學生。我充滿活力，精通英語和台語，並擅長HTML、JS和CSS。我的熱情和專業知識準備好為您的團隊貢獻。我期待著與您共同創造成功的未來！", 1, "[{\"HTML\":\"true\"},{\"CSS\":\"true\"},{\"JS\":\"true\"},{\"C#\":\"false\"},{\"SQL\":\"false\"}]", new DateTime(2023, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "[{\"汽車\":\"true\"},{\"機車\":\"true\"}]", 2, 1, "國立臺北科技大學", "[{\"英語\":\"true\"},{\"日語\":\"false\"},{\"台語\":\"true\"}]", "資訊工程系", true, 1, "我的履歷", new DateTime(2023, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "台北市大安區", 28, "我是一位資訊工程系的學生，充滿求知慾望。除了流利的英語和台語，我還擁有軟體工程師實習的經驗，以及在超商當店員的實際工作經驗。這些經驗讓我具備團隊合作、問題解決和溝通技能。我期待在您的團隊中貢獻我的多元背景和積極態度。", 1, "[{\"HTML\":\"true\"},{\"CSS\":\"true\"},{\"JS\":\"true\"},{\"C#\":\"false\"},{\"SQL\":\"false\"}]", new DateTime(2023, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "[{\"汽車\":\"true\"},{\"機車\":\"true\"}]", 2, 1, "國立臺北科技大學", "[{\"英語\":\"true\"},{\"日語\":\"false\"},{\"台語\":\"true\"}]", "資訊工程系", false, 2, "備用履歷", new DateTime(2023, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "新北市新店區", 35, "我是國立臺灣大學外國語文學系的學生，熟練英語、日語，並精通JS、C#和SQL。我充滿熱情，渴望為您的團隊帶來價值，一同追求卓越。期待與您攜手實現成功！", 2, "[{\"HTML\":\"false\"},{\"CSS\":\"false\"},{\"JS\":\"true\"},{\"C#\":\"true\"},{\"SQL\":\"true\"}]", new DateTime(2023, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "[{\"汽車\":\"false\"},{\"機車\":\"true\"}]", 2, 2, "國立臺灣大學", "[{\"英語\":\"true\"},{\"日語\":\"true\"},{\"台語\":\"false\"}]", "外國語文學系", true, 1, "我的履歷", new DateTime(2023, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "WorkExpSnapshots",
                columns: new[] { "WorkExpSnapshotID", "CompanyName", "IndustryCategoryID", "JobCategoryID", "JobNature", "JobTitle", "Management", "ResumeSnapshotID", "TenureEnd", "TenureStart" },
                values: new object[,]
                {
                    { 1, "Build School", 2, 10, 2, "實習軟體工程師", false, 1, new DateTime(2023, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "全家超商", 3, 18, 3, "門市店員", true, 1, new DateTime(2023, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "鼎泰豐Din Tai Fung", 1, 2, 1, "餐廳外場人員", false, 2, new DateTime(2022, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "AddressDetails",
                columns: new[] { "AddressDetailID", "Address", "DistrictID", "Latitude", "Longitude" },
                values: new object[,]
                {
                    { 1, "新北市永和區中正路179之1號及181號2樓", 1, 24.99905m, 121.51681m },
                    { 2, "台北市大安區敦化南路二段77號12樓", 2, 25.03042m, 121.54925m },
                    { 3, "履歷1的地址", 2, 24.98977m, 121.51039m },
                    { 4, "履歷2的地址", 2, 24.98977m, 121.51039m }
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "CompanyID", "BoostNumber", "CompanyAccount", "CompanyName", "CompanyPhone", "CreateAt", "Email", "FreeDate", "LogoUrl", "MembershipDate", "Password" },
                values: new object[,]
                {
                    { 1, 0, "77881234", "王品餐飲股份有限公司", "0911222333", new DateTime(2023, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "wowprime@gmail.com", new DateTime(2023, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "wowprime.png", new DateTime(2023, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "wowprime87654321" },
                    { 2, 1, "88774321", "永慶房產集團(永慶房屋仲介股份有限公司)", "0955333222", new DateTime(2023, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "yungching@gmail.com", new DateTime(2023, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "yungching.png", new DateTime(2023, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "yungching87654321" }
                });

            migrationBuilder.InsertData(
                table: "CompanyFeatureRelations",
                columns: new[] { "CompanyFeatureRelationID", "CompanyFeatureCategoryID", "CompanyID", "CreateAt", "UpdateAt" },
                values: new object[,]
                {
                    { 1, 1, 1, new DateTime(2023, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 2, 2, new DateTime(2023, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "JobCategories",
                columns: new[] { "JobCategoryID", "CreateAt", "EmployeeCategoryID", "JobCategoryName" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "廚師" },
                    { 2, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "服務員" },
                    { 3, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "麵包師" },
                    { 4, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "飯店工作人員" },
                    { 5, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "領隊/導遊" },
                    { 6, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "空服/地勤人員" },
                    { 7, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "美容/美髮師" },
                    { 8, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "醫美諮詢師" },
                    { 9, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "美甲師" },
                    { 10, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "軟體工程師" },
                    { 11, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "資料工程師" },
                    { 12, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Android/iOS工程師" },
                    { 13, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "系統工程師" },
                    { 14, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "網路管理工程師" },
                    { 15, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "資安工程師" },
                    { 16, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "電話客服" },
                    { 17, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "文字客服" },
                    { 18, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "門市/店員/專櫃人員" },
                    { 19, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "售票/收銀人員" },
                    { 20, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "電話行銷人員" },
                    { 21, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "不動產經紀人" },
                    { 22, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "國內外業務人員" },
                    { 23, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, "船務/報關人員" },
                    { 24, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, "國貿人員" },
                    { 25, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "作業員/包裝員" },
                    { 26, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "電機工程技術員" },
                    { 27, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "領班" },
                    { 28, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, "產品維修人員" },
                    { 29, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, "電機裝修工" },
                    { 30, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, "汽車/機車技術人員" },
                    { 31, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, "醫師" },
                    { 32, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, "藥師" },
                    { 33, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, "護理師及護士" },
                    { 34, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, "按摩/推拿師" },
                    { 35, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, "診所助理" },
                    { 36, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, "醫院行政管理人員" }
                });

            migrationBuilder.InsertData(
                table: "WorkExperiences",
                columns: new[] { "WorkExperienceID", "CompanyName", "CreateAt", "IndustryCategoryID", "JobCategoryID", "JobNature", "JobTitle", "Management", "ResumeID", "TenureEnd", "TenureStart", "UpdateAt" },
                values: new object[,]
                {
                    { 1, "Build School", new DateTime(2023, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 10, 2, "實習軟體工程師", false, 1, new DateTime(2023, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 2, "全家超商", new DateTime(2023, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 18, 3, "門市店員", true, 1, new DateTime(2023, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "鼎泰豐Din Tai Fung", new DateTime(2023, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2, 1, "餐廳外場人員", false, 3, new DateTime(2022, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.InsertData(
                table: "AddressRelations",
                columns: new[] { "AddressRelationID", "AddressID", "CompanyID", "JobDescriptionID", "ResumeID" },
                values: new object[,]
                {
                    { 1, 1, 1, 1, null },
                    { 2, 2, 2, 2, null },
                    { 3, 3, null, null, 1 },
                    { 4, 4, null, null, 2 }
                });

            migrationBuilder.InsertData(
                table: "BoostOrders",
                columns: new[] { "BoostOrderID", "CompanyID", "DueAt", "Online", "OrderAt", "price", "Quantity" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1800, 1 },
                    { 2, 2, new DateTime(2023, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 3600, 2 }
                });

            migrationBuilder.InsertData(
                table: "BoostUsed",
                columns: new[] { "BoostUsedID", "CompanyID", "JobDescriptionID", "Quantity", "UnitPrice", "UsedAt" },
                values: new object[,]
                {
                    { 1, 1, 1, 1, 1800, new DateTime(2023, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 2, 2, 1, 1800, new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 2, 3, 1, 1800, new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "ChatMessages",
                columns: new[] { "MessageID", "CandidateID", "CompanyID", "CreateAt", "JobDescriptionID", "MessageContent", "ReadStatus", "SenderAccount" },
                values: new object[,]
                {
                    { 1, 1, 1, new DateTime(2023, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "請問職缺的詳細工作內容有哪些?", true, true },
                    { 2, 2, 2, new DateTime(2023, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "請問是否對本公司職缺有興趣?", false, false }
                });

            migrationBuilder.InsertData(
                table: "CollectionCompanies",
                columns: new[] { "CollectionCompanyID", "CandidateID", "CompanyID", "CreateAt" },
                values: new object[,]
                {
                    { 1, 1, 1, new DateTime(2023, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 2, 2, new DateTime(2023, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "EnvironmentPics",
                columns: new[] { "EnvironmentPicID", "CompanyID", "CreateAt", "EnvironmentPicPath", "UpdateAt" },
                values: new object[,]
                {
                    { 1, 2, new DateTime(2023, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "house_environPic_1.jpg", new DateTime(2023, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 2, new DateTime(2023, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "house_environPic_2.jpg", new DateTime(2023, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 2, new DateTime(2023, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "house_environPic_3.jpg", new DateTime(2023, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "MembershipOrders",
                columns: new[] { "MembershipOrderID", "CompanyID", "DueAt", "MembershipCategoryID", "Online", "OrderAt", "UnitPrice" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, true, new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2800 },
                    { 2, 2, new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 5200 }
                });

            migrationBuilder.InsertData(
                table: "WorkShares",
                columns: new[] { "WorkShareID", "CandidateID", "CompanyID", "CreateAt", "Evaluation", "JobCategoryID", "ShareContent", "UpdateAt" },
                values: new object[,]
                {
                    { 1, 1, 1, new DateTime(2023, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 1, "有尾牙，不定期員工訓練，公司團結合作力很強", new DateTime(2023, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 1, 1, new DateTime(2023, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, "公司福利多，同事大家都和樂融融", new DateTime(2023, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 1, 2, new DateTime(2023, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, "三節獎金,年終獎金，品牌大，客戶優先指名，公司誠信好，同事好相處，主管親切，公司地點好，網路行銷好，員工福利好，分紅福利高，未來一片光明", new DateTime(2023, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 1, 2, new DateTime(2023, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, "對於社會新鮮人給的底薪算高(50000)，學長學弟制讓新人不用擔心，學長姐直接一對一指導外加帶你出去拜訪客戶，但是抗壓性要夠強明", new DateTime(2023, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "JobDescriptions",
                columns: new[] { "JobDescriptionID", "Address", "BoostEndAt", "CompanyID", "ComputerSkill", "ContactAddress", "ContactEmail", "ContactName", "ContactPhone", "CreateAt", "DisplayOrder", "DrivingLicense", "EducationID", "EmploymentCategoryID", "IsManager", "IsPosted", "JobCategoryID", "JobDetail", "JobID", "JobShiftID", "JobTenureID", "JobTitle", "Language", "MaxSalary", "MinSalary", "PostEndAt", "PostScript", "PostStartAt", "SalaryPaymentID", "UpdateAt", "VacancyNumber", "WorkingHours" },
                values: new object[,]
                {
                    { 1, "新北市永和區中正路179之1號及181號2樓", new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "[{\"HTML\":\"false\"},{\"CSS\":\"false\"},{\"JS\":\"false\"},{\"C#\":\"false\"},{\"SQL\":\"false\"}]", "新北市永和區中正路179之1號及181號2樓", "wp_lee@gmail.com", "李小姐", "0912-345-678", new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "[{\"汽車\":\"false\"},{\"機車\":\"true\"}]", 1, 1, false, true, 1, "各項餐點製作、內場相關事務等", "aaa111", 2, 1, "陶板屋永和中正店-廚藝助理", "[{\"英語\":\"false\"},{\"日語\":\"false\"},{\"台語\":\"true\"}]", 250, 200, new DateTime(2023, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "即日起提供【視訊面試】選項 ，履歷經初審通過後，由專人電話連繫安排面試，讓你在家求職安心防疫。", new DateTime(2023, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "10:00~14:00 及 16:30~21:30" },
                    { 2, "台北市大安區敦化南路二段77號12樓", new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "[{\"HTML\":\"true\"},{\"CSS\":\"true\"},{\"JS\":\"true\"},{\"C#\":\"false\"},{\"SQL\":\"true\"}]", "台北市大安區敦化南路二段77號12樓", "yc_chang@gmail.com", "張先生", "0912-345-678", new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "[{\"汽車\":\"false\"},{\"機車\":\"false\"}]", 2, 1, true, true, 10, "使用 C# 程式語言開發\r\n- 運用 ASP.NET Framework MVC、ASP.NET Core MVC、Web API 架構\r\n- 運用 Dapper、Entity Framework等 ORM 框架\r\n- 採用 TDD、DDD、DI、IoC、分層設計等開發方法論", "bbb222", 1, 2, "ASP.NET MVC C# 網站後端工程師", "[{\"英語\":\"true\"},{\"日語\":\"false\"},{\"台語\":\"true\"}]", 70000, 40000, new DateTime(2023, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "請直接透過網站上的「我要應徵」進行應徵，可加快處理速度，讓您更快得到回覆。", new DateTime(2023, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "08:30-18:00" },
                    { 3, "台北市信義區市府路45號", new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "[{\"HTML\":\"false\"},{\"CSS\":\"false\"},{\"JS\":\"false\"},{\"C#\":\"false\"},{\"SQL\":\"false\"}]", "新北市永和區中正路179之1號及181號2樓", "wp_lee@gmail.com", "李小姐", "0912-345-678", new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "[{\"汽車\":\"false\"},{\"機車\":\"true\"}]", 1, 1, false, true, 1, "各項餐點製作、內場相關事務等", "ccc333", 2, 1, "西堤信義101店-主廚", "[{\"英語\":\"false\"},{\"日語\":\"false\"},{\"台語\":\"true\"}]", 280, 200, new DateTime(2023, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "即日起提供【視訊面試】選項 ，履歷經初審通過後，由專人電話連繫安排面試，讓你在家求職安心防疫。", new DateTime(2023, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "10:00~14:00 及 16:30~21:30" }
                });

            migrationBuilder.InsertData(
                table: "ApplicationRecords",
                columns: new[] { "ApplicationRecordID", "CandidateID", "CompanyID", "CreateAt", "InterviewStatus", "JobDescriptionID", "ReadStatus", "ResumeSnapshotID" },
                values: new object[,]
                {
                    { 1, 1, 1, new DateTime(2023, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 1, true, 1 },
                    { 2, 2, 2, new DateTime(2023, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 2, false, 2 },
                    { 3, 2, 1, new DateTime(2023, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1, false, 3 }
                });

            migrationBuilder.InsertData(
                table: "CollectionJobs",
                columns: new[] { "CollectionJobID", "CandidateID", "CreateAt", "JobDescriptionID" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 2, 2, new DateTime(2023, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 }
                });

            migrationBuilder.InsertData(
                table: "JobFeaturesRelations",
                columns: new[] { "JobFeaturesRelationID", "JobDescriptionID", "JobFeatureID" },
                values: new object[,]
                {
                    { 1, 1, 2 },
                    { 2, 1, 3 },
                    { 3, 1, 4 },
                    { 4, 2, 1 },
                    { 5, 2, 2 },
                    { 6, 2, 5 },
                    { 7, 2, 6 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AddressDetails_DistrictID",
                table: "AddressDetails",
                column: "DistrictID");

            migrationBuilder.CreateIndex(
                name: "IX_AddressRelations_AddressID",
                table: "AddressRelations",
                column: "AddressID");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationRecords_CandidateID",
                table: "ApplicationRecords",
                column: "CandidateID");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationRecords_CompanyID",
                table: "ApplicationRecords",
                column: "CompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationRecords_JobDescriptionID",
                table: "ApplicationRecords",
                column: "JobDescriptionID");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationRecords_ResumeSnapshotID",
                table: "ApplicationRecords",
                column: "ResumeSnapshotID");

            migrationBuilder.CreateIndex(
                name: "IX_BoostOrders_CompanyID",
                table: "BoostOrders",
                column: "CompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_BoostUsed_CompanyID",
                table: "BoostUsed",
                column: "CompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_ChatMessages_CandidateID",
                table: "ChatMessages",
                column: "CandidateID");

            migrationBuilder.CreateIndex(
                name: "IX_ChatMessages_CompanyID",
                table: "ChatMessages",
                column: "CompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_CollectionCompanies_CandidateID",
                table: "CollectionCompanies",
                column: "CandidateID");

            migrationBuilder.CreateIndex(
                name: "IX_CollectionCompanies_CompanyID",
                table: "CollectionCompanies",
                column: "CompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_CollectionJobs_CandidateID",
                table: "CollectionJobs",
                column: "CandidateID");

            migrationBuilder.CreateIndex(
                name: "IX_CollectionJobs_JobDescriptionID",
                table: "CollectionJobs",
                column: "JobDescriptionID");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyFeatureRelations_CompanyFeatureCategoryID",
                table: "CompanyFeatureRelations",
                column: "CompanyFeatureCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyFeatureRelations_CompanyID",
                table: "CompanyFeatureRelations",
                column: "CompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyProfiles_IndustryCategoryID",
                table: "CompanyProfiles",
                column: "IndustryCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Districts_CityID",
                table: "Districts",
                column: "CityID");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeCategories_IndustryCategoryID",
                table: "EmployeeCategories",
                column: "IndustryCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_EnvironmentPics_CompanyID",
                table: "EnvironmentPics",
                column: "CompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_JobCategories_EmployeeCategoryID",
                table: "JobCategories",
                column: "EmployeeCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_JobDescriptions_CompanyID",
                table: "JobDescriptions",
                column: "CompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_JobDescriptions_JobCategoryID",
                table: "JobDescriptions",
                column: "JobCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_JobFeaturesRelations_JobDescriptionID",
                table: "JobFeaturesRelations",
                column: "JobDescriptionID");

            migrationBuilder.CreateIndex(
                name: "IX_JobFeaturesRelations_JobFeatureID",
                table: "JobFeaturesRelations",
                column: "JobFeatureID");

            migrationBuilder.CreateIndex(
                name: "IX_MembershipOrders_CompanyID",
                table: "MembershipOrders",
                column: "CompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_Resumes_CandidateID",
                table: "Resumes",
                column: "CandidateID");

            migrationBuilder.CreateIndex(
                name: "IX_ResumeSnapshots_ApplicationRecordID",
                table: "ResumeSnapshots",
                column: "ApplicationRecordID");

            migrationBuilder.CreateIndex(
                name: "IX_WorkExperiences_ResumeID",
                table: "WorkExperiences",
                column: "ResumeID");

            migrationBuilder.CreateIndex(
                name: "IX_WorkExpSnapshots_ResumeSnapshotID",
                table: "WorkExpSnapshots",
                column: "ResumeSnapshotID");

            migrationBuilder.CreateIndex(
                name: "IX_WorkShares_CandidateID",
                table: "WorkShares",
                column: "CandidateID");

            migrationBuilder.CreateIndex(
                name: "IX_WorkShares_CompanyID",
                table: "WorkShares",
                column: "CompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_WorkShares_JobCategoryID",
                table: "WorkShares",
                column: "JobCategoryID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AddressRelations");

            migrationBuilder.DropTable(
                name: "ApplicationRecords");

            migrationBuilder.DropTable(
                name: "BoostOrders");

            migrationBuilder.DropTable(
                name: "ChatMessages");

            migrationBuilder.DropTable(
                name: "CollectionCompanies");

            migrationBuilder.DropTable(
                name: "CollectionJobs");

            migrationBuilder.DropTable(
                name: "CompanyFeatureRelations");

            migrationBuilder.DropTable(
                name: "EnvironmentPics");

            migrationBuilder.DropTable(
                name: "JobFeaturesRelations");

            migrationBuilder.DropTable(
                name: "MembershipCategories");

            migrationBuilder.DropTable(
                name: "MembershipOrders");

            migrationBuilder.DropTable(
                name: "RecentlyViewedJobs");

            migrationBuilder.DropTable(
                name: "WorkExperiences");

            migrationBuilder.DropTable(
                name: "WorkExpSnapshots");

            migrationBuilder.DropTable(
                name: "WorkShares");

            migrationBuilder.DropTable(
                name: "AddressDetails");

            migrationBuilder.DropTable(
                name: "CompanyFeatureCategory");

            migrationBuilder.DropTable(
                name: "JobDescriptions");

            migrationBuilder.DropTable(
                name: "JobFeatures");

            migrationBuilder.DropTable(
                name: "Resumes");

            migrationBuilder.DropTable(
                name: "ResumeSnapshots");

            migrationBuilder.DropTable(
                name: "Districts");

            migrationBuilder.DropTable(
                name: "BoostUsed");

            migrationBuilder.DropTable(
                name: "JobCategories");

            migrationBuilder.DropTable(
                name: "Candidates");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "EmployeeCategories");

            migrationBuilder.DropTable(
                name: "CompanyProfiles");

            migrationBuilder.DropTable(
                name: "IndustryCategories");
        }
    }
}

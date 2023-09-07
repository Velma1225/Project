using System;

namespace HabanMVC.ViewModels.Job
{
    //職缺 職務分類 JobCategory
    public class JobCategoryViewModel
    {
        public int JobCategoryID { get; set; }
        public int EmployeeCategoryID { get; set; }
        public string JobCategoryName { get; set; }
        public DateTime CreateAt { get; set; }
    }

    //職缺產業類別 分類 IndustryCategories
    public class IndustryCategoriesViewModel
    {
        public int IndustryCategoryID { get; set; }
        public string IndustryCategoryName { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }
    }

    //職缺 人員類別 分類 EmployeeCategories
    public class EmployeeCategoriesViewModel
    {
        public int EmployeeCategoryID { get; set; }
        public string IndustryCategoryID { get; set; }
        public int EmployeeCategoryName { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }
    }

    //行政區表 Districts
    public class DistrictsViewModel
    {
        public int DistrictID { get; set; }
        public int CityID { get; set; }
        public string DistrictName { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }

    //縣市表 Cities
    public class CitiesViewModel
    {
        public int CityID { get; set; }
        public string CityName { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }

}


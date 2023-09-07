using Microsoft.EntityFrameworkCore;

namespace HabanMVC.ViewModels.Company
{
    //企業-徵才刊登 購買訂單紀錄
    public class MembershipOrdersViewModel
    {
        public int MembershipOrderID { get; set; }
        public int CompanyID { get; set; }
        public int MembershipCategoryID { get; set; }
        public int UnitPrice { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime DueAt { get; set; }
        public bool Online { get; set; }
    }

    //企業-加值置頂廣告  購買紀錄 
    public class BoostOrdersViewModel
    {
        public int BoostOrderID { get; set; }
        public int CompanyID { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public DateTime OrderAt { get; set; }
        public DateTime DueAt { get; set; }
        public bool Online { get; set; }
    }

    //企業-加值置頂廣告 使用紀錄 
    public class BoostUsedViewModel
    {
        public int BoostUsedID { get; set; }
        public int CompanyID { get; set; }
        public int JobDescriptionID { get; set; }
        public int Quantity { get; set; }
        public int UnitPrice { get; set; }
        public DateTime UsedAt { get; set; }
    }

    //企業-徵才刊登方案 分類
    public class MembershipCategoriesVM
    {
      
        public int MembershipCategoryID { get; set; }
        public string MembershipName { get; set; }
        public int DiscountPrice { get; set; }
        public int UnitPrice { get; set; }
        public int TotalDate { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }

    }


}

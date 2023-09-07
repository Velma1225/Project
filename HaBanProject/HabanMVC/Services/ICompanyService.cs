using HabanMVC.ViewModels.Company;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HabanMVC.Services
{
    public interface ICompanyService
    {
        AccountEditViewModel GetAccountEdit();
        BoostOrdersViewModel GetCompanyBuyTop();
        CompanyProfileViewModel GetCompanyProfile();
        CompanyProfileEditViewModel GetCompanyProfileEdit();
        Task<List<CoverLetterViewModel>> GetCoverLetterList(int? jobID);
        Task<List<SelectListItem>> GetSelectListItems(int? jobID);
        Task<MembershipBuyVM> GetMembershipModel();
    }
}
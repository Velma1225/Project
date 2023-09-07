using HabanMVC.ViewModels.Company;
using HabanMVC.ViewModels.HaBan;

namespace HabanMVC.Services
{
    public class AccountEditService
    {
        public AccountEditViewModel GetAccountEdit()
        {

            AccountEditViewModel accountEdit = new AccountEditViewModel()
            {
                CompanyId = 12345678,
                Password = "********",
                CompanyName = "Build School",
                Mobile = "0912345677",
                Email = "build@gmail"
            };

            return accountEdit;
        }
    }
}

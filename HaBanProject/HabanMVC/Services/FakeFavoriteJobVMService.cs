namespace HabanMVC.Services
{
    public class FakeFavoriteJobVMService
    {
        public List<FavoriteJobVM> GetFavoriteJob()
        {

            var vm = new List<FavoriteJobVM>
            {

                new FavoriteJobVM
                {
                    JobTitle = "Build Shcool ASP.NET Core7 MVC 清潔工",
                    CompanyName = "Build Shcool",
                    CreateAt = new DateTime(2023, 9, 10),
                    JobTitleLink = "abc",
                    CompanyNameLink = "bca"
                },
                new FavoriteJobVM
                {
                    JobTitle = "Build Shcool ASP.NET Core7 MVC 清潔工",
                    CompanyName = "Build Shcool",
                    CreateAt = new DateTime(2023, 9, 10),
                    JobTitleLink = "abc",
                    CompanyNameLink = "bca"
                }


            };
            return vm;
        }
    }
}

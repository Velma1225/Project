
using HabanMVC.ViewModels.HaBan;
using System.Collections.Generic;


namespace HabanMVC.Repositories
{
    public class HaBanRepository
    {
        //正式專案要用資料庫存取:
        //private readonly HaBanContext _context;
        //public HaBanRepository(HaBanContext context)
        //{ 
        // _context = context;
        //}

        public List<CompanySlider> ReadAllSlider()
        {
            List<CompanySlider> result = new List<CompanySlider>()
            {
               
            };
            return result;
        }
    }
}

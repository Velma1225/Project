using HabanMVC.ViewModels.HaBan;

namespace HabanMVC.Services
{
    public interface IHaBanService
    {
        Task<List<CompanySlider>> GetAllSlider();
    }
}
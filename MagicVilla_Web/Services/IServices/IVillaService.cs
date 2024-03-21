using MagicVilla_Web.Models.Dto;

namespace MagicVilla_Web.Services.IServices
{
    public interface IVillaService
    {
        Task<T> GetAllAsync<T>(string token);
        Task<T> GetAsync<T>(int id, string token);
        Task<T> CreateASync<T>(VillaCreateDTO dto, string token);
        Task<T> UpdateAsync<T>(VillaUpdateDTO dto, string token);
        Task<T> DeleteAync<T>(int id, string token);
    }
}

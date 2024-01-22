using CrudWebApi.Model;
namespace CrudWebApi.Services
{
    public interface IHeroService
    {
        Task<List<Hero>> GetAllHeros(bool? isActive);
        Task<Hero?> GetHerosByID(int id);
        Task<Hero?> AddHero(AddUpdateHero obj);
        Task<Hero?> UpdateHero(int id, AddUpdateHero obj);
        Task<bool> DeleteHerosByID(int id);
    }
}

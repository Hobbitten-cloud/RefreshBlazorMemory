using RefreshBlazorMemory.Models;

namespace RefreshBlazorMemory.Repos.IRepo
{
    public interface IMusicRepo
    {
        Task AddMusic(Music music);
        Task DeleteMusic(int id);
        Task<List<Music>> Getall();
        Task<Music> GetMusic(int id);
        Task UpdateMusic(Music music);
    }
}
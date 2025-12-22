using RefreshBlazorMemory.Models;

namespace RefreshBlazorMemory.Repos.IRepo
{
    public interface IMusicRepo
    {
        void AddMusic(Music music);
        void DeleteMusic(int id);
        Task<List<Music>> Getall();
        void GetMusic(int id);
        void UpdateMusic();
    }
}
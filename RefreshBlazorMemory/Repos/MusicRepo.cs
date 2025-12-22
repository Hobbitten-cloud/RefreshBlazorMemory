using Microsoft.EntityFrameworkCore;
using RefreshBlazorMemory.Data;
using RefreshBlazorMemory.Models;
using RefreshBlazorMemory.Repos.IRepo;

namespace RefreshBlazorMemory.Repos
{
    public class MusicRepo : IMusicRepo
    {
        private readonly DataContext _dataContext;
        public MusicRepo(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public void AddMusic(Music music) { }
        public void UpdateMusic() { }
        public void DeleteMusic(int id) { }
        public void GetMusic(int id) { }
        public async Task<List<Music>> Getall()
        {
            return await _dataContext.Musics.ToListAsync();
        }
    }
}

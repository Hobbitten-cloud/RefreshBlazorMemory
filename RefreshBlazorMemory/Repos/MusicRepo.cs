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
        public async Task AddMusic(Music music)
        {
            _dataContext.Musics.Add(music);
            await _dataContext.SaveChangesAsync();
        }
        public async Task UpdateMusic(Music music)
        {
            _dataContext.Musics.Update(music);
            await _dataContext.SaveChangesAsync();
        }
        public async Task DeleteMusic(int id)
        {
            var music = await GetMusic(id);
            if (music != null)
            {
                _dataContext.Musics.Remove(music);
                await _dataContext.SaveChangesAsync();
            }
        }
        public async Task<Music> GetMusic(int id)
        {
            return await _dataContext.Musics.FindAsync(id);
        }
        public async Task<List<Music>> Getall()
        {
            return await _dataContext.Musics.ToListAsync();
        }
    }
}

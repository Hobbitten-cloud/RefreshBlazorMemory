using System.ComponentModel.DataAnnotations;

namespace RefreshBlazorMemory.Models
{
    public class Music
    {
        public int Id { get; set; }
        [Required]
        public string Artist { get; set; }
        public string? AlbumTitle { get; set; }
        public int ReleaseYear { get; set; }
        public string? Description { get; set; }
    }
}

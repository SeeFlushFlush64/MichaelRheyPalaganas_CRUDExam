namespace MichaelRheyPalaganas_CRUDExam.Models.Entities
{
    public class Track
    {
        public int TrackId { get; set; }
        public string TrackName { get; set; }
        public TimeSpan Duration { get; set; }
        public int AlbumId { get; set; }
        public string FilePath { get; set; }
        public Album Album { get; set; }
    }
}

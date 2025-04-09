using MichaelRheyPalaganas_CRUDExam.Data;
using MichaelRheyPalaganas_CRUDExam.Models.Entities;
using Microsoft.EntityFrameworkCore;
using NAudio.Wave;

namespace MichaelRheyPalaganas_CRUDExam.SubForms
{
    public partial class AddTrack : Form
    {
        private readonly AppDbContext _context;
        private Album _album;
        private WaveOutEvent outputDevice;
        private AudioFileReader audioFile;
        private MainForm _parentForm;
        public AddTrack(MainForm parentForm, Album album, AppDbContext context)
        {
            _context = context;
            _album = _context.Albums.Include(a => a.Tracks).FirstOrDefault(a => a.AlbumId == album.AlbumId);
            _parentForm = parentForm;
            InitializeComponent();
            LoadAddTracks();
        }

        private void LoadAddTracks()
        {
            txtBoxArtist.Text = _album.Artist;
            txtBoxGenre.Text = _album.Genre;
        }

        private void picBoxBrowseTrack_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void picBoxBrowseTrack_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Arrow;
        }

        private void picBoxBrowseTrack_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\"; // optional
                openFileDialog.Filter = "Music Files (*.mp3;*.wav)|*.mp3;*.wav|All files (*.*)|*.*";
                openFileDialog.Multiselect = false; // change to true if you want to allow multiple files

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFile = openFileDialog.FileName;
                    txtBoxTrackFilePath.Text = selectedFile; // Example: Display in a TextBox



                    outputDevice = new WaveOutEvent();
                    audioFile = new AudioFileReader(openFileDialog.FileName);
                    outputDevice.Init(audioFile);
                }
            }
        }

        private void ClearTrackFields()
        {
            txtBoxTrackName.Text = "";
            txtBoxTrackFilePath.Text = "";
        }

        private void btnAddTrack_Click(object sender, EventArgs e)
        {
            Track newTrack = new Track
            {
                TrackName = txtBoxTrackName.Text,
                AlbumId = _album.AlbumId,
                Duration = audioFile.TotalTime,
                FilePath = txtBoxTrackFilePath.Text
            };
            _context.Tracks.Add(newTrack);
            _context.SaveChanges();
            ClearTrackFields();
            _parentForm.NavigateToForm(new ShowAlbumTracks(_context, _album, _parentForm));
        }
    }
}

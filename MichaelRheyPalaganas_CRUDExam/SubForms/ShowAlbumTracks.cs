using MichaelRheyPalaganas_CRUDExam.Data;
using MichaelRheyPalaganas_CRUDExam.Models.Entities;
using Microsoft.EntityFrameworkCore;
using NAudio.Wave;
using System.Data;

namespace MichaelRheyPalaganas_CRUDExam.SubForms
{
    public partial class ShowAlbumTracks : Form
    {
        private Label lblNoTracks = new Label();
        private AppDbContext _context;
        private Album _album;
        private bool _isShuffleActive = false;
        private MainForm _parentForm;
        private WaveOutEvent _outputDevice;
        private AudioFileReader _audioFile;
        private PictureBox picPlayTrack;
        private Dictionary<int, PictureBox> _trackPlayButtons;
        private PictureBox _currentPicPlayTrack;
        private PictureBox _currentPicPauseTrack;
        private int _currentTrackId = -1;
        private int? _currentlyPlayingTrackId = null;
        


        public ShowAlbumTracks(AppDbContext context, Album album, MainForm parentForm)
        {
            _context = context;
            _album = _context.Albums.Include(a => a.Tracks).FirstOrDefault(a => a.AlbumId == album.AlbumId);
            _parentForm = parentForm;
            
            
            InitializeComponent();
            LoadAlbumTracks();
        }
        private void LoadAlbumTracks()
        {
            picBoxEditTrack.Visible = false;
            picBoxDeleteTrack.Visible = false;

            picBoxCurrentAlbumPicture.ImageLocation = _album.AlbumPicture;
            picBoxCurrentAlbumPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            lblCurrentAlbumName.Text = _album.AlbumName;
            lblAlbumInformation.Text = $"{_album.Artist} • {_album.Genre} • {_album.Tracks.Count} Tracks";

            var tracks = _context.Tracks
                .Where(t => t.AlbumId == _album.AlbumId)
                .Select(t => new { t.TrackId, t.TrackName, t.Duration })
                .ToList();

            if (tracks.Count == 0)
            {

                lblNoTracks.Location = new Point(212, 354);
                lblNoTracks.Size = new Size(350, 60);
                lblNoTracks.Text = "No tracks available for this album.\nClick + to start adding tracks.";
                lblNoTracks.Font = new Font("Segoe UI", 15, FontStyle.Bold);
                lblNoTracks.TextAlign = ContentAlignment.MiddleCenter;

                lblNoTracks.BackColor = SystemColors.Control;
                lblNoTracks.ForeColor = SystemColors.ActiveCaptionText;
                lblNoTracks.Visible = true;
                lblNoTracks.Margin = new Padding(3, 0, 3, 0);
                dataGridViewTracks.Visible = false;

                this.Controls.Add(lblNoTracks);
                return;
            }

            lblNoTracks.Visible = false;
            dataGridViewTracks.DataSource = tracks;


            RemovePreviousTrackIcons();


            for (int i = 0; i < tracks.Count; i++)
            {
                CreateTrackIcons(i, tracks[i].TrackId);
            }
        }


        private void picBoxPlayTracks_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void picBoxPlayTracks_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Arrow;
        }

        private void picBoxShuffleTracks_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void picBoxShuffleTracks_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Arrow;
        }

        private void picBoxShuffleTracks_MouseClick(object sender, MouseEventArgs e)
        {

            if (_isShuffleActive)
            {
                _isShuffleActive = false;
                picBoxShuffleTracks.Image = Properties.Resources.shuffle_icon_default;
                return;
            }
            picBoxShuffleTracks.Image = Properties.Resources.shuffle_icon_active;
            _isShuffleActive = true;
        }

        private void picBoxAddTrack_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void picBoxAddTrack_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Arrow;
        }

        private void picBoxAddTrack_MouseClick(object sender, MouseEventArgs e)
        {

            _parentForm.NavigateToForm(new AddTrack(_parentForm, _album, _context));

        }

        private void picBoxEditTrack_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void picBoxEditTrack_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void picBoxEditTrack_Click(object sender, EventArgs e)
        {

        }

        private void picBoxDeleteTrack_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure you want to delete this track?", "Delete Track", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }

        private void picBoxDeleteTrack_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void picBoxDeleteTrack_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void RemovePreviousTrackIcons()
        {
            foreach (Control control in this.Controls.OfType<PictureBox>().Where(p => p.Tag != null).ToList())
            {
                this.Controls.Remove(control);
                control.Dispose();
            }
        }

        private void CreateTrackIcons(int index, int trackId)
        {
            int baseY = dataGridViewTracks.Top + 22;
            int rowHeight = 25;
            int yOffset = baseY + (index * rowHeight);


            PictureBox picEdit = new PictureBox
            {
                Image = picBoxEditTrack.Image,
                SizeMode = picBoxEditTrack.SizeMode,
                Size = picBoxEditTrack.Size,
                Location = new Point(picBoxEditTrack.Location.X, yOffset),
                Cursor = Cursors.Hand,
                Tag = trackId
            };
            picEdit.Click += PicEdit_Click;
            this.Controls.Add(picEdit);


            PictureBox picDelete = new PictureBox
            {
                Image = picBoxDeleteTrack.Image,
                SizeMode = picBoxDeleteTrack.SizeMode,
                Size = picBoxDeleteTrack.Size,
                Location = new Point(picBoxDeleteTrack.Location.X, yOffset),
                Cursor = Cursors.Hand,
                Tag = trackId
            };
            picDelete.Click += PicDelete_Click;
            this.Controls.Add(picDelete);

            picBoxPlayTrack.Enabled = false;
            picBoxEditTrack.Enabled = false;
            picBoxDeleteTrack.Enabled = false;
            picBoxPlayTrack.Visible = false;
            picBoxPauseTrack.Visible = false;
            picBoxEditTrack.Visible = false;
            picBoxDeleteTrack.Visible = false;
        }

        private void dataGridViewTracks_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int trackId = (int)dataGridViewTracks.Rows[e.RowIndex].Cells["TrackId"].Value;

                // Skip if it's the same track we're already showing
                if (trackId == _currentTrackId)
                {

                    return;
                }


                // Hide/remove the previous picPlayTrack if it exists
                if (_currentPicPlayTrack != null)
                {
                    this.Controls.Remove(_currentPicPlayTrack);
                    _currentPicPlayTrack.Dispose();
                    _currentPicPlayTrack = null;
                    _currentTrackId = -1;
                }

                // Hide/remove the previous picPauseTrack if it exists
                if (_currentPicPauseTrack != null)
                {
                    this.Controls.Remove(_currentPicPlayTrack);
                    _currentPicPauseTrack.Dispose();
                    _currentPicPauseTrack = null;
                    _currentTrackId = -1;
                }

                // Position calculation
                int baseY = dataGridViewTracks.Top + 22;
                int rowHeight = 25;
                int yOffset = baseY + (e.RowIndex * rowHeight);

                // Create and show new play track button
                _currentPicPlayTrack = new PictureBox
                {
                    Image = picBoxPlayTrack.Image,
                    SizeMode = picBoxPlayTrack.SizeMode,
                    Size = picBoxPlayTrack.Size,
                    Location = new Point(picBoxPlayTrack.Location.X, yOffset),
                    Cursor = Cursors.Hand,
                    Tag = trackId
                };

                _currentPicPauseTrack = new PictureBox
                {
                    Image = picBoxPauseTrack.Image,
                    SizeMode = picBoxPauseTrack.SizeMode,
                    Size = picBoxPauseTrack.Size,
                    Location = new Point(picBoxPauseTrack.Location.X, yOffset),
                    Cursor = Cursors.Hand,
                    Tag = trackId
                };

                _currentPicPauseTrack.Click += PicPauseTrack_Click;
                this.Controls.Add(_currentPicPauseTrack);
                _currentPicPauseTrack.Visible = true;

                _currentPicPlayTrack.Click += PicPlay_Click;
                this.Controls.Add(_currentPicPlayTrack);
                _currentPicPlayTrack.BringToFront();
                _currentPicPlayTrack.Visible = true;

                _currentTrackId = trackId;
            }
        }

        private void PicPlay_Click(object sender, EventArgs e)
        {
            PictureBox clickedPic = sender as PictureBox;
            int trackId = (int)clickedPic.Tag;
            var track = _album.Tracks.FirstOrDefault(t => t.TrackId == trackId);
            clickedPic.SendToBack();

            //// Same track & it's paused -> just resume
            //if (AudioManager.IsPlaying && AudioManager.currentlyPlayingTrackId == trackId)
            //{
            //    AudioManager.Resume();  // Just resume
            //    return;
            //}


            picBoxPlayTracks.SendToBack();
            _parentForm.picBoxPlayTrack.SendToBack();
            _parentForm.timer.Start();
            if (AudioManager.outputDevice != null && AudioManager.audioFile != null)
            {
                AudioManager.Resume();
                return;
            }
            //var firstTrack = _album.Tracks.OrderBy(t => t.TrackId).FirstOrDefault();

            //DisplayCurrentPlayingTrackDetails(firstTrack);
            //AudioManager.PlayMp3(firstTrack.FilePath); // Play the first track

            // Stop the current track (if any)
            AudioManager.Stop();

            // Play the new track
            if (track != null)
            {
                picBoxPlayTracks.SendToBack();
                _parentForm.picBoxPlayTrack.SendToBack();
                DisplayCurrentPlayingTrackDetails(track);
                AudioManager.PlayMp3(track.FilePath);
            }
        }


        public void DisplayCurrentPlayingTrackDetails(Track track)
        {
            AudioManager.parentForm = _parentForm;
            AudioManager.album = _album; 
            AudioManager.outputDevice = _outputDevice;
            AudioManager.audioFile = _audioFile;
            AudioManager.currentlyPlayingTrackId = track.TrackId;
            AudioManager.DisplayCurrentPlayingTrackDetails(track);
            _currentlyPlayingTrackId = track.TrackId;
            
            _parentForm.picBoxPlayTrack.SendToBack();
        }

        private void PicPauseTrack_Click(object sender, EventArgs e)
        {
            PictureBox clickedPic = sender as PictureBox;
            int trackId = (int)clickedPic.Tag;
            clickedPic.SendToBack();
            picBoxPauseTracks.SendToBack();
            _parentForm.picBoxPauseTrack.SendToBack();
            _parentForm.timer.Stop();
            AudioManager.Pause();  // Use AudioManager to pause the track
        }


        public void PlayMp3(string filePath)
        {
            // Dispose the previous output device and audio file if any
            if (_outputDevice != null)
            {
                _outputDevice.Stop();
                _outputDevice.Dispose();
                _outputDevice = null;
            }

            if (_audioFile != null)
            {
                _audioFile.Dispose();
                _audioFile = null;
            }

            // Set up and play the new track
            //_parentForm.currentPlayingTrackId = _currentlyPlayingTrackId;
            _parentForm.album = _album;
            _parentForm.timer.Start();
            _outputDevice = new WaveOutEvent();
            _audioFile = new AudioFileReader(filePath);
            _outputDevice.Init(_audioFile);
            _outputDevice.Play();
        }


        private void PicEdit_Click(object sender, EventArgs e)
        {
            PictureBox clickedPic = sender as PictureBox;
            int trackId = (int)clickedPic.Tag;
            _parentForm.NavigateToForm(new EditTrack(_parentForm, _album.Tracks.FirstOrDefault(t => t.TrackId == trackId), _context));
        }


        private void PicDelete_Click(object sender, EventArgs e)
        {
            PictureBox clickedPic = sender as PictureBox;
            int trackId = (int)clickedPic.Tag;

            var result = MessageBox.Show("Are you sure you want to delete this track?", "Delete Track",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                var track = _context.Tracks.FirstOrDefault(t => t.TrackId == trackId);
                if (track != null)
                {
                    _context.Tracks.Remove(track);
                    _context.SaveChanges();
                    LoadAlbumTracks();
                }
            }
        }

        private void picBoxPlayTracks_Click(object sender, EventArgs e)
        {
            picBoxPlayTracks.SendToBack();
            _parentForm.picBoxPlayTrack.SendToBack();
            _parentForm.timer.Start();
            if (AudioManager.outputDevice != null && AudioManager.audioFile != null)
            {
                AudioManager.Resume();
                return;
            }
            var firstTrack = _album.Tracks.OrderBy(t => t.TrackId).FirstOrDefault();
            
            DisplayCurrentPlayingTrackDetails(firstTrack);
            AudioManager.PlayMp3(firstTrack.FilePath); // Play the first track
        }

        private void picBoxPauseTracks_Click(object sender, EventArgs e)
        {
            picBoxPauseTracks.SendToBack();
            _parentForm.timer.Stop();
            _parentForm.picBoxPauseTrack.SendToBack();
            AudioManager.Pause();
        }
    }
}

using MichaelRheyPalaganas_CRUDExam.Data;
using MichaelRheyPalaganas_CRUDExam.Models.Entities;
using MichaelRheyPalaganas_CRUDExam.RequiredForms;
using MichaelRheyPalaganas_CRUDExam.SubForms;
using NAudio.Wave;
using System.Drawing.Drawing2D;

namespace MichaelRheyPalaganas_CRUDExam
{
    public partial class MainForm : Form
    {
        private readonly AppDbContext _context;
        private Stack<Form> _backStack = new Stack<Form>();
        private Stack<Form> _forwardStack = new Stack<Form>();
        public Album album;
        public int? currentPlayingTrackId;
        private ShowAlbumTracks _showAlbumTracks;

        private float defaultValue = 0.0f;
        private float minValue = 0.0f;
        private float maxValue = 1.0f;
        public System.Windows.Forms.Timer timer;
        bool mouse = false;
        public MainForm(AppDbContext context)
        {

            InitializeComponent();
            _context = context;
            LoadAlbumsDashboard();
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 500; // Update every 500ms
            timer.Tick += Timer_Tick;
        }
        private void LoadForms(Form newForm)
        {
            // If there is a form currently in panelBody, move it to the back stack
            if (panelBody.Controls.Count > 0)
            {
                Form currentForm = panelBody.Controls[0] as Form;
                if (currentForm != null)
                {
                    _backStack.Push(currentForm);
                }
                panelBody.Controls.Clear();
            }

            // Set up the new form
            newForm.TopLevel = false;
            newForm.Dock = DockStyle.Fill;
            panelBody.Controls.Add(newForm);
            newForm.Show();

            // Clear forward stack whenever a new form is loaded
            _forwardStack.Clear();

            // Update navigation buttons
            UpdateNavigationButtons();
        }
        public void LoadAlbumsDashboard()
        {
            LoadForms(new AlbumsDashboard(this, _context)); // Pass 'this' (MainForm) as reference to Form1
        }
        private void UpdateNavigationButtons()
        {
            // Enable or disable back and forward buttons based on the stack contents
            picBoxBackButton.Enabled = _backStack.Count > 0;
            picBoxForwardButton.Enabled = _forwardStack.Count > 0;
        }

        // This method will be called by the forms to navigate
        public void NavigateToForm(Form form)
        {
            LoadForms(form);
        }

        public void ShowAddAlbums(Form form)
        {

        }


        private void picBoxBackButton_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void picBoxBackButton_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void picBoxForwardButton_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void picBoxForwardButton_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void picBoxAddAlbum_Click(object sender, EventArgs e)
        {
            this.NavigateToForm(new AddAlbum(this, _context));
        }

        private void picBoxBackButton_Click(object sender, EventArgs e)
        {
            if (_backStack.Count > 0)
            {
                // Move the current form to the forward stack
                Form currentForm = panelBody.Controls[0] as Form;
                if (currentForm != null)
                {
                    _forwardStack.Push(currentForm);
                }

                // Pop the previous form from backStack and show it
                Form lastForm = _backStack.Pop();
                panelBody.Controls.Clear();
                lastForm.TopLevel = false;
                lastForm.Dock = DockStyle.Fill;
                panelBody.Controls.Add(lastForm);
                lastForm.Show();

                // Update navigation buttons
                UpdateNavigationButtons();
            }
        }

        private void picBoxForwardButton_Click(object sender, EventArgs e)
        {
            if (_forwardStack.Count > 0)
            {
                // Move the current form to the back stack
                Form currentForm = panelBody.Controls[0] as Form;
                if (currentForm != null)
                {
                    _backStack.Push(currentForm);
                }

                // Pop the next form from forwardStack and show it
                Form nextForm = _forwardStack.Pop();
                panelBody.Controls.Clear();
                nextForm.TopLevel = false;
                nextForm.Dock = DockStyle.Fill;
                panelBody.Controls.Add(nextForm);
                nextForm.Show();

                // Update navigation buttons
                UpdateNavigationButtons();
            }
        }

        private void lblPlayingTrackName_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void lblPlayingTrackName_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void lblPlayingArtist_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void lblPlayingArtist_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void picBoxShuffleTracks_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void picBoxShuffleTracks_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void picBoxPreviousTrack_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void picBoxPreviousTrack_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void picBoxPlayTrack_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void picBoxPlayTrack_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void picBoxPauseTrack_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void picBoxPauseTrack_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void picBoxNextTrack_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void picBoxNextTrack_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void picBoxRepeatTrack_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void picBoxRepeatTrack_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void picBoxVolume_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void picBoxVolume_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void picBoxNoVolume_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void picBoxNoVolume_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void picBoxPreviousTrack_Click(object sender, EventArgs e)
        {
            album = AudioManager.album;
            var nextTrack = album.Tracks
                          .Where(t => t.TrackId < AudioManager.currentlyPlayingTrackId)
                          .OrderByDescending(t => t.TrackId)
                          .FirstOrDefault();


            if (nextTrack != null)
            {

                AudioManager.Next(nextTrack.FilePath);
                AudioManager.DisplayCurrentPlayingTrackDetails(nextTrack);

                currentPlayingTrackId = nextTrack.TrackId;
            }
        }

        private void picBoxNextTrack_Click(object sender, EventArgs e)
        {
            album = AudioManager.album;
            var nextTrack = album.Tracks.FirstOrDefault(t => t.TrackId > AudioManager.currentlyPlayingTrackId);


            if (nextTrack != null)
            {
                AudioManager.Next(nextTrack.FilePath);
                AudioManager.DisplayCurrentPlayingTrackDetails(nextTrack);

                currentPlayingTrackId = nextTrack.TrackId;
            }

        }

        private void picBoxAddAlbum_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void picBoxAddAlbum_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void picBoxHome_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void picBoxHome_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void picBoxSearch_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void picBoxSearch_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void picBoxBackButton_MouseHover_1(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void picBoxBackButton_MouseLeave_1(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void picBoxForwardButton_MouseHover_1(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void picBoxForwardButton_MouseLeave_1(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void picBoxSeekBar_Paint(object sender, PaintEventArgs e)
        {
            float barSize = 0.45f;
            float x = Bar(defaultValue);
            int y = (int)(picBoxSeekBar.Height * barSize);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.FillRectangle(Brushes.DimGray, 0, y, picBoxSeekBar.Width, y / 2);
            e.Graphics.FillRectangle(Brushes.Red, 0, y, x, picBoxSeekBar.Height - 2 * y);

            using (Pen pen = new Pen(Color.Black, 8))
            {
                e.Graphics.DrawEllipse(pen, x + 4, y - 6, picBoxSeekBar.Height / 2, picBoxSeekBar.Height / 2);
                e.Graphics.FillEllipse(Brushes.Red, x + 4, y - 6, picBoxSeekBar.Height / 2, picBoxSeekBar.Height / 2);
            }

            using (Pen pen = new Pen(Color.White, 5))
            {
                e.Graphics.DrawEllipse(pen, x + 4, y - 6, picBoxSeekBar.Height / 2, picBoxSeekBar.Height / 2);

            }
        }

        public float Bar(float value)
        {
            return (picBoxSeekBar.Width - 24) * (value - minValue) / (float)(maxValue - minValue);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (AudioManager.audioFile != null && AudioManager.outputDevice != null && AudioManager.outputDevice.PlaybackState == PlaybackState.Playing)
            {
                float progress = (float)(AudioManager.audioFile.CurrentTime.TotalSeconds / AudioManager.audioFile.TotalTime.TotalSeconds);
                Thumb(progress);
                // Update lblMusicTimer
                lblTrackTimer.Text = $"{AudioManager.audioFile.CurrentTime:mm\\:ss}";
                lblTrackDuration.Text = $"{AudioManager.audioFile.TotalTime:mm\\:ss}";
                // Check if the song has ended
                if (AudioManager.audioFile.CurrentTime >= AudioManager.audioFile.TotalTime)
                {
                    timer.Stop(); // Stop the timer
                    AudioManager.outputDevice.Stop(); // Stop playback
                    picBoxPlayTrack.BringToFront(); // Show play button
                }
            }
        }

        public void Thumb(float value)
        {
            if (value < minValue)
            {
                value = minValue;
            }
            if (value > maxValue)
            {
                value = maxValue;
            }
            defaultValue = value;
            picBoxSeekBar.Refresh();
        }

        private void picBoxSeekBar_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void picBoxSeekBar_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Arrow;
        }

        private void picBoxSeekBar_MouseDown(object sender, MouseEventArgs e)
        {
            mouse = true;
            timer.Stop(); // Pause the timer
            Thumb(picBoxSeekBar_Width(e.X));
        }

        private void picBoxSeekBar_MouseUp(object sender, MouseEventArgs e)
        {
            mouse = false;
            if (AudioManager.audioFile != null && AudioManager.outputDevice != null)
            {
                double newPosition = picBoxSeekBar_Width(e.X) * AudioManager.audioFile.TotalTime.TotalSeconds;

                if (newPosition < AudioManager.audioFile.CurrentTime.TotalSeconds) // If seeking backward
                {
                    AudioManager.outputDevice.Stop(); // Stop playback before rewinding
                    AudioManager.audioFile.Position = 0; // Reset to start
                    AudioManager.audioFile.CurrentTime = TimeSpan.FromSeconds(newPosition);
                    AudioManager.outputDevice.Init(AudioManager.audioFile); // Reinitialize playback
                    AudioManager.outputDevice.Play();
                }
                else // If seeking forward
                {
                    AudioManager.audioFile.CurrentTime = TimeSpan.FromSeconds(newPosition);
                }
            }
            timer.Start(); // Resume the timer after seeking
        }

        private void picBoxSeekBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (!mouse)
            {
                return;
            }
            Thumb(picBoxSeekBar_Width(e.X));
        }
        public float picBoxSeekBar_Width(int x)
        {
            return minValue + (maxValue - minValue) * x / (float)(picBoxSeekBar.Width);
        }

        private void picBoxPlayTrack_Click(object sender, EventArgs e)
        {
            AudioManager.Resume();
            picBoxPlayTrack.SendToBack();
            timer.Start();
        }

        private void picBoxPauseTrack_Click(object sender, EventArgs e)
        {
            AudioManager.Pause();
            picBoxPauseTrack.SendToBack();
            timer.Stop();
        }
    }
}

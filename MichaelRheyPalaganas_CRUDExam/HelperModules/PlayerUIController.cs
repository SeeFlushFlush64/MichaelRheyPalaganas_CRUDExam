using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MichaelRheyPalaganas_CRUDExam.HelperModules
{
    /// <summary>
    /// Responsible for updating the UI based on player state changes
    /// </summary>
    public class PlayerUIController
    {
        private readonly AudioPlaybackManager _audioPlaybackManager;
        private readonly PlaylistManager _playlistManager;
        private readonly MainForm _mainForm;

        // Keep track of UI elements that need updating
        private readonly Label _lblPlayingTrackName;
        private readonly Label _lblPlayingArtist;
        private readonly PictureBox _picBoxPlayingAlbumPic;
        private readonly PictureBox _picBoxPlayTrack;
        private readonly PictureBox _btnPause;
        private readonly PictureBox _picBoxVolumeBar;
        private readonly PictureBox _seekBar;
        private readonly Label _lblCurrentTime;
        private readonly Label _lblTotalTime;
        private readonly PictureBox _picBoxNoVolume;
        private readonly PictureBox _picBoxShuffleTracks;
        private readonly PictureBox _picBoxRepeatTrack;

        // Flag to prevent trackbar position changes from triggering events while updating UI
        private bool _updatingTrackBar = false;

        public PlayerUIController(
            MainForm mainForm,
            AudioPlaybackManager audioPlaybackManager,
            PlaylistManager playlistManager)
        {
            _mainForm = mainForm ?? throw new ArgumentNullException(nameof(mainForm));
            _audioPlaybackManager = audioPlaybackManager ?? throw new ArgumentNullException(nameof(audioPlaybackManager));
            _playlistManager = playlistManager ?? throw new ArgumentNullException(nameof(playlistManager));

            // Get references to UI elements from the main form
            _lblPlayingTrackName = mainForm.lblPlayingTrackName;
            _lblPlayingArtist = mainForm.lblPlayingArtist;
            _picBoxPlayingAlbumPic = mainForm.picBoxPlayingAlbumPic;
            _picBoxPlayTrack = mainForm.picBoxPlayTrack;
            _btnPause = mainForm.picBoxPauseTrack;
            _picBoxVolumeBar = mainForm.picBoxVolumeBar;
            _seekBar = mainForm.picBoxSeekBar;
            _lblCurrentTime = mainForm.lblCurrentTime;
            _lblTotalTime = mainForm.lblTotalTime;
            _picBoxNoVolume = mainForm.picBoxNoVolume;
            _picBoxShuffleTracks = mainForm.picBoxShuffleTracks;
            _picBoxRepeatTrack = mainForm.picBoxRepeatTrack;

            // Subscribe to events from the managers
            SubscribeToEvents();

            // Initialize UI state
            UpdatePlaybackControls();
        }

        private void SubscribeToEvents()
        {
            // Subscribe to playback events
            _audioPlaybackManager.PlaybackStarted += (s, e) => UpdatePlaybackControls();
            _audioPlaybackManager.PlaybackPaused += (s, e) => UpdatePlaybackControls();
            _audioPlaybackManager.PlaybackResumed += (s, e) => UpdatePlaybackControls();
            _audioPlaybackManager.PlaybackStopped += (s, e) => UpdatePlaybackControls();
            _audioPlaybackManager.PlaybackPositionChanged += HandlePlaybackPositionChanged;
            _audioPlaybackManager.VolumeChanged += (s, volume) => UpdateVolumeControls();

            // Subscribe to playlist events
            _playlistManager.TrackChanged += HandleTrackChanged;
            _playlistManager.AlbumChanged += HandleAlbumChanged;

            // Subscribe to UI control events
            _picBoxVolumeBar.Scroll += (s, e) => _audioPlaybackManager.SetVolume(_picBoxVolumeBar.Value / 100f);
            _seekBar.MouseDown += (s, e) => _updatingTrackBar = true;
            _seekBar.MouseUp += HandleProgressBarMouseUp;

            // Play/Pause button events
            _picBoxPlayTrack.Click += (s, e) =>
            {
                if (!_audioPlaybackManager.IsPlaying && _playlistManager.CurrentTrack != null)
                {
                    _audioPlaybackManager.Resume();
                }
                else if (_playlistManager.CurrentTrack != null)
                {
                    _audioPlaybackManager.PlayMp3(_playlistManager.CurrentTrack.FilePath);
                }
            };

            _btnPause.Click += (s, e) => _audioPlaybackManager.Pause();

            // Mute button event
            _picBoxNoVolume.Click += (s, e) =>
            {
                if (_audioPlaybackManager.IsMuted)
                    _audioPlaybackManager.Unmute();
                else
                    _audioPlaybackManager.Mute();
            };

            // Shuffle and repeat button events
            _picBoxShuffleTracks.Click += (s, e) =>
            {
                _playlistManager.ShuffleEnabled = !_playlistManager.ShuffleEnabled;
                UpdatePlaylistControls();
            };

            _picBoxRepeatTrack.Click += (s, e) =>
            {
                _playlistManager.RepeatEnabled = !_playlistManager.RepeatEnabled;
                UpdatePlaylistControls();
            };
        }

        // Handle track changes
        private void HandleTrackChanged(object sender, TrackChangedEventArgs e)
        {
            // Use Invoke to ensure UI updates happen on the UI thread
            _mainForm.Invoke((MethodInvoker)delegate
            {
                _lblPlayingTrackName.Text = e.Track.TrackName;
                UpdateNowPlayingInfo();
            });
        }

        // Handle album changes
        private void HandleAlbumChanged(object sender, AlbumChangedEventArgs e)
        {
            // Use Invoke to ensure UI updates happen on the UI thread
            _mainForm.Invoke((MethodInvoker)delegate
            {
                UpdateNowPlayingInfo();
            });
        }

        // Handle playback position changes
        private void HandlePlaybackPositionChanged(object sender, PlaybackPositionEventArgs e)
        {
            // Use Invoke to ensure UI updates happen on the UI thread
            _mainForm.Invoke((MethodInvoker)delegate
            {
                if (!_updatingTrackBar)
                {
                    UpdateTimeDisplay(e.Position, _audioPlaybackManager.TotalTime);
                }
            });
        }

        // Handle mouse up on progress bar (seeking)
        private void HandleProgressBarMouseUp(object sender, MouseEventArgs e)
        {
            if (_audioPlaybackManager.TotalTime.TotalSeconds > 0)
            {
                double percentage = (double)_seekBar.Value / _seekBar.Maximum;
                TimeSpan newPosition = TimeSpan.FromSeconds(percentage * _audioPlaybackManager.TotalTime.TotalSeconds);
                _audioPlaybackManager.SetPosition(newPosition);
            }
            _updatingTrackBar = false;
        }

        // Update the now playing information
        private void UpdateNowPlayingInfo()
        {
            if (_playlistManager.CurrentTrack != null && _playlistManager.CurrentAlbum != null)
            {
                _lblPlayingTrackName.Text = _playlistManager.CurrentTrack.TrackName;
                _lblPlayingArtist.Text = _playlistManager.CurrentAlbum.Artist;
                _picBoxPlayingAlbumPic.ImageLocation = _playlistManager.CurrentAlbum.AlbumPicture;

                // Update total time display
                if (_audioPlaybackManager.TotalTime.TotalSeconds > 0)
                {
                    _lblTotalTime.Text = FormatTimeSpan(_audioPlaybackManager.TotalTime);
                }
                else
                {
                    _lblTotalTime.Text = "00:00";
                }
            }
            else
            {
                // No track playing
                _lblPlayingTrackName.Text = "No Track Playing";
                _lblPlayingArtist.Text = "";
                _picBoxPlayingAlbumPic.ImageLocation = null;
                _lblCurrentTime.Text = "00:00";
                _lblTotalTime.Text = "00:00";
            }
        }

        // Update time display
        private void UpdateTimeDisplay(TimeSpan currentTime, TimeSpan totalTime)
        {
            _lblCurrentTime.Text = FormatTimeSpan(currentTime);
            _lblTotalTime.Text = FormatTimeSpan(totalTime);

            if (totalTime.TotalSeconds > 0)
            {
                double percentage = currentTime.TotalSeconds / totalTime.TotalSeconds;
                _seekBar.Value = (int)(percentage * _seekBar.Maximum);
            }
            else
            {
                _seekBar.Value = 0;
            }
        }

        // Format TimeSpan as mm:ss
        private string FormatTimeSpan(TimeSpan time)
        {
            return $"{(int)time.TotalMinutes:D2}:{time.Seconds:D2}";
        }

        // Update play/pause buttons based on playback state
        private void UpdatePlaybackControls()
        {
            // Use Invoke to ensure UI updates happen on the UI thread
            _mainForm.Invoke((MethodInvoker)delegate
            {
                bool isPlaying = _audioPlaybackManager.IsPlaying;
                _picBoxPlayTrack.Visible = !isPlaying;
                _btnPause.Visible = isPlaying;

                // Update volume controls
                UpdateVolumeControls();

                // Update playlist controls
                UpdatePlaylistControls();
            });
        }

        // Update volume UI
        private void UpdateVolumeControls()
        {
            // Use Invoke to ensure UI updates happen on the UI thread
            _mainForm.Invoke((MethodInvoker)delegate
            {
                _picBoxVolumeBar.Value = (int)(_audioPlaybackManager.CurrentVolume * 100);
                _picBoxNoVolume.BackColor = _audioPlaybackManager.IsMuted ? System.Drawing.Color.Red : System.Drawing.Color.Transparent;
            });
        }

        // Update shuffle/repeat buttons
        private void UpdatePlaylistControls()
        {
            // Use Invoke to ensure UI updates happen on the UI thread
            _mainForm.Invoke((MethodInvoker)delegate
            {
                _picBoxShuffleTracks.BackColor = _playlistManager.ShuffleEnabled ? System.Drawing.Color.Blue : System.Drawing.Color.Transparent;
                _picBoxRepeatTrack.BackColor = _playlistManager.RepeatEnabled ? System.Drawing.Color.Blue : System.Drawing.Color.Transparent;
            });
        }
    }
}

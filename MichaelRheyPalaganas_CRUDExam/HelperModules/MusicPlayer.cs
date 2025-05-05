using MichaelRheyPalaganas_CRUDExam.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MichaelRheyPalaganas_CRUDExam.HelperModules
{
    /// <summary>
    /// Main player class that coordinates between the modules
    /// </summary>
    public class MusicPlayer
    {
        // The three specialized modules
        private readonly AudioPlaybackManager _audioManager;
        private readonly PlaylistManager _playlistManager;
        private readonly PlayerUIController _uiController;

        // Constructor that initializes and connects all components
        public MusicPlayer(MainForm mainForm)
        {
            if (mainForm == null)
                throw new ArgumentNullException(nameof(mainForm));

            // Create the modules in the correct order (dependency order)
            _audioManager = new AudioPlaybackManager();
            _playlistManager = new PlaylistManager(_audioManager);
            _uiController = new PlayerUIController(mainForm, _audioManager, _playlistManager);
        }

        // Public methods to control playback

        public void LoadAlbum(Album album, List<Track> tracks)
        {
            _playlistManager.LoadAlbum(album, tracks);
        }

        public void PlayTrack(int trackId)
        {
            _playlistManager.PlayTrackById(trackId);
        }

        public void PlayPause()
        {
            if (_audioManager.IsPlaying)
            {
                _audioManager.Pause();
            }
            else
            {
                if (_playlistManager.CurrentTrack != null)
                {
                    _audioManager.Resume();
                }
            }
        }

        public void Stop()
        {
            _audioManager.Stop();
        }

        public void Next()
        {
            _playlistManager.PlayNext();
        }

        public void Previous()
        {
            _playlistManager.PlayPrevious();
        }

        public void ToggleShuffle()
        {
            _playlistManager.ShuffleEnabled = !_playlistManager.ShuffleEnabled;
        }

        public void ToggleRepeat()
        {
            _playlistManager.RepeatEnabled = !_playlistManager.RepeatEnabled;
        }

        public void SetVolume(int volumePercentage)
        {
            _audioManager.SetVolume(volumePercentage / 100f);
        }

        public void ToggleMute()
        {
            if (_audioManager.IsMuted)
            {
                _audioManager.Unmute();
            }
            else
            {
                _audioManager.Mute();
            }
        }

        // Clean up resources
        public void Dispose()
        {
            _audioManager.Dispose();
        }
    }
}

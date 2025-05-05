using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MichaelRheyPalaganas_CRUDExam.HelperModules
{
    /// <summary>
    /// Responsible for core audio playback operations and device management
    /// </summary>
    public class AudioPlaybackManager
    {
        private WaveOutEvent _outputDevice;
        private AudioFileReader _audioFile;
        private bool _isPlaying = false;
        private bool _isMuted = false;
        private float _previousVolume = 1.0f; // Default to full volume
        private float _currentVolume = 1.0f;

        // Events to notify subscribers of playback state changes
        public event EventHandler PlaybackStarted;
        public event EventHandler PlaybackPaused;
        public event EventHandler PlaybackStopped;
        public event EventHandler PlaybackResumed;
        public event EventHandler<PlaybackPositionEventArgs> PlaybackPositionChanged;
        public event EventHandler<float> VolumeChanged;

        // Properties
        public bool IsPlaying => _isPlaying;
        public bool IsMuted => _isMuted;
        public float CurrentVolume => _currentVolume;
        public TimeSpan CurrentPosition => _audioFile?.CurrentTime ?? TimeSpan.Zero;
        public TimeSpan TotalTime => _audioFile?.TotalTime ?? TimeSpan.Zero;

        public AudioPlaybackManager()
        {
            // Initialize any required resources
        }

        // Clean up resources when done
        public void Dispose()
        {
            Stop();
        }

        // Method to play the track
        public void PlayMp3(string filePath)
        {
            // Stop the current track if it's playing
            Stop();

            // Initialize and play the new track
            _outputDevice = new WaveOutEvent();
            _audioFile = new AudioFileReader(filePath);
            _audioFile.Volume = _currentVolume;

            // Subscribe to playback events
            _outputDevice.PlaybackStopped += (s, e) =>
            {
                _isPlaying = false;
                PlaybackStopped?.Invoke(this, EventArgs.Empty);
            };

            _outputDevice.Init(_audioFile);
            _outputDevice.Play();
            _isPlaying = true;

            // Start position tracking
            StartPositionTracking();

            // Notify subscribers
            PlaybackStarted?.Invoke(this, EventArgs.Empty);
        }

        // Method to pause the track
        public void Pause()
        {
            if (_outputDevice != null && _outputDevice.PlaybackState == PlaybackState.Playing)
            {
                _outputDevice.Pause();
                _isPlaying = false;
                PlaybackPaused?.Invoke(this, EventArgs.Empty);
            }
        }

        // Method to resume playback
        public void Resume()
        {
            if (_outputDevice != null && _outputDevice.PlaybackState == PlaybackState.Paused)
            {
                _outputDevice.Play();
                _isPlaying = true;
                PlaybackResumed?.Invoke(this, EventArgs.Empty);
            }
        }

        // Method to stop the track
        public void Stop()
        {
            if (_outputDevice != null)
            {
                _outputDevice.Stop();
                _outputDevice.Dispose();
                _outputDevice = null;
                _audioFile?.Dispose();
                _audioFile = null;
                _isPlaying = false;
                PlaybackStopped?.Invoke(this, EventArgs.Empty);
            }
        }

        // Volume control methods
        public void Mute()
        {
            if (_audioFile != null && !_isMuted)
            {
                _previousVolume = _audioFile.Volume;
                _audioFile.Volume = 0.0f;
                _isMuted = true;
                VolumeChanged?.Invoke(this, 0.0f);
            }
        }

        public void Unmute()
        {
            if (_audioFile != null && _isMuted)
            {
                _audioFile.Volume = _previousVolume;
                _isMuted = false;
                VolumeChanged?.Invoke(this, _previousVolume);
            }
        }

        public void SetVolume(float volume)
        {
            _currentVolume = Math.Clamp(volume, 0.0f, 1.0f);

            if (_audioFile != null)
            {
                _audioFile.Volume = _currentVolume;

                // If we're setting a non-zero volume, we're implicitly unmuting
                if (_currentVolume > 0 && _isMuted)
                {
                    _isMuted = false;
                }

                VolumeChanged?.Invoke(this, _currentVolume);
            }
        }

        // Position control methods
        public void SetPosition(TimeSpan position)
        {
            if (_audioFile != null)
            {
                _audioFile.CurrentTime = position;
                PlaybackPositionChanged?.Invoke(this, new PlaybackPositionEventArgs(position));
            }
        }

        private System.Timers.Timer _positionTimer;

        private void StartPositionTracking()
        {
            _positionTimer?.Dispose();
            _positionTimer = new System.Timers.Timer(500); // Update every half second
            _positionTimer.Elapsed += (s, e) =>
            {
                if (_isPlaying && _audioFile != null)
                {
                    PlaybackPositionChanged?.Invoke(this, new PlaybackPositionEventArgs(_audioFile.CurrentTime));
                }
            };
            _positionTimer.Start();
        }
    }

    public class PlaybackPositionEventArgs : EventArgs
    {
        public TimeSpan Position { get; }

        public PlaybackPositionEventArgs(TimeSpan position)
        {
            Position = position;
        }
    }
}

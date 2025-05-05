using MichaelRheyPalaganas_CRUDExam.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MichaelRheyPalaganas_CRUDExam.HelperModules
{
    /// <summary>
    /// Responsible for managing playlists, current track information, and navigation
    /// </summary>
    public class PlaylistManager
    {
        private readonly AudioPlaybackManager _audioPlaybackManager;

        private Album _currentAlbum;
        private List<Track> _currentTracks = new List<Track>();
        private int _currentTrackIndex = -1;
        private bool _repeatEnabled = false;
        private bool _shuffleEnabled = false;
        private Random _random = new Random();
        private List<int> _shuffleHistory = new List<int>();

        // Events to notify subscribers of playlist changes
        public event EventHandler<TrackChangedEventArgs> TrackChanged;
        public event EventHandler PlaylistEnded;
        public event EventHandler<AlbumChangedEventArgs> AlbumChanged;

        // Properties
        public Track CurrentTrack => _currentTrackIndex >= 0 && _currentTrackIndex < _currentTracks.Count ?
                                     _currentTracks[_currentTrackIndex] : null;
        public Album CurrentAlbum => _currentAlbum;
        public bool HasPrevious => _currentTrackIndex > 0 || (_repeatEnabled && _currentTracks.Count > 0);
        public bool HasNext => _currentTrackIndex < _currentTracks.Count - 1 || (_repeatEnabled && _currentTracks.Count > 0);
        public bool RepeatEnabled
        {
            get => _repeatEnabled;
            set => _repeatEnabled = value;
        }
        public bool ShuffleEnabled
        {
            get => _shuffleEnabled;
            set
            {
                _shuffleEnabled = value;
                // Reset shuffle history when changing shuffle state
                _shuffleHistory.Clear();
                if (_currentTrackIndex >= 0)
                    _shuffleHistory.Add(_currentTrackIndex);
            }
        }

        public PlaylistManager(AudioPlaybackManager audioPlaybackManager)
        {
            _audioPlaybackManager = audioPlaybackManager ?? throw new ArgumentNullException(nameof(audioPlaybackManager));

            // Subscribe to playback events to handle end-of-track
            _audioPlaybackManager.PlaybackStopped += HandlePlaybackStopped;
        }

        // Method to load an album and its tracks
        public void LoadAlbum(Album album, List<Track> tracks)
        {
            if (album == null || tracks == null)
                throw new ArgumentNullException("Album and tracks cannot be null");

            _currentAlbum = album;
            _currentTracks = tracks.OrderBy(t => t.TrackId).ToList();
            _currentTrackIndex = -1;
            _shuffleHistory.Clear();

            // Notify subscribers that the album has changed
            AlbumChanged?.Invoke(this, new AlbumChangedEventArgs(_currentAlbum));
        }

        // Method to play a specific track from the current playlist
        public void PlayTrack(int trackIndex)
        {
            if (trackIndex < 0 || trackIndex >= _currentTracks.Count)
                throw new ArgumentOutOfRangeException(nameof(trackIndex));

            _currentTrackIndex = trackIndex;
            var track = _currentTracks[_currentTrackIndex];

            // Add to shuffle history if shuffle is enabled
            if (_shuffleEnabled && !_shuffleHistory.Contains(_currentTrackIndex))
                _shuffleHistory.Add(_currentTrackIndex);

            // Play the track
            _audioPlaybackManager.PlayMp3(track.FilePath);

            // Notify subscribers that the track has changed
            TrackChanged?.Invoke(this, new TrackChangedEventArgs(track, _currentAlbum));
        }

        // Method to play a specific track by its ID
        public void PlayTrackById(int trackId)
        {
            int index = _currentTracks.FindIndex(t => t.TrackId == trackId);
            if (index >= 0)
                PlayTrack(index);
            else
                throw new ArgumentException($"Track with ID {trackId} not found in current playlist");
        }

        // Method to play the next track
        public void PlayNext()
        {
            if (_currentTracks.Count == 0) return;

            if (_shuffleEnabled)
            {
                PlayNextShuffled();
                return;
            }

            // Normal sequential play
            int nextIndex = _currentTrackIndex + 1;

            // If we're at the end of the playlist
            if (nextIndex >= _currentTracks.Count)
            {
                if (_repeatEnabled)
                {
                    // Start from the beginning if repeat is enabled
                    PlayTrack(0);
                }
                else
                {
                    // Playlist ended
                    PlaylistEnded?.Invoke(this, EventArgs.Empty);
                }
            }
            else
            {
                // Play the next track
                PlayTrack(nextIndex);
            }
        }

        // Method to play the previous track
        public void PlayPrevious()
        {
            if (_currentTracks.Count == 0) return;

            if (_shuffleEnabled)
            {
                PlayPreviousShuffled();
                return;
            }

            // Normal sequential play
            int prevIndex = _currentTrackIndex - 1;

            // If we're at the beginning of the playlist
            if (prevIndex < 0)
            {
                if (_repeatEnabled)
                {
                    // Go to the end if repeat is enabled
                    PlayTrack(_currentTracks.Count - 1);
                }
                // Otherwise do nothing
            }
            else
            {
                // Play the previous track
                PlayTrack(prevIndex);
            }
        }

        // Shuffle play methods
        private void PlayNextShuffled()
        {
            // If we've played all tracks in shuffle mode
            if (_shuffleHistory.Count >= _currentTracks.Count)
            {
                if (_repeatEnabled)
                {
                    // Start a new shuffle sequence but keep the current track as the first in history
                    int currentTrack = _currentTrackIndex;
                    _shuffleHistory.Clear();
                    _shuffleHistory.Add(currentTrack);

                    // Pick a random track that's not the current one
                    int nextIndex;
                    do
                    {
                        nextIndex = _random.Next(_currentTracks.Count);
                    } while (nextIndex == _currentTrackIndex);

                    PlayTrack(nextIndex);
                }
                else
                {
                    // Playlist ended
                    PlaylistEnded?.Invoke(this, EventArgs.Empty);
                }
            }
            else
            {
                // Pick a random track that hasn't been played yet
                int nextIndex;
                do
                {
                    nextIndex = _random.Next(_currentTracks.Count);
                } while (_shuffleHistory.Contains(nextIndex));

                PlayTrack(nextIndex);
            }
        }

        private void PlayPreviousShuffled()
        {
            // If we have a previous track in the shuffle history
            if (_shuffleHistory.Count > 1)
            {
                // Remove the current track from history
                _shuffleHistory.RemoveAt(_shuffleHistory.Count - 1);

                // Play the previous track in the shuffle history
                int prevIndex = _shuffleHistory[_shuffleHistory.Count - 1];

                // Remove it from history since PlayTrack will add it back
                _shuffleHistory.RemoveAt(_shuffleHistory.Count - 1);

                PlayTrack(prevIndex);
            }
        }

        // Handle end of track playback
        private void HandlePlaybackStopped(object sender, EventArgs e)
        {
            // If the track ended naturally (not stopped by user)
            if (_audioPlaybackManager.IsPlaying)
            {
                // Auto-advance to the next track
                PlayNext();
            }
        }
    }

    public class TrackChangedEventArgs : EventArgs
    {
        public Track Track { get; }
        public Album Album { get; }

        public TrackChangedEventArgs(Track track, Album album)
        {
            Track = track;
            Album = album;
        }
    }

    public class AlbumChangedEventArgs : EventArgs
    {
        public Album Album { get; }

        public AlbumChangedEventArgs(Album album)
        {
            Album = album;
        }
    }
}

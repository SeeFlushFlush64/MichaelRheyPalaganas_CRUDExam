﻿using MichaelRheyPalaganas_CRUDExam.Models.Entities;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MichaelRheyPalaganas_CRUDExam
{
    public static class AudioManager
    {
        private static WaveOutEvent _outputDevice;
        private static AudioFileReader _audioFile;
        public static int currentlyPlayingTrackId;
        public static MainForm parentForm;
        public static Album album;

        private static bool _isPlaying = false;


       
        // Property to check if any track is playing
        public static bool IsPlaying => _isPlaying;

        // Method to play the track
        public static void PlayMp3(string filePath)
        {
            // Stop the current track if it's playing
            Stop();

            // Initialize and play the new track
            _outputDevice = new WaveOutEvent();
            _audioFile = new AudioFileReader(filePath);
            _outputDevice.Init(_audioFile);
            _outputDevice.Play();

            _isPlaying = true;
        }

        // Method to pause the track
        public static void Pause()
        {
            if (_outputDevice != null && _outputDevice.PlaybackState == PlaybackState.Playing)
            {
                _outputDevice.Pause();
                _isPlaying = false;
            }
        }

        // Method to resume playback
        public static void Resume()
        {
            if (_outputDevice != null && _outputDevice.PlaybackState == PlaybackState.Paused)
            {
                _outputDevice.Play();
                _isPlaying = true;
            }
        }

        // Method to stop the track
        public static void Stop()
        {
            if (_outputDevice != null)
            {
                _outputDevice.Stop();
                _outputDevice.Dispose();
                _outputDevice = null;
                _audioFile?.Dispose();
                _audioFile = null;
                _isPlaying = false;
            }
        }

        // Method to skip to the next track (if applicable)
        public static void Next(string filePath)
        {
            Stop(); // Stop the current track
            PlayMp3(filePath); // Play the next track
        }

        // Method to go to the previous track (if applicable)
        public static void Previous(string filePath)
        {
            Stop(); // Stop the current track
            PlayMp3(filePath); // Play the previous track
        }

        public static void DisplayCurrentPlayingTrackDetails(Track track)
        {
            currentlyPlayingTrackId = track.TrackId; // update current track ID
            parentForm.lblPlayingTrackName.Text = track.TrackName;
            parentForm.lblPlayingArtist.Text = album.Artist;
            parentForm.picBoxPlayingAlbumPic.ImageLocation = album.AlbumPicture;
            parentForm.picBoxPlayTrack.SendToBack();
        }
    }

}

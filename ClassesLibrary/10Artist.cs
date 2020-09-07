using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ClassesLibrary
{
    public class Artist
    {
        //fields

        private Song[] _tracks;
        private string _album;
        

        //properties

        public Song[] Tracks
        {
            get { return _tracks; }
            set { _tracks = value; }
        }
        public string Album
        {
            get { return _album; }
            set { _album = value; }
        }
        public string Genre { get; set; }

        //ctor
        
        public Artist(Song[] tracks, string album, string genre)
        {
            Tracks = tracks;
            Album = album;
            Genre = genre;
        }

        //method

            //TODO Fix Song[]method in 10Artist

        public override string ToString()
        {
            string songsArray = "";

            foreach (Song song in Tracks)
            {
                songsArray += song + "\n";
                Console.WriteLine(song);
            }

            return string.Format("Tracklist: {0}\nAlbum: {1}\nGenre: {2}\n", songsArray, Album, Genre); 
        }

    }
}

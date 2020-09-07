using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesLibrary
{
    public class Song
    {
        //fields
        private string _artist;
        private string _title;
        private int _lengthinseconds;

        //properties
        public string Artist
        {
            get { return _artist; }
            set { _artist = value; }
        }
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }
        public int LengthInSeconds
        {
            get { return _lengthinseconds; }
            set { _lengthinseconds = value; }
        }


        //ctor
        public Song(string artist, string title, int lengthInSeconds)
        {
            Artist = artist;
            Title = title;
            LengthInSeconds = lengthInSeconds;
        }

        //method
        public override string ToString()
        {
            return string.Format($"Artist: {Artist}\nTitle: {Title}\nLength in Seconds: {LengthInSeconds}\n");
        }

        public Song() { }
    }
}

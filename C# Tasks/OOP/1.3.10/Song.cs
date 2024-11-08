using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._3._10
{
    public class Song
    {
        public Song()
        {
            Title = "unknown";    
            Performer = "unknown";    
        }
        public Song(string title) : this()
        {
            Title = title;
        }
        public Song(string title, string performer) : this(title) 
        {
            Performer = performer;
        }
        public Song(Song s)
        {
            Title = s.Title;
            Performer = s.Performer;
        }

        public string Title { get; set; } = null!;
        public string Performer { get; set; } = null!;

        public override string ToString()
        {
            return $"{Title} {Performer}";
        }
    }
}

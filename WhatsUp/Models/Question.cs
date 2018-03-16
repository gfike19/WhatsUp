using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WhatsUp.Models
{
    public class Question
    {
        public string Ask { get; set; }
        public string Author { get; set; }
        public int ID { get; set; }
        public DateTime DateAsked { get; set; }
        public int Likes { get; set; }
        public int Dislikes { get; set; }
        public int NetLikes { get; set; }
        public bool Answered { get; set; }
        public string Topic { get; set; }
        public List<string> Comments { get; set;}

        public Question () { }
    }
}

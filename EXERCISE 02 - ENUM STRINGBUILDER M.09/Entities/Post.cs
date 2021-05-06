using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EXERCISE_02___ENUM_STRINGBUILDER_M._09.Entities;
namespace EXERCISE_02___ENUM_STRINGBUILDER_M._09.Entities {
    class Post {
        private DateTime dateTime;
        private string v1;
        private string v2;

        //------------------------------- START -------------------------------//
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Comments> Comments { get; set; }
        //------------------------------- CONST -------------------------------//
        public Post() { 
        }

        public Post(DateTime moment, string title, string content, int likes) {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }

        public Post(DateTime dateTime, string v1, string v2) {
            this.dateTime = dateTime;
            this.v1 = v1;
            this.v2 = v2;
        }

        //------------------------------- MET -------------------------------//
        public void AddComment(Comments comment) {
            Comments.Add(comment);
        }

        public void RemoveComment(Comments comment) {
            Comments.Remove(comment);
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.Append(Title);
            sb.Append(Likes);
            sb.Append("Likes -");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy"));
            sb.AppendLine(Content);
            sb.AppendLine("Comments: ");
            foreach(Comments c in Comments) {
                sb.AppendLine(c.Text);
            }
            return sb.ToString();
        }
        //-------------------------------- END -------------------------------//
    }
}

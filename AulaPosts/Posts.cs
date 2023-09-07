using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaPosts
{
    class Posts
    {
        public DateTime Date { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();

        public Posts(List<Comment> Comments)
        {
            this.Comments = Comments;
        }

        public Posts(DateTime date, string title, string content, int likes)
        {
            Date = date;
            Title = title;
            Content = content;
            Likes = likes;
        }

        public void AddComment(Comment x)
        {
            Comments.Add(x);
        }

        public void RemoveComment(Comment x)
        {
            Comments.Remove(x);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=\n" + Title);
            sb.Append(Likes);
            sb.Append(" Likes - ");
            sb.AppendLine(Date.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(Content);
            sb.Append("Comments: ");
            foreach (Comment each in Comments)
            {
                sb.AppendLine(each.Text);
            }

            return sb.ToString();
        }
    }
}


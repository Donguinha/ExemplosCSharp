using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaPosts
{
    internal class Comment
    {
        public string Text { get; set; }

        public Comment() {}

        public Comment(string comment)
        {
            Text = comment;
        }

        public override string ToString()
        {
            return $"{Text}";
        }
    }
}

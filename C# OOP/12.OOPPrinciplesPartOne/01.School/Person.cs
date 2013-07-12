using System;
using System.Linq;

namespace School
{
    public class Person : IComment
    {
        private string name;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string Comments { get; set; }

        /// <summary>
        /// Add a comment to this student
        /// </summary>
        /// <param name="text"></param>
        public void AddComment(string text)
        {
            this.Comments = text;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
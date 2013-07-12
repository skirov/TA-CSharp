using System;
using System.Linq;

namespace School
{
    public interface IComment
    {
        string Comments { get; }
        void AddComment(string text);
    }
}
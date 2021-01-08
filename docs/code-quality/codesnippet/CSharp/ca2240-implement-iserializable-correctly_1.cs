using System;
using System.Security.Permissions;
using System.Runtime.Serialization;

namespace Samples1
{
    // Violates this rule
    [Serializable]
    public class Book : ISerializable
    {
        private readonly string _Title;

        public Book(string title)
        {
            if (title == null)
                throw new ArgumentNullException("title");

            _Title = title;
        }

        protected Book(SerializationInfo info, StreamingContext context)
        {
            if (info == null)
                throw new ArgumentNullException("info");

            _Title = info.GetString("Title");
        }

        public string Title
        {
            get { return _Title; }
        }

        [SecurityPermission(SecurityAction.Demand, SerializationFormatter = true)]
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            if (info == null)
                throw new ArgumentNullException("info");

            info.AddValue("Title", _Title);
        }
    }

    // Violates this rule
    [Serializable]
    public class LibraryBook : Book
    {
        private readonly DateTime _CheckedOut;

        public LibraryBook(string title, DateTime checkedOut)
            : base(title)
        {
            _CheckedOut = checkedOut;
        }

        public DateTime CheckedOut
        {
            get { return _CheckedOut; }
        }
    }
}
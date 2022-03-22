using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceC
{
    class Post
    {
        private static int currentPostId;

        protected int ID { get; set; }
        protected string Title { get; set; }

        public string SendByUserName { get; set; }

        protected bool IsPublic { get; set; }


        public Post()
        {
            ID = 0;
            Title = "My First Post";
            IsPublic = true;
            SendByUserName = "Denis Panjuta";
        }

        public Post(string title, bool isPublic, string senByUserName)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.SendByUserName = senByUserName;
            this.IsPublic = IsPublic;
        }

        protected int GetNextID()
        {
            return ++currentPostId;
        }

        public void Update(string title, bool isPublic)
        {
            this.Title = title;
            this.IsPublic = isPublic;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - by {2}", this.ID, this.Title, this.SendByUserName);
        }

    }
}

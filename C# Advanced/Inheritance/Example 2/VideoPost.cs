using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InheritanceC
{
    class VideoPost : Post
    {
        protected bool IsPllaying = false;
        protected int currDuration = 0;

        protected int Length { get; set; }
        protected string VideoURL { get; set; }
        Timer timer;

        public VideoPost()
        {

        }

        public VideoPost(string title, string senByUseraname, string videoURL,int length, bool isPublic)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.SendByUserName = senByUseraname;
            this.IsPublic = isPublic;

            // porpriade de videoPost
            this.Length = length;
            this.VideoURL = videoURL;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - by {2} here's the Link: {3} and is {4}", this.ID, this.Title, this.SendByUserName, this.VideoURL, this.Length);
        }

        public void Play()
        {
            if (!IsPllaying)
            {
                IsPllaying = true;
                Console.WriteLine("Playing");
                timer = new Timer(TimerCallback, null, 0, 1000);
            }
        }

        private void TimerCallback(Object o)
        {
            if (currDuration < Length)
            {
                currDuration++;
                Console.WriteLine("Video at {0}s", currDuration);
                GC.Collect();
            }
            else
            {
                Stop();
            }
        }

        public void Stop()
        {
            if (IsPllaying)
            {
                IsPllaying = false;
                Console.WriteLine("Stopped at {0}s", currDuration);
                currDuration = 0;
                timer.Dispose();
            }
        }

    }
}

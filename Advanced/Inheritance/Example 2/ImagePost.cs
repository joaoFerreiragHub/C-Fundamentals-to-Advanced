using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceC
{
    class ImagePost : Post
    {
        public string  ImageURL { get; set; }

        public ImagePost()
        {

        }
        
        public ImagePost(string title, string senByUseraname, string imageURL, bool isPublic)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.SendByUserName = senByUseraname;
            this.IsPublic = isPublic;

            // porpriade de imageUrl
            this.ImageURL = imageURL;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - by {2} here's the Link: {3}", this.ID, this.Title, this.SendByUserName, this.ImageURL);
        }
    }
}

using System;

namespace InheritanceC
{
    class Program
    {
        static void Main(string[] args)
        {
            Post post1 = new Post("Thanks for the birthay wishes", true, "Denis Panjuta");
            Console.WriteLine(post1.ToString());

            ImagePost imagepost = new ImagePost("Check out my new shoes",
                "Denis Panjuta", "https://images.com/shoes", true);

            VideoPost videopost = new VideoPost("Check out my new video",
                "Denis Panjuta", "https://images.com/shoes", 10, true);

            Console.WriteLine(imagepost.ToString());
            Console.WriteLine(videopost.ToString());

            videopost.Play();
            Console.WriteLine("Press any key to stop");
            Console.ReadKey();
            videopost.Stop();
            Console.ReadLine();

        }
    }
}

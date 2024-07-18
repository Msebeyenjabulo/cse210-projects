class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Video1", "Author1", 300);
        video1.AddComment(new Comment("User1", "Great video!"));
        video1.AddComment(new Comment("User2", "Nice content."));
        video1.AddComment(new Comment("User3", "Very informative."));

        Video video2 = new Video("Video2", "Author2", 450);
        video2.AddComment(new Comment("User4", "Awesome!"));
        video2.AddComment(new Comment("User5", "Loved it!"));
        video2.AddComment(new Comment("User6", "Keep it up."));

        Video video3 = new Video("Video3", "Author3", 600);
        video3.AddComment(new Comment("User7", "Interesting."));
        video3.AddComment(new Comment("User8", "Good work."));
        video3.AddComment(new Comment("User9", "Very detailed."));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
            Console.WriteLine();
        }
    }
}

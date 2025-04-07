// Puts each video in a list.
public class Videos
{
    public List<Video> _videos = new List<Video>();

    public void DisplayVideos()
    {
        foreach (Video video in _videos)
        {
            Console.WriteLine("==================");
            video.DisplayVideo();
        }
    }
}
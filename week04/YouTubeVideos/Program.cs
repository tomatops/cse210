using System;

class Program
{
    static void Main(string[] args)
    {
        // Setting values for video1
        Video video1 = new Video();
        video1._title = "Bloom Boutique: A Review";
        video1._author = "Sarah's Wardrobe";
        video1._length = 180;

        Comment video1Comment1 = new Comment();
        video1Comment1._name = "Kasey Fisher";
        video1Comment1._text = "That soft navy blue dress is gorgeous!";

        Comment video1Comment2 = new Comment();
        video1Comment2._name = "Holly Stuart";
        video1Comment2._text = "That style makes me want to buy that red tee.";

        Comment video1Comment3 = new Comment();
        video1Comment3._name = "AutumnFall";
        video1Comment3._text = "A nice thick coat for autumn? The maple one is to die for!";

        video1._comments.Add(video1Comment1);
        video1._comments.Add(video1Comment2);
        video1._comments.Add(video1Comment3);

        // Setting values for video2
        Video video2 = new Video();
        video2._title = "LOOK: High quality clothing from various boutiques";
        video2._author = "Fashion with Kelly";
        video2._length = 600;

        Comment video2Comment1 = new Comment();
        video2Comment1._name = "CatFish";
        video2Comment1._text = "A hoodie with cat ears, I like!";

        Comment video2Comment2 = new Comment();
        video2Comment2._name = "Just James";
        video2Comment2._text = "Wow, that polo shirt looks comfortable.";

        Comment video2Comment3 = new Comment();
        video2Comment3._name = "Undertones";
        video2Comment3._text = "Kelly always showcases the best ones! Bloom Boutique's rustwood coat is superb!";

        video2._comments.Add(video2Comment1);
        video2._comments.Add(video2Comment2);
        video2._comments.Add(video2Comment3);

        // Setting values for video3
        Video video3 = new Video();
        video3._title = "Trying out new releases from Bloom Boutique!";
        video3._author = "Style Planet";
        video3._length = 240;

        Comment video3Comment1 = new Comment();
        video3Comment1._name = "Sandy Beach";
        video3Comment1._text = "New skirt design? I love it!!!";

        Comment video3Comment2 = new Comment();
        video3Comment2._name = "Marianney";
        video3Comment2._text = "The frills on that pink top will definitely get a space for my closet.";

        Comment video3Comment3 = new Comment();
        video3Comment3._name = "Flower Heart";
        video3Comment3._text = "Their new spring collection, especially the blue top with dramatic sleeves? Awesome!";

        video3._comments.Add(video3Comment1);
        video3._comments.Add(video3Comment2);
        video3._comments.Add(video3Comment3);

        Videos videos = new Videos();
        videos._videos.Add(video1);
        videos._videos.Add(video2);
        videos._videos.Add(video3);
        videos.DisplayVideos();
    }
}
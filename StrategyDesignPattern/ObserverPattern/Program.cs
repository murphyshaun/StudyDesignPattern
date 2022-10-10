
using ObserverPattern.Model;
using ObserverPattern.Notifier;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var videoData = new VideoData();

            var emailNotifier = new EmailNotifier(videoData);
            var phoneNotifier = new PhoneNotifier(videoData);
            var youtubeNotifier = new YoutubeNotifier(videoData);

            videoData.SetTitle("Observer Design Pattern");

            videoData.DetachObserver(youtubeNotifier);

            System.Console.WriteLine("================================");
            videoData.SetDescription("KYLS");

            System.Console.ReadLine();
        }
    }
}

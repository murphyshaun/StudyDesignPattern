
using ObserverPattern.Model;

namespace ObserverPattern.Notifier
{
    public class EmailNotifier : Observer
    {
        public EmailNotifier(Subject subject)
        {
            this.subject = subject;
            this.subject.AttachObserver(this);
        }
        public override void Notify(Subject subject, object arg)
        {
            if (subject is VideoData videoData)
            {
                System.Console.WriteLine(
                    string.Format($"Notify all subscribers via EMAIL with new data" +
                                  $"\n\tName: {videoData.GetTitle()}" +
                                  $"\n\tDescription: {videoData.GetDescription()}" +
                                  $"\n\tFile name: {videoData.GetFileName()}"));
            }
        }
    }
}

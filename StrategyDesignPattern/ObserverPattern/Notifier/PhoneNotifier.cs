using ObserverPattern.Model;

namespace ObserverPattern.Notifier
{
    public class PhoneNotifier : Observer
    {
        public PhoneNotifier(Subject subject)
        {
            this.subject = subject;
            this.subject.AttachObserver(this);
        }

        public override void Notify(Subject subject, object arg)
        {
            if (subject is VideoData videoData)
            {
                System.Console.WriteLine(
                    string.Format($"Notify all subscribers via PHONE with new data" +
                                  $"\n\tName: {videoData.GetTitle()}" +
                                  $"\n\tDescription: {videoData.GetDescription()}" +
                                  $"\n\tFile name: {videoData.GetFileName()}"));
            }
        }
    }
}


using ObserverPattern.Notifier;

namespace ObserverPattern.Model
{
    public class VideoData : Subject
    {
        #region fields
        private string _title;
        private string _description;
        private string _fileName;
        private readonly EmailNotifier _emailNotifier;
        private readonly PhoneNotifier _phoneNotifier;
        private readonly YoutubeNotifier _youtubeNotifier;
        #endregion

        #region GetSetProperties
        public string GetTitle()
        {
            return _title;
        }

        public void SetTitle(string value)
        {
            _title = value;
            VideoDataChanged();
        }

        public string GetDescription()
        {
            return _description;
        }

        public void SetDescription(string value)
        {
            _description = value;
            VideoDataChanged();
        }

        public string GetFileName()
        {
            return _fileName;
        }

        public void SetFileName(string value)
        {
            _fileName = value;
            VideoDataChanged();
        }

        private void VideoDataChanged()
        {
            NotifyObservers(this, null);
        }
        #endregion
    }
}

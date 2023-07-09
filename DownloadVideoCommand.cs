using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeUploader._18
{
    class DownloadVideoCommand:Command
    {
        ReceiverVideoDownload receiver;
        string videoURL;
        public DownloadVideoCommand(ReceiverVideoDownload receiver, string videoURL)
        {
            this.receiver = receiver;
            this.videoURL = videoURL;
        }
        public override void Start()
        {
            Console.WriteLine("Команда отправлена");
            receiver.DownloadVideo(videoURL);
        }
        public override void Cancel()
        {
            throw new NotImplementedException();
        }
    }
}

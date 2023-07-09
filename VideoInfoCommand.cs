using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeUploader._18
{
    class VideoInfoCommand: Command
    {
        ReceiverVideoInfo receiver;
        string videoURL;
        public VideoInfoCommand(ReceiverVideoInfo receiver, string videoURL)
        {
            this.receiver = receiver;
            this.videoURL = videoURL;
        }
        public override void Start()
        {
            Console.WriteLine("Команда отправлена");
            receiver.GetVideoInfo(videoURL);
        }
        public override void Cancel()
        {
            throw new NotImplementedException();
        }
    }
}

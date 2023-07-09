using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;

namespace YoutubeUploader._18
{
    class ReceiverVideoInfo
    {
        public async void GetVideoInfo(string videoURL)
        {
            Console.WriteLine("Получаем информацию о видео");

            var client = new YoutubeClient();

            var _videoInfo = await client.Videos.GetAsync(videoURL);
            Console.WriteLine($"Name : {_videoInfo.Title}\n Duration: {_videoInfo.Duration}\n Author: {_videoInfo.Author}");
        }
    }
}

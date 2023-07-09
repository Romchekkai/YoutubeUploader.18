using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Converter;

namespace YoutubeUploader._18
{
    class ReceiverVideoDownload
    {
            public async void DownloadVideo(string videoURL)
            {
                Console.WriteLine("Загружаем видео");

                var client = new YoutubeClient();
                var videoInfo = await client.Videos.GetAsync(videoURL);

            await client.Videos.DownloadAsync(videoURL, $@"Downloads/{videoInfo.Title}.mp4", builder => builder.SetContainer("mpeg").SetPreset(ConversionPreset.UltraFast).SetFFmpegPath(@"bin/Debug/net7.0/ffmpeg"));
            }
    }
}

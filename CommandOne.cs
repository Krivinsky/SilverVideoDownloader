using CliWrap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Converter;

namespace SilverVideoDownloader
{
    /// <summary>
    /// Конкретная реализация команды.
    /// </summary>
    class CommandOne : Command
    {
        Receiver receiver;

        public override string VideoUrl { get; }

        public CommandOne(Receiver receiver, string videoUrl)
        {
            this.receiver = receiver;
            this.VideoUrl = videoUrl;
        }

        public override void GetVideoInfo(string videoUrl)
        {
            YoutubeClient client = new YoutubeClient();

            var info = client.Videos.GetAsync(videoUrl).Result;

            Console.WriteLine($"Название:  {info.Title}");
            Console.WriteLine($"Название:  {info.Duration}");
            Console.WriteLine($"Название:  {info.Author}");
        }

        public override void DownloadVideo(string videoUrl)
        {
           YoutubeClient client = new YoutubeClient();

            client.Videos.DownloadAsync(
                videoUrl,
                @"E:\Video\001.mp4", 
                builder => builder.SetPreset(ConversionPreset.UltraFast));
            Console.WriteLine("Видео загружается...");
            Task.WaitAll();
            Console.WriteLine("Видео загружено");
        }
    }
}

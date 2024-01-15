using CliWrap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Converter;
using YoutubeExplode.Videos.Streams;

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

        public override async Task DownloadVideo(string videoUrl)
        {
            YoutubeClient client = new YoutubeClient();

            var video = await client.Videos.GetAsync(videoUrl);
            var streamManifest = await client.Videos.Streams.GetManifestAsync(video.Id);
            var streamInfo = streamManifest.GetMuxedStreams().GetWithHighestVideoQuality();

            await client.Videos.DownloadAsync(videoUrl, @"E:\Video\001.mp4");
            
            Console.WriteLine("Видео загружается...");
            Task.WaitAll();
            Console.WriteLine("Видео загружено");
        }
    }
}

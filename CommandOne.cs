using CliWrap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;

namespace SilverVideoDownloader
{
    /// <summary>
    /// Конкретная реализация команды.
    /// </summary>
    class CommandOne : Command
    {
        Receiver receiver;

        public CommandOne(Receiver receiver)
        {
            this.receiver = receiver;
        }

        // Выполнить
        //public override void Run()
        //{
        //    Console.WriteLine("Команда отправлена");
        //    receiver.Operation();
        //}

        // Отменить
        //public override void Cancel()
        //{
        //}


        public override void GetVideoInfo(string videoUrl)
        {
            YoutubeClient client = new YoutubeClient();
            var info = client.Videos.GetAsync(videoUrl);
        }

        public override void DownloadVideo(string videoUrl)
        {

        }
    }
}

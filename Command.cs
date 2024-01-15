using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SilverVideoDownloader
{
    /// <summary>
    /// Базовый класс команды
    /// </summary>
    public abstract class Command
    {
        public abstract string VideoUrl { get; }

        public abstract void GetVideoInfo(string videoUrl);
        public abstract Task DownloadVideo(string videoUrl);
    }
}

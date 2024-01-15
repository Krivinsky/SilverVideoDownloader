using CliWrap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SilverVideoDownloader
{
    /// <summary>
    /// Отправитель команды
    /// </summary>
    public class Sender
    {
        public Command _command;

        public void SetCommand(Command command)
        {
            _command = command;
        }

        // Выполнить
        public void Run()
        {
            _command.GetVideoInfo(_command.VideoUrl);
            _command.DownloadVideo(_command.VideoUrl);
        }

        // Отменить
        public void Cancel()
        {
        }
    }
}

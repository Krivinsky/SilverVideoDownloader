using System.Reflection;
using YoutubeExplode;

namespace SilverVideoDownloader
{

    public class Program
    {

        static void Main(string[] args)
        {
            // создадим отправителя
            var sender = new Sender();

            // создадим получателя
            var receiver = new Receiver();

            // создадим команду
            var commandOne = new CommandOne(receiver);

            // инициализация команды
            sender.SetCommand(commandOne);

            //  выполнение
            sender.Run();


            Console.WriteLine("Введите URL видео для скачивания");
            string videoUrl = Console.ReadLine();
        }
    }
}
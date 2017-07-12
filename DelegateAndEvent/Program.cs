using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEvent
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() { Title = "Video 1" };
            var videoEncoder = new VideoEncoder(); //event publisher
            var mailService = new MailService(); //event subscriber
            var messageService = new MessageService(); //another event subscriber

            videoEncoder.VideoEncoded += mailService.OnVideoEncoded; //adding subscriber to event
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded; //adding another subscriber to event


            videoEncoder.Encode(video);
            Console.ReadLine();
        }
    }
}

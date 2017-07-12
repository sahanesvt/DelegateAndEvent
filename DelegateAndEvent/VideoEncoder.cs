using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace DelegateAndEvent
{
    public class VideoEncoder
    {
        //1. Define a delegate
        //2. Define an event based on that delagate
        //3. Raise the event

        //public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args); //hard way to define event handler
        //public event VideoEncodedEventHandler VideoEncoded; //hard way to define event handler

        public event EventHandler<VideoEventArgs> VideoEncoded; //easy way to define event handler

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video...");
            Thread.Sleep(3000); // just for effect

            OnVideoEncoded(video);
        }

        protected virtual void OnVideoEncoded(Video video)
        {
            if(VideoEncoded != null)
            {
                VideoEncoded(this, new VideoEventArgs(){ Video = video});
            }
        }
    }
}

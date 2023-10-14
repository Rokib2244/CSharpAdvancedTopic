using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    public class VideoEncoder
    {
        //public delegate void VideoEncodedEventHandler(object source, EventArgs args);
        //Above this declaring the delegate, we can achieve by "EventHandler" which is built in in framework for Event and for this reason, we are comentig above code.
        //public event VideoEncodedEventHandler VideoEncoded;
        public event EventHandler VideoEncoded;
        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video...");
            Thread.Sleep(3000);
            OnVideoEncoded();
        }
        protected virtual void OnVideoEncoded() { 
            if(VideoEncoded != null)
                VideoEncoded(this, EventArgs.Empty);
            
        }
    }
}

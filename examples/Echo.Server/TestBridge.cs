using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotNetty.Buffers;
using DotNetty.Transport.Channels;

namespace Echo.Server
{
    public class TestUserThread
    {
        public TestUserThread()
        {
            Task.Factory.StartNew(SendMessage, TaskCreationOptions.LongRunning);

            //System.Threading.Thread a = new System.Threading.Thread(SendMessage);
            //a.IsBackground = true;

            //a.Start();

        }
        EchoServerHandler _handler;
        public void BindHandler(EchoServerHandler handler)
        {
            _handler = handler;
        }

        void SendMessage()
        {
            int index = 0;
            while (true)
            {                
                //if(_handler != null)
                //{
                //    index++;
                //    var m = "this is " + index + " message.";
                //    var buf = Encoding.UTF8.GetBytes(m);
                //    var buffer = Unpooled.Buffer();
                //    buffer.WriteBytes(buf);
                //    _handler.Context.WriteAndFlushAsync(buffer);
                //    //_handler.Handler(buf);
                //    Console.WriteLine(m);

                //    //_handler.Context.Read();
                //}

                System.Threading.Thread.Sleep(1000 * 20);
            }
        }
    }
}

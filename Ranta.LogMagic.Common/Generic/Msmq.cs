using System;
using System.Collections.Generic;
using System.Linq;
using System.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Ranta.LogMagic.Common.Generic
{
    public class Msmq<T> where T : class, new()
    {
        public string Path { get; private set; }

        private MessageQueue queue;

        private TimeSpan waitTimeSpan;

        public Msmq(string path)
        {
            this.Path = path;

            waitTimeSpan = new TimeSpan(0, 0, 2);

            if (!MessageQueue.Exists(path))
            {
                queue = MessageQueue.Create(path);
            }
            else
            {
                queue = new MessageQueue(path);
            }
            queue.Formatter = new BinaryMessageFormatter();
        }

        public void Enqueue(T obj)
        {
            queue.Send(obj);
        }

        public T Dequeue()
        {
            T t = default(T);

            try
            {
                var message = queue.Receive(waitTimeSpan);

                if (message != null)
                {
                    t = message.Body as T;
                }
            }
            catch (MessageQueueException)
            {
            }

            return t;
        }
    }
}

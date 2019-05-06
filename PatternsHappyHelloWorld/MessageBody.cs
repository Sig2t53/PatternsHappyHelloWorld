using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsHappyHelloWorld
{
    public class MessageBody
    {
        object payload;
        public object GetPayload()
        {
            return payload;
        }

        public void Configure(Object obj)
        {
            payload = obj;
        }

        public void Send(MessageStrategy ms)
        {
            ms.SendMessage();
        }
    }
}

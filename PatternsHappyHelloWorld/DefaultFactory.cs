using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsHappyHelloWorld
{
    public class DefaultFactory : AbstractStrategyFactory
    {
        private DefaultFactory() { }
        static DefaultFactory instance;
        public static AbstractStrategyFactory GetInstance()
        {
            if (instance == null) instance = new DefaultFactory();
            return instance;
        }

        public override MessageStrategy CreateStrategy(MessageBody mb)
        {
            return new DefaultMessageStratege(mb);
        }

        private class DefaultMessageStratege : MessageStrategy
        {
            MessageBody body;
            public DefaultMessageStratege(MessageBody mb)
            {
                body = mb;
            }

            public void SendMessage()
            {
                object obj = body.GetPayload();
                Console.WriteLine(obj);
            }
        }
    }
}

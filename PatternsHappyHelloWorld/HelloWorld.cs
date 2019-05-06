using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsHappyHelloWorld
{
    public class HelloWorld
    {
        static void Main(string[] args)
        {
            MessageBody mb = new MessageBody();
            mb.Configure("Hello World");
            AbstractStrategyFactory asf = DefaultFactory.GetInstance();
            MessageStrategy strategy = asf.CreateStrategy(mb);
            mb.Send(strategy);
        }
    }
}

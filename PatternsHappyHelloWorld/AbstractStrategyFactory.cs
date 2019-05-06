using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsHappyHelloWorld
{
    public abstract class AbstractStrategyFactory
    {
        public abstract MessageStrategy CreateStrategy(MessageBody mb);
    }
}

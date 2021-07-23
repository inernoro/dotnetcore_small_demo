using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using demo.core;

namespace demo.rabbitmq
{

    public class RabbitMQ : IRabbitMQ
    {
        private readonly ICache _cache;

        public RabbitMQ(ICache cache)
        {
            _cache = cache;
        }


        public void WriteQueue()
        {
            _cache.Write("rabbitmq", "value");

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using demo.core;

namespace demo.store
{
    public class Store : IStore
    {

        private ICache _cache;
        private IRabbitMQ _rabbitMq;

        public Store(IRabbitMQ rabbitMq, ICache cache)
        {
            _rabbitMq = rabbitMq;
            _cache = cache;
        }

        public void StoreWrite(string field, string value)
        {
            //写一次缓存
            _cache.Write(field, value);

            //写一次消息队列
            _rabbitMq.WriteQueue();

            
        }
    }
}

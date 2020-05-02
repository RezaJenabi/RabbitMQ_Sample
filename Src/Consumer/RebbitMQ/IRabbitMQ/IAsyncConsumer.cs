﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Consumer.RebbitMQ.IRabbitMQ
{
    interface IAsyncConsumer2<in T> where T : class
    {
        Task ConsumeAsync(T message);
    } 
}

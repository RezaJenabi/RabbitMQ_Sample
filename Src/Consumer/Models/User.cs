﻿using Common.Bus;
using Common.Attributes;

namespace Consumer.Models
{
    [Queue(queueName: "Person", exchangeName: "Exchange_Sample", routingKey: "Exchange_Sample_Person")]
    public class User : IntegrationEvent
    {
        public string Name { get; set; }
    }
}

using Confluent.Kafka;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace KafkaConfluentTest
{
    public class KafkaProducer
    {
        public void Produce()
        {
            var config = new ProducerConfig
            {
                BootstrapServers = "localhost:9092",
                ClientId = Dns.GetHostName()
            };

            using (var producer = new ProducerBuilder<Null, string>(config).Build())
            {
                producer.Produce(
       "neer_topic", new Message<Null, string> { Value = "hello world" }, handler);

            }


        }

        private void handler(DeliveryReport<Null, string> obj)
        {
           
        }
    }
}

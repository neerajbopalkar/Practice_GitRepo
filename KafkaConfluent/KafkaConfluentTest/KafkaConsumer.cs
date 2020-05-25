using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Generic;
using Confluent.Kafka;

namespace KafkaConfluentTest
{
    class KafkaConsumer
    {
        internal void Consume()
        {
            var config = new ConsumerConfig
            {
                BootstrapServers = "localhost:9092",
                GroupId = "foo",
                AutoOffsetReset = AutoOffsetReset.Earliest
            };

            using (var consumer = new ConsumerBuilder<Ignore, string>(config).Build())
            {

                consumer.Subscribe("neer_topic");

                //while (!cancelled)
                //{
                    var consumeResult = consumer.Consume(TimeSpan.FromSeconds(1));

                    var value = consumeResult.Message.Value;
                    Console.WriteLine($"Value: {value}");
                    // handle consumed message.

                //}

                consumer.Close();

            }

        }

    }
}


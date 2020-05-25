using System;

namespace KafkaConfluentTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //REf - https://docs.confluent.io/current/clients/dotnet.html
            new KafkaProducer().Produce();
            new KafkaConsumer().Consume();
        }
    }
}

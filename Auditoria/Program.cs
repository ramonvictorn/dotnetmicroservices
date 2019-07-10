using System;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;
using System.Threading;
namespace Auditoria
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World do Auditoria! com rabbit no host");
            var factory = new ConnectionFactory() { HostName = "localhost" };
            using (var connection = factory.CreateConnection())
            {
                using (var channel = connection.CreateModel())
                {
                    channel.QueueDeclare(queue: "task_queue",
                                        durable: false,
                                        exclusive: false,
                                        autoDelete: false,
                                        arguments: null);
                    // for better balance in workers
                    channel.BasicQos(0, 1, false);

                    var consumer = new EventingBasicConsumer(channel);
                    consumer.Received += (model, ea) =>
                    {
                        var body = ea.Body;
                        var message = Encoding.UTF8.GetString(body);
                        Console.WriteLine(" [x] Received {0}", message);
                        // simulate hard work
                        int dots = message.Split('.').Length - 1;
                        Thread.Sleep(dots * 3000);
                        Console.WriteLine(" [x] Done");
                        channel.BasicAck(deliveryTag: ea.DeliveryTag, multiple: false);

                    };
                    channel.BasicConsume(queue: "task_queue",
                                        autoAck: false,
                                        consumer: consumer);

                    Console.WriteLine(" Press [enter] to exite.");
                    Console.ReadLine();
                }
            }
        }
    }
}

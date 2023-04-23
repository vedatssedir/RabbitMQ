

using RabbitMQ.Client;

ConnectionFactory factory = new();
//Baglantı olusturma
factory.Uri = new("amqps://lvllnjmp:48Gu0NlBOizb1W7Uaxf0PUVVTsoMsAWe@toad.rmq.cloudamqp.com/lvllnjmp");
//Baglantı da kanal acma
using IConnection connection = factory.CreateConnection();
using IModel channel = connection.CreateModel();


//Queue olusturma

channel.QueueDeclare(queue: "example-queue 1");

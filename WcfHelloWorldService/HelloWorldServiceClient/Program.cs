using System;
using HelloWorldServiceClient.HelloWorldServiceReference;

namespace HelloWorldServiceClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new HelloWorldClient("NetTcpBinding_IHelloWorld");

            var person = new Name
            {
                First = "Lukasz",
                Last = "Galazka"
            };

            Console.WriteLine(client.SayHello(person));
            Console.ReadLine();
        }
    }
}
using Grpc.Core;
using Grpc.Net.Client;
using GrpcPrac;
using System;
using System.Threading.Channels;

namespace GrpcClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5001"); 

            var client = new Greeter.GreeterClient(channel);
            var user = "you";

            var reply = client.SayHello(new HelloRequest { Name = user });
            Console.WriteLine("Greeting: " + reply.Message);


            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}

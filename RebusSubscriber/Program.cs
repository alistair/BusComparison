using System;
using Rebus.Activation;
using Rebus.Config;
using Rebus.RabbitMq;
using RebusPublisher;
using System.Threading.Tasks;
using Rebus.Handlers;

namespace RebusSubscriber
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");
			using (var activitor = new BuiltinHandlerActivator ()) {
				var bus = Configure.With (activitor)
					.Transport (t => t.UseRabbitMq("amqp://localhost/", "rebussubscriber"))
					.Start();
				bus.Subscribe<RebusMessage> ();
			}
		}
	}

	public class ImportantThingHappenedHandler : IHandleMessages<RebusMessage>
	{
		public async Task Handle(RebusMessage message)
		{
			Console.WriteLine (message.MyProperty);
		}
	}
}

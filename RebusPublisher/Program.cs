using System;
using Rebus.Activation;
using Rebus.Config;
using Rebus.RabbitMq;

namespace RebusPublisher
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");
			using (var activitor = new BuiltinHandlerActivator ()) {
				var bus = Configure.With (activitor)
					.Transport (t => t.UseRabbitMq("amqp://localhost/", "rebuspublisher"))
						.Start();

				bus.Publish (new RebusMessage {
					MyProperty = "Hello World"
				});
			}
		}
	}

	public class RebusMessage {
		public string MyProperty {
			get;
			set;
		}
	}
}

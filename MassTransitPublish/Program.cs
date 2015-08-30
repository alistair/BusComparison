using System;
using MassTransit;

namespace MassTransitPublish
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Bus.Initialize (sbc => {
				sbc.ReceiveFrom("rabbitmq://localhost/publish");
				sbc.UseRabbitMq();
				sbc.UseControlBus();

			});

			while (true) {
				Bus.Instance.Publish (new TestMessage { MyProperty = "Hi" });
				//Console.ReadLine ();
			}

		}
	}

				public class TestMessage {
					public string MyProperty {
						get;
						set;
					}
				}
}

using System;
using MassTransit;
using MassTransitPublish;

namespace MassTransitSubscribe
{
	class MainClass
	{
			public static void Main (string[] args)
			{
			var bus = ServiceBusFactory.New (sbc => {
					sbc.UseRabbitMq();
					sbc.ReceiveFrom("rabbitmq://localhost/subscribe");
					//sbc.UseControlBus();
					sbc.Subscribe(subs=>
					{
						subs.Handler<TestMessage>(msg=>
							{
								Console.WriteLine(msg.MyProperty);
							});
					});
				});

				//Bus.Instance.Publish (new TestMessage { MyProperty = "Hi" });
			}
	}

	public class MessageHandler : Consumes<TestMessage>.All {
		#region All implementation

		public void Consume (TestMessage message)
		{
			Console.WriteLine ("Wow! im here");
		}

		#endregion


	}
}


====================== MassTransit =================================

Exchange	MassTransitPublish:TestMessage    type=fanout
Routing Key	
Redelivered	●
Properties	
message_id:	eaac0000-800b-94de-0da6-08d2ae104f59
delivery_mode:	2
headers:	
Content-Type:	application/vnd.masstransit+json
Payload
265 bytes
Encoding: string
{
  "destinationAddress": "rabbitmq://localhost/MassTransitPublish:TestMessage",
  "headers": {},
  "message": {
    "myProperty": "Hi"
  },
  "messageType": [
    "urn:message:MassTransitPublish:TestMessage"
  ],
  "sourceAddress": "rabbitmq://localhost/publish"
}





======================= REBUS ======================================

Message Type:     RebusPublisher.RebusMessage, RebusPublisher
queues:           rebuspublisher,  rebussubscriber
PublishMessage    exchange:Rebus -> rebussubscriber via Routing key
                    (subscription/RebusPublisher.RebusMessage, RebusPublisher)

Exchange:         Rebus  type = topic
Routing Key       subscription/RebusPublisher.RebusMessage, RebusPublisher
delivery_mode:    2
headers:
                  rbs2-intent:                  pub
                  rbs2-msg-id:                  56e954fc-bd05-40ea-bdf1-0ff993858b55
                  rbs2-return-address:          rebuspublisher
                  rbs2-senttime:                2015-08-30T18:26:54.9609280+12:00
                  rbs2-corr-id:                 56e954fc-bd05-40ea-bdf1-0ff993858b55
                  rbs2-msg-type:                RebusPublisher.RebusMessage, RebusPublisher
                  rbs2-content-type:            application/json;charset=utf-8

Payload:          {"$type":"RebusPublisher.RebusMessage, RebusPublisher","MyProperty":"Hello World"}

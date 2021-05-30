﻿using KafkaMasstransitWebApp2.Events;
using MassTransit;
using System.Threading.Tasks;

namespace KafkaMasstransitWebApp2.Handlers
{
    internal class VideoCreatedEventConsumer : IConsumer<VideoCreatedEvent>
    {
        public Task Consume(ConsumeContext<VideoCreatedEvent> context)
        {
            var message = context.Message.Title;
            return Task.CompletedTask;
        }
    }
}

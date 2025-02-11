﻿namespace MyTelegram.Domain.Events.Chat;

public class ChatPhotoEditedEvent : RequestAggregateEvent2<ChatAggregate, ChatId>, IHasCorrelationId
{
    public ChatPhotoEditedEvent(RequestInfo requestInfo,
        long chatId,
        byte[] photo,
        string messageActionData,
        long randomId,
        Guid correlationId) : base(requestInfo)
    {
        ChatId = chatId;
        Photo = photo;
        MessageActionData = messageActionData;
        RandomId = randomId;
        CorrelationId = correlationId;
    }

    public long ChatId { get; }
    public string MessageActionData { get; }
    public byte[] Photo { get; }
    public long RandomId { get; }

    public Guid CorrelationId { get; }
}

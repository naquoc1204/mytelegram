﻿namespace MyTelegram.ReadModel.Impl;

public class ReplyReadModel : IReplyReadModel,
    IAmReadModelFor<MessageSaga, MessageSagaId, ReplyToChannelMessageCompletedEvent>
{
    public long ChannelId { get; private set; }
    public string Id { get; private set; } = default!;
    public int MaxId { get; private set; }
    public IReadOnlyCollection<Peer>? RecentRepliers { get; private set; }
    public int Replies { get; private set; }
    public int RepliesPts { get; private set; }
    public int ReplyToMsgId { get; private set; }
    public int SavedFromMsgId { get; private set; }
    public long SavedFromPeerId { get; private set; }
    public virtual long? Version { get; set; }

    public Task ApplyAsync(IReadModelContext context,
        IDomainEvent<MessageSaga, MessageSagaId, ReplyToChannelMessageCompletedEvent> domainEvent,
        CancellationToken cancellationToken)
    {
        if (string.IsNullOrEmpty(Id))
        {
            Id = MessageId.Create(domainEvent.AggregateEvent.ChannelId, domainEvent.AggregateEvent.ReplyToMsgId).Value;
        }

        Replies++;
        RepliesPts = domainEvent.AggregateEvent.RepliesPts;
        ChannelId = domainEvent.AggregateEvent.ChannelId;
        ReplyToMsgId = domainEvent.AggregateEvent.ReplyToMsgId;
        MaxId = domainEvent.AggregateEvent.MaxId;
        SavedFromPeerId = domainEvent.AggregateEvent.SavedFromPeerId;
        SavedFromMsgId = domainEvent.AggregateEvent.SavedFromMsgId;
        RecentRepliers = domainEvent.AggregateEvent.RecentRepliers;

        return Task.CompletedTask;
    }
}

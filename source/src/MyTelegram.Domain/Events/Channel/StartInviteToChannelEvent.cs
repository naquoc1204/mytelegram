﻿namespace MyTelegram.Domain.Events.Channel;

public class StartInviteToChannelEvent : RequestAggregateEvent2<ChannelAggregate, ChannelId>, IHasCorrelationId
{
    public StartInviteToChannelEvent(RequestInfo requestInfo,
        long channelId,
        long inviterId,
        IReadOnlyList<long> memberUidList,
        IReadOnlyList<long> botUidList,
        int date,
        int maxMessageId,
        int channelHistoryMinId,
        long randomId,
        string messageActionData,
        //bool isBot,
        bool broadcast,
        Guid correlationId):base(requestInfo)
    {
        ChannelId = channelId;
        InviterId = inviterId;
        MemberUidList = memberUidList;
        BotUidList = botUidList;
        Date = date;
        MaxMessageId = maxMessageId;
        ChannelHistoryMinId = channelHistoryMinId;
        RandomId = randomId;
        MessageActionData = messageActionData;
        Broadcast = broadcast;
        //IsBot = isBot;
        CorrelationId = correlationId;
    }

    public IReadOnlyList<long> BotUidList { get; }
    public int ChannelHistoryMinId { get; }
    public long ChannelId { get; }
    public int Date { get; }
    public long InviterId { get; }
    public int MaxMessageId { get; }
    public IReadOnlyList<long> MemberUidList { get; }
    public string MessageActionData { get; }
    public bool Broadcast { get; }
    public long RandomId { get; }

    //public bool IsBot { get; }
    public Guid CorrelationId { get; }
}

﻿namespace MyTelegram.Domain.CommandHandlers.Messaging;

public class
    StartReplyToMessageCommandHandler : CommandHandler<MessageAggregate, MessageId, StartReplyToMessageCommand>
{
    public override Task ExecuteAsync(MessageAggregate aggregate,
        StartReplyToMessageCommand command,
        CancellationToken cancellationToken)
    {
        aggregate.StartReplyToMessage(command.ReplierPeer, command.ReplyToMsgId, command.CorrelationId);
        return Task.CompletedTask;
    }
}
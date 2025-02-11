﻿using MyTelegram.Domain.Aggregates.Poll;

namespace MyTelegram.Domain.Commands.Poll;

public class CreateVoteAnswerCommand : Command<PollAggregate, PollId, IExecutionResult>
{
    public long PollId { get; }
    public long VoterPeerId { get; }
    public string Option { get; }
    public bool Correct { get; }

    public CreateVoteAnswerCommand(PollId aggregateId,
        long pollId,
        long voterPeerId,
        string option,
        bool correct) : base(aggregateId)
    {
        PollId = pollId;
        VoterPeerId = voterPeerId;
        Option = option;
        Correct = correct;
    }
}
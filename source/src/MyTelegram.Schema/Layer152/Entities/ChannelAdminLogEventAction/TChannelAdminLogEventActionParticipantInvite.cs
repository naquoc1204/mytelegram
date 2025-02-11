﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/channelAdminLogEventActionParticipantInvite" />
///</summary>
[TlObject(0xe31c34d8)]
public sealed class TChannelAdminLogEventActionParticipantInvite : IChannelAdminLogEventAction
{
    public uint ConstructorId => 0xe31c34d8;

    ///<summary>
    ///See <a href="https://core.telegram.org/type/ChannelParticipant" />
    ///</summary>
    public MyTelegram.Schema.IChannelParticipant Participant { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        Participant.Serialize(bw);
    }

    public void Deserialize(BinaryReader br)
    {
        Participant = br.Deserialize<MyTelegram.Schema.IChannelParticipant>();
    }
}
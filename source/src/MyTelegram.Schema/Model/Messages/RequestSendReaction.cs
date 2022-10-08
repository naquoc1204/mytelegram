﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Messages;

///<summary>
///See <a href="https://core.telegram.org/method/messages.sendReaction" />
///</summary>
[TlObject(0xd30d78d4)]
public sealed class RequestSendReaction : IRequest<MyTelegram.Schema.IUpdates>
{
    public uint ConstructorId => 0xd30d78d4;
    public BitArray Flags { get; set; } = new BitArray(32);
    public bool Big { get; set; }
    public bool AddToRecent { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/InputPeer" />
    ///</summary>
    public MyTelegram.Schema.IInputPeer Peer { get; set; }
    public int MsgId { get; set; }
    public TVector<MyTelegram.Schema.IReaction>? Reaction { get; set; }

    public void ComputeFlag()
    {
        if (Big) { Flags[1] = true; }
        if (AddToRecent) { Flags[2] = true; }
        if (Reaction?.Count > 0) { Flags[0] = true; }
    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Serialize(Flags);
        Peer.Serialize(bw);
        bw.Write(MsgId);
        if (Flags[0]) { Reaction.Serialize(bw); }
    }

    public void Deserialize(BinaryReader br)
    {
        Flags = br.Deserialize<BitArray>();
        if (Flags[1]) { Big = true; }
        if (Flags[2]) { AddToRecent = true; }
        Peer = br.Deserialize<MyTelegram.Schema.IInputPeer>();
        MsgId = br.ReadInt32();
        if (Flags[0]) { Reaction = br.Deserialize<TVector<MyTelegram.Schema.IReaction>>(); }
    }
}

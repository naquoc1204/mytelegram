﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/messageActionRequestedPeer" />
///</summary>
[TlObject(0xfe77345d)]
public sealed class TMessageActionRequestedPeer : IMessageAction
{
    public uint ConstructorId => 0xfe77345d;
    public int ButtonId { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/Peer" />
    ///</summary>
    public MyTelegram.Schema.IPeer Peer { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Write(ButtonId);
        Peer.Serialize(bw);
    }

    public void Deserialize(BinaryReader br)
    {
        ButtonId = br.ReadInt32();
        Peer = br.Deserialize<MyTelegram.Schema.IPeer>();
    }
}
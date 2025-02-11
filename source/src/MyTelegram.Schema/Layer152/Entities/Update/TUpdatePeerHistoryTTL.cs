﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/updatePeerHistoryTTL" />
///</summary>
[TlObject(0xbb9bb9a5)]
public sealed class TUpdatePeerHistoryTTL : IUpdate
{
    public uint ConstructorId => 0xbb9bb9a5;
    public BitArray Flags { get; set; } = new BitArray(32);

    ///<summary>
    ///See <a href="https://core.telegram.org/type/Peer" />
    ///</summary>
    public MyTelegram.Schema.IPeer Peer { get; set; }
    public int? TtlPeriod { get; set; }

    public void ComputeFlag()
    {
        if (TtlPeriod != 0 && TtlPeriod.HasValue) { Flags[0] = true; }
    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Serialize(Flags);
        Peer.Serialize(bw);
        if (Flags[0]) { bw.Write(TtlPeriod.Value); }
    }

    public void Deserialize(BinaryReader br)
    {
        Flags = br.Deserialize<BitArray>();
        Peer = br.Deserialize<MyTelegram.Schema.IPeer>();
        if (Flags[0]) { TtlPeriod = br.ReadInt32(); }
    }
}
﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/messageReplies" />
///</summary>
[TlObject(0x83d60fc2)]
public sealed class TMessageReplies : IMessageReplies
{
    public uint ConstructorId => 0x83d60fc2;
    public BitArray Flags { get; set; } = new BitArray(32);
    public bool Comments { get; set; }
    public int Replies { get; set; }
    public int RepliesPts { get; set; }
    public TVector<MyTelegram.Schema.IPeer>? RecentRepliers { get; set; }
    public long? ChannelId { get; set; }
    public int? MaxId { get; set; }
    public int? ReadMaxId { get; set; }

    public void ComputeFlag()
    {
        if (Comments) { Flags[0] = true; }
        if (RecentRepliers?.Count > 0) { Flags[1] = true; }
        if (ChannelId != 0 && ChannelId.HasValue) { Flags[0] = true; }
        if (MaxId != 0 && MaxId.HasValue) { Flags[2] = true; }
        if (ReadMaxId != 0 && ReadMaxId.HasValue) { Flags[3] = true; }
    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Serialize(Flags);
        bw.Write(Replies);
        bw.Write(RepliesPts);
        if (Flags[1]) { RecentRepliers.Serialize(bw); }
        if (Flags[0]) { bw.Write(ChannelId.Value); }
        if (Flags[2]) { bw.Write(MaxId.Value); }
        if (Flags[3]) { bw.Write(ReadMaxId.Value); }
    }

    public void Deserialize(BinaryReader br)
    {
        Flags = br.Deserialize<BitArray>();
        if (Flags[0]) { Comments = true; }
        Replies = br.ReadInt32();
        RepliesPts = br.ReadInt32();
        if (Flags[1]) { RecentRepliers = br.Deserialize<TVector<MyTelegram.Schema.IPeer>>(); }
        if (Flags[0]) { ChannelId = br.ReadInt64(); }
        if (Flags[2]) { MaxId = br.ReadInt32(); }
        if (Flags[3]) { ReadMaxId = br.ReadInt32(); }
    }
}
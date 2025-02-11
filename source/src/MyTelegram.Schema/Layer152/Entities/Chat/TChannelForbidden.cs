﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/channelForbidden" />
///</summary>
[TlObject(0x17d493d5)]
public sealed class TChannelForbidden : IChat
{
    public uint ConstructorId => 0x17d493d5;
    public BitArray Flags { get; set; } = new BitArray(32);
    public bool Broadcast { get; set; }
    public bool Megagroup { get; set; }
    public long Id { get; set; }
    public long AccessHash { get; set; }
    public string Title { get; set; }
    public int? UntilDate { get; set; }

    public void ComputeFlag()
    {
        if (Broadcast) { Flags[5] = true; }
        if (Megagroup) { Flags[8] = true; }
        if (UntilDate != 0 && UntilDate.HasValue) { Flags[16] = true; }
    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Serialize(Flags);
        bw.Write(Id);
        bw.Write(AccessHash);
        bw.Serialize(Title);
        if (Flags[16]) { bw.Write(UntilDate.Value); }
    }

    public void Deserialize(BinaryReader br)
    {
        Flags = br.Deserialize<BitArray>();
        if (Flags[5]) { Broadcast = true; }
        if (Flags[8]) { Megagroup = true; }
        Id = br.ReadInt64();
        AccessHash = br.ReadInt64();
        Title = br.Deserialize<string>();
        if (Flags[16]) { UntilDate = br.ReadInt32(); }
    }
}
﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Messages;


///<summary>
///See <a href="https://core.telegram.org/constructor/messages.botResults" />
///</summary>
[TlObject(0x947ca848)]
public sealed class TBotResults : IBotResults
{
    public uint ConstructorId => 0x947ca848;
    public BitArray Flags { get; set; } = new BitArray(32);
    public bool Gallery { get; set; }
    public long QueryId { get; set; }
    public string? NextOffset { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/InlineBotSwitchPM" />
    ///</summary>
    public MyTelegram.Schema.IInlineBotSwitchPM? SwitchPm { get; set; }
    public TVector<MyTelegram.Schema.IBotInlineResult> Results { get; set; }
    public int CacheTime { get; set; }
    public TVector<MyTelegram.Schema.IUser> Users { get; set; }

    public void ComputeFlag()
    {
        if (Gallery) { Flags[0] = true; }
        if (NextOffset != null) { Flags[1] = true; }
        if (SwitchPm != null) { Flags[2] = true; }

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Serialize(Flags);
        bw.Write(QueryId);
        if (Flags[1]) { bw.Serialize(NextOffset); }
        if (Flags[2]) { SwitchPm.Serialize(bw); }
        Results.Serialize(bw);
        bw.Write(CacheTime);
        Users.Serialize(bw);
    }

    public void Deserialize(BinaryReader br)
    {
        Flags = br.Deserialize<BitArray>();
        if (Flags[0]) { Gallery = true; }
        QueryId = br.ReadInt64();
        if (Flags[1]) { NextOffset = br.Deserialize<string>(); }
        if (Flags[2]) { SwitchPm = br.Deserialize<MyTelegram.Schema.IInlineBotSwitchPM>(); }
        Results = br.Deserialize<TVector<MyTelegram.Schema.IBotInlineResult>>();
        CacheTime = br.ReadInt32();
        Users = br.Deserialize<TVector<MyTelegram.Schema.IUser>>();
    }
}
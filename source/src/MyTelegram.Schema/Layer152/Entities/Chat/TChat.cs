﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/chat" />
///</summary>
[TlObject(0x41cbf256)]
public sealed class TChat : MyTelegram.Schema.IChat
{
    public uint ConstructorId => 0x41cbf256;
    public BitArray Flags { get; set; } = new BitArray(32);
    public bool Creator { get; set; }
    public bool Left { get; set; }
    public bool Deactivated { get; set; }
    public bool CallActive { get; set; }
    public bool CallNotEmpty { get; set; }
    public bool Noforwards { get; set; }
    public long Id { get; set; }
    public string Title { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/ChatPhoto" />
    ///</summary>
    public MyTelegram.Schema.IChatPhoto Photo { get; set; }
    public int ParticipantsCount { get; set; }
    public int Date { get; set; }
    public int Version { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/InputChannel" />
    ///</summary>
    public MyTelegram.Schema.IInputChannel? MigratedTo { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/ChatAdminRights" />
    ///</summary>
    public MyTelegram.Schema.IChatAdminRights? AdminRights { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/ChatBannedRights" />
    ///</summary>
    public MyTelegram.Schema.IChatBannedRights? DefaultBannedRights { get; set; }

    public void ComputeFlag()
    {
        if (Creator) { Flags[0] = true; }
        if (Left) { Flags[2] = true; }
        if (Deactivated) { Flags[5] = true; }
        if (CallActive) { Flags[23] = true; }
        if (CallNotEmpty) { Flags[24] = true; }
        if (Noforwards) { Flags[25] = true; }
        if (MigratedTo != null) { Flags[6] = true; }
        if (AdminRights != null) { Flags[14] = true; }
        if (DefaultBannedRights != null) { Flags[18] = true; }
    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Serialize(Flags);
        bw.Write(Id);
        bw.Serialize(Title);
        Photo.Serialize(bw);
        bw.Write(ParticipantsCount);
        bw.Write(Date);
        bw.Write(Version);
        if (Flags[6]) { MigratedTo.Serialize(bw); }
        if (Flags[14]) { AdminRights.Serialize(bw); }
        if (Flags[18]) { DefaultBannedRights.Serialize(bw); }
    }

    public void Deserialize(BinaryReader br)
    {
        Flags = br.Deserialize<BitArray>();
        if (Flags[0]) { Creator = true; }
        if (Flags[2]) { Left = true; }
        if (Flags[5]) { Deactivated = true; }
        if (Flags[23]) { CallActive = true; }
        if (Flags[24]) { CallNotEmpty = true; }
        if (Flags[25]) { Noforwards = true; }
        Id = br.ReadInt64();
        Title = br.Deserialize<string>();
        Photo = br.Deserialize<MyTelegram.Schema.IChatPhoto>();
        ParticipantsCount = br.ReadInt32();
        Date = br.ReadInt32();
        Version = br.ReadInt32();
        if (Flags[6]) { MigratedTo = br.Deserialize<MyTelegram.Schema.IInputChannel>(); }
        if (Flags[14]) { AdminRights = br.Deserialize<MyTelegram.Schema.IChatAdminRights>(); }
        if (Flags[18]) { DefaultBannedRights = br.Deserialize<MyTelegram.Schema.IChatBannedRights>(); }
    }
}
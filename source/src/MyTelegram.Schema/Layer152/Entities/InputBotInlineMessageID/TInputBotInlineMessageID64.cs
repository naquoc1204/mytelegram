﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/inputBotInlineMessageID64" />
///</summary>
[TlObject(0xb6d915d7)]
public sealed class TInputBotInlineMessageID64 : IInputBotInlineMessageID
{
    public uint ConstructorId => 0xb6d915d7;
    public int DcId { get; set; }
    public long OwnerId { get; set; }
    public int Id { get; set; }
    public long AccessHash { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Write(DcId);
        bw.Write(OwnerId);
        bw.Write(Id);
        bw.Write(AccessHash);
    }

    public void Deserialize(BinaryReader br)
    {
        DcId = br.ReadInt32();
        OwnerId = br.ReadInt64();
        Id = br.ReadInt32();
        AccessHash = br.ReadInt64();
    }
}
﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Updates;


///<summary>
///See <a href="https://core.telegram.org/constructor/updates.differenceTooLong" />
///</summary>
[TlObject(0x4afe8f6d)]
public sealed class TDifferenceTooLong : IDifference
{
    public uint ConstructorId => 0x4afe8f6d;
    public int Pts { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Write(Pts);
    }

    public void Deserialize(BinaryReader br)
    {
        Pts = br.ReadInt32();
    }
}
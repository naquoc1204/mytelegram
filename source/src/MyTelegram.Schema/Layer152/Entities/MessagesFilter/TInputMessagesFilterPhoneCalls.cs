﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/inputMessagesFilterPhoneCalls" />
///</summary>
[TlObject(0x80c99768)]
public sealed class TInputMessagesFilterPhoneCalls : IMessagesFilter
{
    public uint ConstructorId => 0x80c99768;
    public BitArray Flags { get; set; } = new BitArray(32);
    public bool Missed { get; set; }

    public void ComputeFlag()
    {
        if (Missed) { Flags[0] = true; }
    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Serialize(Flags);

    }

    public void Deserialize(BinaryReader br)
    {
        Flags = br.Deserialize<BitArray>();
        if (Flags[0]) { Missed = true; }
    }
}
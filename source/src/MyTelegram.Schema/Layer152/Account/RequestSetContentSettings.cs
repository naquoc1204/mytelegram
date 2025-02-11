﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Account;

///<summary>
///See <a href="https://core.telegram.org/method/account.setContentSettings" />
///</summary>
[TlObject(0xb574b16b)]
public sealed class RequestSetContentSettings : IRequest<IBool>
{
    public uint ConstructorId => 0xb574b16b;
    public BitArray Flags { get; set; } = new BitArray(32);
    public bool SensitiveEnabled { get; set; }

    public void ComputeFlag()
    {
        if (SensitiveEnabled) { Flags[0] = true; }
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
        if (Flags[0]) { SensitiveEnabled = true; }
    }
}

﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Auth;


///<summary>
///See <a href="https://core.telegram.org/constructor/auth.sentCodeTypeSetUpEmailRequired" />
///</summary>
[TlObject(0xa5491dea)]
public sealed class TSentCodeTypeSetUpEmailRequired : ISentCodeType
{
    public uint ConstructorId => 0xa5491dea;
    public BitArray Flags { get; set; } = new BitArray(32);
    public bool AppleSigninAllowed { get; set; }
    public bool GoogleSigninAllowed { get; set; }

    public void ComputeFlag()
    {
        if (AppleSigninAllowed) { Flags[0] = true; }
        if (GoogleSigninAllowed) { Flags[1] = true; }
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
        if (Flags[0]) { AppleSigninAllowed = true; }
        if (Flags[1]) { GoogleSigninAllowed = true; }
    }
}
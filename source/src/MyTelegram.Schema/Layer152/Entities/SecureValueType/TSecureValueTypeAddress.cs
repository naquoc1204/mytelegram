﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/secureValueTypeAddress" />
///</summary>
[TlObject(0xcbe31e26)]
public sealed class TSecureValueTypeAddress : ISecureValueType
{
    public uint ConstructorId => 0xcbe31e26;


    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);

    }

    public void Deserialize(BinaryReader br)
    {

    }
}
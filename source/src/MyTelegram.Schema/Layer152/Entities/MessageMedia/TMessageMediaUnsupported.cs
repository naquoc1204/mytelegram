﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/messageMediaUnsupported" />
///</summary>
[TlObject(0x9f84f49e)]
public sealed class TMessageMediaUnsupported : IMessageMedia
{
    public uint ConstructorId => 0x9f84f49e;


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
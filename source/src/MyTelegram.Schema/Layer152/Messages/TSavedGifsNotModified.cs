﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Messages;


///<summary>
///See <a href="https://core.telegram.org/constructor/messages.savedGifsNotModified" />
///</summary>
[TlObject(0xe8025ca2)]
public sealed class TSavedGifsNotModified : ISavedGifs
{
    public uint ConstructorId => 0xe8025ca2;


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
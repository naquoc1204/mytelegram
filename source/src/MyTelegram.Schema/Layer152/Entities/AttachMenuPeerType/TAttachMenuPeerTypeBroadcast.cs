﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/attachMenuPeerTypeBroadcast" />
///</summary>
[TlObject(0x7bfbdefc)]
public sealed class TAttachMenuPeerTypeBroadcast : IAttachMenuPeerType
{
    public uint ConstructorId => 0x7bfbdefc;


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
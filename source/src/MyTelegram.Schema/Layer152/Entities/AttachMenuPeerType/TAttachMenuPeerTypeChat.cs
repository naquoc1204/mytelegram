﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/attachMenuPeerTypeChat" />
///</summary>
[TlObject(0x509113f)]
public sealed class TAttachMenuPeerTypeChat : IAttachMenuPeerType
{
    public uint ConstructorId => 0x509113f;


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
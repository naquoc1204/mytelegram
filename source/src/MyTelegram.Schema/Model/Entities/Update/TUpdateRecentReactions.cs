﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/updateRecentReactions" />
///</summary>
[TlObject(0x6f7863f4)]
public class TUpdateRecentReactions : IUpdate
{
    public uint ConstructorId => 0x6f7863f4;


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
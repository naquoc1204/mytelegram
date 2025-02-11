﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/updateUserPhone" />
///</summary>
[TlObject(0x5492a13)]
public sealed class TUpdateUserPhone : IUpdate
{
    public uint ConstructorId => 0x5492a13;
    public long UserId { get; set; }
    public string Phone { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Write(UserId);
        bw.Serialize(Phone);
    }

    public void Deserialize(BinaryReader br)
    {
        UserId = br.ReadInt64();
        Phone = br.Deserialize<string>();
    }
}
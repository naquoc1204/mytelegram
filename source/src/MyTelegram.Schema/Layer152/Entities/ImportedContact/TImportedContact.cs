﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/importedContact" />
///</summary>
[TlObject(0xc13e3c50)]
public sealed class TImportedContact : IImportedContact
{
    public uint ConstructorId => 0xc13e3c50;
    public long UserId { get; set; }
    public long ClientId { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Write(UserId);
        bw.Write(ClientId);
    }

    public void Deserialize(BinaryReader br)
    {
        UserId = br.ReadInt64();
        ClientId = br.ReadInt64();
    }
}
﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Account;

///<summary>
///See <a href="https://core.telegram.org/method/account.getContentSettings" />
///</summary>
[TlObject(0x8b9b4dae)]
public sealed class RequestGetContentSettings : IRequest<MyTelegram.Schema.Account.IContentSettings>
{
    public uint ConstructorId => 0x8b9b4dae;

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

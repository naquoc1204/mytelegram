﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Account;

///<summary>
///See <a href="https://core.telegram.org/method/account.sendConfirmPhoneCode" />
///</summary>
[TlObject(0x1b3faa88)]
public sealed class RequestSendConfirmPhoneCode : IRequest<MyTelegram.Schema.Auth.ISentCode>
{
    public uint ConstructorId => 0x1b3faa88;
    public string Hash { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/CodeSettings" />
    ///</summary>
    public MyTelegram.Schema.ICodeSettings Settings { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Serialize(Hash);
        Settings.Serialize(bw);
    }

    public void Deserialize(BinaryReader br)
    {
        Hash = br.Deserialize<string>();
        Settings = br.Deserialize<MyTelegram.Schema.ICodeSettings>();
    }
}

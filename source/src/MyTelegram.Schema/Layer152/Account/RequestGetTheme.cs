﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Account;

///<summary>
///See <a href="https://core.telegram.org/method/account.getTheme" />
///</summary>
[TlObject(0x3a5869ec)]
public sealed class RequestGetTheme : IRequest<MyTelegram.Schema.ITheme>
{
    public uint ConstructorId => 0x3a5869ec;
    public string Format { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/InputTheme" />
    ///</summary>
    public MyTelegram.Schema.IInputTheme Theme { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Serialize(Format);
        Theme.Serialize(bw);
    }

    public void Deserialize(BinaryReader br)
    {
        Format = br.Deserialize<string>();
        Theme = br.Deserialize<MyTelegram.Schema.IInputTheme>();
    }
}

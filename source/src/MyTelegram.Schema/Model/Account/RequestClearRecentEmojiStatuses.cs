﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Account;

///<summary>
///See <a href="https://core.telegram.org/method/account.clearRecentEmojiStatuses" />
///</summary>
[TlObject(0x18201aae)]
public sealed class RequestClearRecentEmojiStatuses : IRequest<IBool>
{
    public uint ConstructorId => 0x18201aae;

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

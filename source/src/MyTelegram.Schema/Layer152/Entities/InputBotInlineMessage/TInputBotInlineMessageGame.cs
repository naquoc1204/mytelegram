﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/inputBotInlineMessageGame" />
///</summary>
[TlObject(0x4b425864)]
public sealed class TInputBotInlineMessageGame : IInputBotInlineMessage
{
    public uint ConstructorId => 0x4b425864;
    public BitArray Flags { get; set; } = new BitArray(32);

    ///<summary>
    ///See <a href="https://core.telegram.org/type/ReplyMarkup" />
    ///</summary>
    public MyTelegram.Schema.IReplyMarkup? ReplyMarkup { get; set; }

    public void ComputeFlag()
    {
        if (ReplyMarkup != null) { Flags[2] = true; }
    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Serialize(Flags);
        if (Flags[2]) { ReplyMarkup.Serialize(bw); }
    }

    public void Deserialize(BinaryReader br)
    {
        Flags = br.Deserialize<BitArray>();
        if (Flags[2]) { ReplyMarkup = br.Deserialize<MyTelegram.Schema.IReplyMarkup>(); }
    }
}
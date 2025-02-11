﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/textStrike" />
///</summary>
[TlObject(0x9bf8bb95)]
public sealed class TTextStrike : IRichText
{
    public uint ConstructorId => 0x9bf8bb95;

    ///<summary>
    ///See <a href="https://core.telegram.org/type/RichText" />
    ///</summary>
    public MyTelegram.Schema.IRichText Text { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        Text.Serialize(bw);
    }

    public void Deserialize(BinaryReader br)
    {
        Text = br.Deserialize<MyTelegram.Schema.IRichText>();
    }
}
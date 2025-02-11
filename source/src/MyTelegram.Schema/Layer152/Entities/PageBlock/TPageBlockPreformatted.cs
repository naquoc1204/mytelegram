﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/pageBlockPreformatted" />
///</summary>
[TlObject(0xc070d93e)]
public sealed class TPageBlockPreformatted : IPageBlock
{
    public uint ConstructorId => 0xc070d93e;

    ///<summary>
    ///See <a href="https://core.telegram.org/type/RichText" />
    ///</summary>
    public MyTelegram.Schema.IRichText Text { get; set; }
    public string Language { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        Text.Serialize(bw);
        bw.Serialize(Language);
    }

    public void Deserialize(BinaryReader br)
    {
        Text = br.Deserialize<MyTelegram.Schema.IRichText>();
        Language = br.Deserialize<string>();
    }
}
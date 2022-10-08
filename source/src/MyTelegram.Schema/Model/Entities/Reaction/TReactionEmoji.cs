﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/reactionEmoji" />
///</summary>
[TlObject(0x1b2286b8)]
public class TReactionEmoji : IReaction
{
    public uint ConstructorId => 0x1b2286b8;
    public string Emoticon { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Serialize(Emoticon);
    }

    public void Deserialize(BinaryReader br)
    {
        Emoticon = br.Deserialize<string>();
    }
}
﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/inputStickerSetEmojiDefaultStatuses" />
///</summary>
[TlObject(0x29d0f5ee)]
public class TInputStickerSetEmojiDefaultStatuses : IInputStickerSet
{
    public uint ConstructorId => 0x29d0f5ee;


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
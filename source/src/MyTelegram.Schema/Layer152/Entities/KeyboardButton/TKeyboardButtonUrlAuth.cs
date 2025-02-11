﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/keyboardButtonUrlAuth" />
///</summary>
[TlObject(0x10b78d29)]
public sealed class TKeyboardButtonUrlAuth : IKeyboardButton
{
    public uint ConstructorId => 0x10b78d29;
    public BitArray Flags { get; set; } = new BitArray(32);
    public string Text { get; set; }
    public string? FwdText { get; set; }
    public string Url { get; set; }
    public int ButtonId { get; set; }

    public void ComputeFlag()
    {
        if (FwdText != null) { Flags[0] = true; }

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Serialize(Flags);
        bw.Serialize(Text);
        if (Flags[0]) { bw.Serialize(FwdText); }
        bw.Serialize(Url);
        bw.Write(ButtonId);
    }

    public void Deserialize(BinaryReader br)
    {
        Flags = br.Deserialize<BitArray>();
        Text = br.Deserialize<string>();
        if (Flags[0]) { FwdText = br.Deserialize<string>(); }
        Url = br.Deserialize<string>();
        ButtonId = br.ReadInt32();
    }
}
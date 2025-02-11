﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/webPageAttributeTheme" />
///</summary>
[TlObject(0x54b56617)]
public sealed class TWebPageAttributeTheme : IWebPageAttribute
{
    public uint ConstructorId => 0x54b56617;
    public BitArray Flags { get; set; } = new BitArray(32);
    public TVector<MyTelegram.Schema.IDocument>? Documents { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/ThemeSettings" />
    ///</summary>
    public MyTelegram.Schema.IThemeSettings? Settings { get; set; }

    public void ComputeFlag()
    {
        if (Documents?.Count > 0) { Flags[0] = true; }
        if (Settings != null) { Flags[1] = true; }
    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Serialize(Flags);
        if (Flags[0]) { Documents.Serialize(bw); }
        if (Flags[1]) { Settings.Serialize(bw); }
    }

    public void Deserialize(BinaryReader br)
    {
        Flags = br.Deserialize<BitArray>();
        if (Flags[0]) { Documents = br.Deserialize<TVector<MyTelegram.Schema.IDocument>>(); }
        if (Flags[1]) { Settings = br.Deserialize<MyTelegram.Schema.IThemeSettings>(); }
    }
}
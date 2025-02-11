﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/photo" />
///</summary>
[TlObject(0xfb197a65)]
public sealed class TPhoto : IPhoto
{
    public uint ConstructorId => 0xfb197a65;
    public BitArray Flags { get; set; } = new BitArray(32);
    public bool HasStickers { get; set; }
    public long Id { get; set; }
    public long AccessHash { get; set; }
    public byte[] FileReference { get; set; }
    public int Date { get; set; }
    public TVector<MyTelegram.Schema.IPhotoSize> Sizes { get; set; }
    public TVector<MyTelegram.Schema.IVideoSize>? VideoSizes { get; set; }
    public int DcId { get; set; }

    public void ComputeFlag()
    {
        if (HasStickers) { Flags[0] = true; }
        if (VideoSizes?.Count > 0) { Flags[1] = true; }

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Serialize(Flags);
        bw.Write(Id);
        bw.Write(AccessHash);
        bw.Serialize(FileReference);
        bw.Write(Date);
        Sizes.Serialize(bw);
        if (Flags[1]) { VideoSizes.Serialize(bw); }
        bw.Write(DcId);
    }

    public void Deserialize(BinaryReader br)
    {
        Flags = br.Deserialize<BitArray>();
        if (Flags[0]) { HasStickers = true; }
        Id = br.ReadInt64();
        AccessHash = br.ReadInt64();
        FileReference = br.Deserialize<byte[]>();
        Date = br.ReadInt32();
        Sizes = br.Deserialize<TVector<MyTelegram.Schema.IPhotoSize>>();
        if (Flags[1]) { VideoSizes = br.Deserialize<TVector<MyTelegram.Schema.IVideoSize>>(); }
        DcId = br.ReadInt32();
    }
}
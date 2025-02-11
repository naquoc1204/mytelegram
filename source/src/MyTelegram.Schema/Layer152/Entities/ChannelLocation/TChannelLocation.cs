﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/channelLocation" />
///</summary>
[TlObject(0x209b82db)]
public sealed class TChannelLocation : IChannelLocation
{
    public uint ConstructorId => 0x209b82db;

    ///<summary>
    ///See <a href="https://core.telegram.org/type/GeoPoint" />
    ///</summary>
    public MyTelegram.Schema.IGeoPoint GeoPoint { get; set; }
    public string Address { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        GeoPoint.Serialize(bw);
        bw.Serialize(Address);
    }

    public void Deserialize(BinaryReader br)
    {
        GeoPoint = br.Deserialize<MyTelegram.Schema.IGeoPoint>();
        Address = br.Deserialize<string>();
    }
}
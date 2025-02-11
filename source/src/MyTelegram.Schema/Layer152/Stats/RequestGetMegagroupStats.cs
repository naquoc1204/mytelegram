﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Stats;

///<summary>
///See <a href="https://core.telegram.org/method/stats.getMegagroupStats" />
///</summary>
[TlObject(0xdcdf8607)]
public sealed class RequestGetMegagroupStats : IRequest<MyTelegram.Schema.Stats.IMegagroupStats>
{
    public uint ConstructorId => 0xdcdf8607;
    public BitArray Flags { get; set; } = new BitArray(32);
    public bool Dark { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/InputChannel" />
    ///</summary>
    public MyTelegram.Schema.IInputChannel Channel { get; set; }

    public void ComputeFlag()
    {
        if (Dark) { Flags[0] = true; }

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Serialize(Flags);
        Channel.Serialize(bw);
    }

    public void Deserialize(BinaryReader br)
    {
        Flags = br.Deserialize<BitArray>();
        if (Flags[0]) { Dark = true; }
        Channel = br.Deserialize<MyTelegram.Schema.IInputChannel>();
    }
}

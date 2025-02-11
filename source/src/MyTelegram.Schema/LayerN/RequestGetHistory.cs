﻿// <auto-generated/>
// ReSharper disable All

using MyTelegram.Schema.Messages;

namespace MyTelegram.Schema.LayerN;

[TlObject(0xafa92846)]
public sealed class RequestGetHistory : IRequest<IMessages>
{
    public Schema.IInputPeer Peer { get; set; }
    public int OffsetId { get; set; }
    public int OffsetDate { get; set; }
    public int AddOffset { get; set; }
    public int Limit { get; set; }
    public int MaxId { get; set; }
    public int MinId { get; set; }
    public uint ConstructorId => 0xafa92846;

    public void Serialize(BinaryWriter bw)
    {
        bw.Write(ConstructorId);
        ComputeFlag();
        SerializerFactory.CreateObjectSerializer<Schema.IInputPeer>().Serialize(Peer, bw);
        bw.Write(OffsetId);
        bw.Write(OffsetDate);
        bw.Write(AddOffset);
        bw.Write(Limit);
        bw.Write(MaxId);
        bw.Write(MinId);
    }

    public void Deserialize(BinaryReader br)
    {
        Peer = SerializerFactory.CreateObjectSerializer<Schema.IInputPeer>().Deserialize(br);
        OffsetId = br.ReadInt32();
        OffsetDate = br.ReadInt32();
        AddOffset = br.ReadInt32();
        Limit = br.ReadInt32();
        MaxId = br.ReadInt32();
        MinId = br.ReadInt32();
    }

    public void ComputeFlag()
    {
    }
}

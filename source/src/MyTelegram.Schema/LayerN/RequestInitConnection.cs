﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.LayerN;

[TlObject(0x785188b8)]
public sealed class RequestInitConnection : IRequest<IObject>
{
    public BitArray Flags { get; set; } = new BitArray(32);
    public int ApiId { get; set; }
    public string DeviceModel { get; set; }
    public string SystemVersion { get; set; }
    public string AppVersion { get; set; }
    public string SystemLangCode { get; set; }
    public string LangPack { get; set; }
    public string LangCode { get; set; }
    public Schema.IInputClientProxy Proxy { get; set; }
    public Schema.IJSONValue Params { get; set; }
    public IObject Query { get; set; }
    public uint ConstructorId => 0x785188b8;

    public void Serialize(BinaryWriter bw)
    {
        bw.Write(ConstructorId);
        ComputeFlag();
        SerializerFactory.CreateSerializer<BitArray>().Serialize(Flags, bw);
        bw.Write(ApiId);
        SerializerFactory.CreateSerializer<string>().Serialize(DeviceModel, bw);
        SerializerFactory.CreateSerializer<string>().Serialize(SystemVersion, bw);
        SerializerFactory.CreateSerializer<string>().Serialize(AppVersion, bw);
        SerializerFactory.CreateSerializer<string>().Serialize(SystemLangCode, bw);
        SerializerFactory.CreateSerializer<string>().Serialize(LangPack, bw);
        SerializerFactory.CreateSerializer<string>().Serialize(LangCode, bw);
        if (Flags[0]) { SerializerFactory.CreateObjectSerializer<Schema.IInputClientProxy>().Serialize(Proxy, bw); }

        if (Flags[1]) { SerializerFactory.CreateObjectSerializer<Schema.IJSONValue>().Serialize(Params, bw); }

        SerializerFactory.CreateObjectSerializer<IObject>().Serialize(Query, bw);
    }

    public void Deserialize(BinaryReader br)
    {
        Flags = SerializerFactory.CreateSerializer<BitArray>().Deserialize(br);
        ApiId = br.ReadInt32();
        DeviceModel = SerializerFactory.CreateSerializer<string>().Deserialize(br);
        SystemVersion = SerializerFactory.CreateSerializer<string>().Deserialize(br);
        AppVersion = SerializerFactory.CreateSerializer<string>().Deserialize(br);
        SystemLangCode = SerializerFactory.CreateSerializer<string>().Deserialize(br);
        LangPack = SerializerFactory.CreateSerializer<string>().Deserialize(br);
        LangCode = SerializerFactory.CreateSerializer<string>().Deserialize(br);
        if (Flags[0]) { Proxy = SerializerFactory.CreateObjectSerializer<Schema.IInputClientProxy>().Deserialize(br); }

        if (Flags[1]) { Params = SerializerFactory.CreateObjectSerializer<Schema.IJSONValue>().Deserialize(br); }

        Query = SerializerFactory.CreateObjectSerializer<IObject>().Deserialize(br);
    }

    public void ComputeFlag()
    {
        if (Proxy != null) { Flags[0] = true; }

        if (Params != null) { Flags[1] = true; }
    }
}

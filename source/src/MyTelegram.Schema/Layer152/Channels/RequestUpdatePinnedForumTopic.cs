﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Channels;

///<summary>
///See <a href="https://core.telegram.org/method/channels.updatePinnedForumTopic" />
///</summary>
[TlObject(0x6c2d9026)]
public sealed class RequestUpdatePinnedForumTopic : IRequest<MyTelegram.Schema.IUpdates>
{
    public uint ConstructorId => 0x6c2d9026;

    ///<summary>
    ///See <a href="https://core.telegram.org/type/InputChannel" />
    ///</summary>
    public MyTelegram.Schema.IInputChannel Channel { get; set; }
    public int TopicId { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/Bool" />
    ///</summary>
    public bool Pinned { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        Channel.Serialize(bw);
        bw.Write(TopicId);
        bw.Serialize(Pinned);
    }

    public void Deserialize(BinaryReader br)
    {
        Channel = br.Deserialize<MyTelegram.Schema.IInputChannel>();
        TopicId = br.ReadInt32();
        Pinned = br.Deserialize<bool>();
    }
}

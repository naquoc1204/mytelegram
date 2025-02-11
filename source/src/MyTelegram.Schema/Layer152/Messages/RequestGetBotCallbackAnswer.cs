﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Messages;

///<summary>
///See <a href="https://core.telegram.org/method/messages.getBotCallbackAnswer" />
///</summary>
[TlObject(0x9342ca07)]
public sealed class RequestGetBotCallbackAnswer : IRequest<MyTelegram.Schema.Messages.IBotCallbackAnswer>
{
    public uint ConstructorId => 0x9342ca07;
    public BitArray Flags { get; set; } = new BitArray(32);
    public bool Game { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/InputPeer" />
    ///</summary>
    public MyTelegram.Schema.IInputPeer Peer { get; set; }
    public int MsgId { get; set; }
    public byte[]? Data { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/InputCheckPasswordSRP" />
    ///</summary>
    public MyTelegram.Schema.IInputCheckPasswordSRP? Password { get; set; }

    public void ComputeFlag()
    {
        if (Game) { Flags[1] = true; }
        if (Data != null) { Flags[0] = true; }
        if (Password != null) { Flags[2] = true; }
    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Serialize(Flags);
        Peer.Serialize(bw);
        bw.Write(MsgId);
        if (Flags[0]) { bw.Serialize(Data); }
        if (Flags[2]) { Password.Serialize(bw); }
    }

    public void Deserialize(BinaryReader br)
    {
        Flags = br.Deserialize<BitArray>();
        if (Flags[1]) { Game = true; }
        Peer = br.Deserialize<MyTelegram.Schema.IInputPeer>();
        MsgId = br.ReadInt32();
        if (Flags[0]) { Data = br.Deserialize<byte[]>(); }
        if (Flags[2]) { Password = br.Deserialize<MyTelegram.Schema.IInputCheckPasswordSRP>(); }
    }
}

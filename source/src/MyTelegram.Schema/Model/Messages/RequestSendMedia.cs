﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Messages;

///<summary>
///See <a href="https://core.telegram.org/method/messages.sendMedia" />
///</summary>
[TlObject(0xe25ff8e0)]
public sealed class RequestSendMedia : IRequest<MyTelegram.Schema.IUpdates>
{
    public uint ConstructorId => 0xe25ff8e0;
    public BitArray Flags { get; set; } = new BitArray(32);
    public bool Silent { get; set; }
    public bool Background { get; set; }
    public bool ClearDraft { get; set; }
    public bool Noforwards { get; set; }
    public bool UpdateStickersetsOrder { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/InputPeer" />
    ///</summary>
    public MyTelegram.Schema.IInputPeer Peer { get; set; }
    public int? ReplyToMsgId { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/InputMedia" />
    ///</summary>
    public MyTelegram.Schema.IInputMedia Media { get; set; }
    public string Message { get; set; }
    public long RandomId { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/ReplyMarkup" />
    ///</summary>
    public MyTelegram.Schema.IReplyMarkup? ReplyMarkup { get; set; }
    public TVector<MyTelegram.Schema.IMessageEntity>? Entities { get; set; }
    public int? ScheduleDate { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/InputPeer" />
    ///</summary>
    public MyTelegram.Schema.IInputPeer? SendAs { get; set; }

    public void ComputeFlag()
    {
        if (Silent) { Flags[5] = true; }
        if (Background) { Flags[6] = true; }
        if (ClearDraft) { Flags[7] = true; }
        if (Noforwards) { Flags[14] = true; }
        if (UpdateStickersetsOrder) { Flags[15] = true; }
        if (ReplyToMsgId != 0 && ReplyToMsgId.HasValue) { Flags[0] = true; }
        if (ReplyMarkup != null) { Flags[2] = true; }
        if (Entities?.Count > 0) { Flags[3] = true; }
        if (ScheduleDate != 0 && ScheduleDate.HasValue) { Flags[10] = true; }
        if (SendAs != null) { Flags[13] = true; }
    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Serialize(Flags);
        Peer.Serialize(bw);
        if (Flags[0]) { bw.Write(ReplyToMsgId.Value); }
        Media.Serialize(bw);
        bw.Serialize(Message);
        bw.Write(RandomId);
        if (Flags[2]) { ReplyMarkup.Serialize(bw); }
        if (Flags[3]) { Entities.Serialize(bw); }
        if (Flags[10]) { bw.Write(ScheduleDate.Value); }
        if (Flags[13]) { SendAs.Serialize(bw); }
    }

    public void Deserialize(BinaryReader br)
    {
        Flags = br.Deserialize<BitArray>();
        if (Flags[5]) { Silent = true; }
        if (Flags[6]) { Background = true; }
        if (Flags[7]) { ClearDraft = true; }
        if (Flags[14]) { Noforwards = true; }
        if (Flags[15]) { UpdateStickersetsOrder = true; }
        Peer = br.Deserialize<MyTelegram.Schema.IInputPeer>();
        if (Flags[0]) { ReplyToMsgId = br.ReadInt32(); }
        Media = br.Deserialize<MyTelegram.Schema.IInputMedia>();
        Message = br.Deserialize<string>();
        RandomId = br.ReadInt64();
        if (Flags[2]) { ReplyMarkup = br.Deserialize<MyTelegram.Schema.IReplyMarkup>(); }
        if (Flags[3]) { Entities = br.Deserialize<TVector<MyTelegram.Schema.IMessageEntity>>(); }
        if (Flags[10]) { ScheduleDate = br.ReadInt32(); }
        if (Flags[13]) { SendAs = br.Deserialize<MyTelegram.Schema.IInputPeer>(); }
    }
}

﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/userFull" />
///</summary>
[TlObject(0xf8d32aed)]
public sealed class TUserFull : IUserFull
{
    public uint ConstructorId => 0xf8d32aed;
    public BitArray Flags { get; set; } = new BitArray(32);
    public bool Blocked { get; set; }
    public bool PhoneCallsAvailable { get; set; }
    public bool PhoneCallsPrivate { get; set; }
    public bool CanPinMessage { get; set; }
    public bool HasScheduled { get; set; }
    public bool VideoCallsAvailable { get; set; }
    public bool VoiceMessagesForbidden { get; set; }
    public bool TranslationsDisabled { get; set; }
    public long Id { get; set; }
    public string? About { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/PeerSettings" />
    ///</summary>
    public MyTelegram.Schema.IPeerSettings Settings { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/Photo" />
    ///</summary>
    public MyTelegram.Schema.IPhoto? PersonalPhoto { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/Photo" />
    ///</summary>
    public MyTelegram.Schema.IPhoto? ProfilePhoto { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/Photo" />
    ///</summary>
    public MyTelegram.Schema.IPhoto? FallbackPhoto { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/PeerNotifySettings" />
    ///</summary>
    public MyTelegram.Schema.IPeerNotifySettings NotifySettings { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/BotInfo" />
    ///</summary>
    public MyTelegram.Schema.IBotInfo? BotInfo { get; set; }
    public int? PinnedMsgId { get; set; }
    public int CommonChatsCount { get; set; }
    public int? FolderId { get; set; }
    public int? TtlPeriod { get; set; }
    public string? ThemeEmoticon { get; set; }
    public string? PrivateForwardName { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/ChatAdminRights" />
    ///</summary>
    public MyTelegram.Schema.IChatAdminRights? BotGroupAdminRights { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/ChatAdminRights" />
    ///</summary>
    public MyTelegram.Schema.IChatAdminRights? BotBroadcastAdminRights { get; set; }
    public TVector<MyTelegram.Schema.IPremiumGiftOption>? PremiumGifts { get; set; }

    public void ComputeFlag()
    {
        if (Blocked) { Flags[0] = true; }
        if (PhoneCallsAvailable) { Flags[4] = true; }
        if (PhoneCallsPrivate) { Flags[5] = true; }
        if (CanPinMessage) { Flags[7] = true; }
        if (HasScheduled) { Flags[12] = true; }
        if (VideoCallsAvailable) { Flags[13] = true; }
        if (VoiceMessagesForbidden) { Flags[20] = true; }
        if (TranslationsDisabled) { Flags[23] = true; }
        if (About != null) { Flags[1] = true; }
        if (PersonalPhoto != null) { Flags[21] = true; }
        if (ProfilePhoto != null) { Flags[2] = true; }
        if (FallbackPhoto != null) { Flags[22] = true; }
        if (BotInfo != null) { Flags[3] = true; }
        if (PinnedMsgId != 0 && PinnedMsgId.HasValue) { Flags[6] = true; }
        if (FolderId != 0 && FolderId.HasValue) { Flags[11] = true; }
        if (TtlPeriod != 0 && TtlPeriod.HasValue) { Flags[14] = true; }
        if (ThemeEmoticon != null) { Flags[15] = true; }
        if (PrivateForwardName != null) { Flags[16] = true; }
        if (BotGroupAdminRights != null) { Flags[17] = true; }
        if (BotBroadcastAdminRights != null) { Flags[18] = true; }
        if (PremiumGifts?.Count > 0) { Flags[19] = true; }
    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Serialize(Flags);
        bw.Write(Id);
        if (Flags[1]) { bw.Serialize(About); }
        Settings.Serialize(bw);
        if (Flags[21]) { PersonalPhoto.Serialize(bw); }
        if (Flags[2]) { ProfilePhoto.Serialize(bw); }
        if (Flags[22]) { FallbackPhoto.Serialize(bw); }
        NotifySettings.Serialize(bw);
        if (Flags[3]) { BotInfo.Serialize(bw); }
        if (Flags[6]) { bw.Write(PinnedMsgId.Value); }
        bw.Write(CommonChatsCount);
        if (Flags[11]) { bw.Write(FolderId.Value); }
        if (Flags[14]) { bw.Write(TtlPeriod.Value); }
        if (Flags[15]) { bw.Serialize(ThemeEmoticon); }
        if (Flags[16]) { bw.Serialize(PrivateForwardName); }
        if (Flags[17]) { BotGroupAdminRights.Serialize(bw); }
        if (Flags[18]) { BotBroadcastAdminRights.Serialize(bw); }
        if (Flags[19]) { PremiumGifts.Serialize(bw); }
    }

    public void Deserialize(BinaryReader br)
    {
        Flags = br.Deserialize<BitArray>();
        if (Flags[0]) { Blocked = true; }
        if (Flags[4]) { PhoneCallsAvailable = true; }
        if (Flags[5]) { PhoneCallsPrivate = true; }
        if (Flags[7]) { CanPinMessage = true; }
        if (Flags[12]) { HasScheduled = true; }
        if (Flags[13]) { VideoCallsAvailable = true; }
        if (Flags[20]) { VoiceMessagesForbidden = true; }
        if (Flags[23]) { TranslationsDisabled = true; }
        Id = br.ReadInt64();
        if (Flags[1]) { About = br.Deserialize<string>(); }
        Settings = br.Deserialize<MyTelegram.Schema.IPeerSettings>();
        if (Flags[21]) { PersonalPhoto = br.Deserialize<MyTelegram.Schema.IPhoto>(); }
        if (Flags[2]) { ProfilePhoto = br.Deserialize<MyTelegram.Schema.IPhoto>(); }
        if (Flags[22]) { FallbackPhoto = br.Deserialize<MyTelegram.Schema.IPhoto>(); }
        NotifySettings = br.Deserialize<MyTelegram.Schema.IPeerNotifySettings>();
        if (Flags[3]) { BotInfo = br.Deserialize<MyTelegram.Schema.IBotInfo>(); }
        if (Flags[6]) { PinnedMsgId = br.ReadInt32(); }
        CommonChatsCount = br.ReadInt32();
        if (Flags[11]) { FolderId = br.ReadInt32(); }
        if (Flags[14]) { TtlPeriod = br.ReadInt32(); }
        if (Flags[15]) { ThemeEmoticon = br.Deserialize<string>(); }
        if (Flags[16]) { PrivateForwardName = br.Deserialize<string>(); }
        if (Flags[17]) { BotGroupAdminRights = br.Deserialize<MyTelegram.Schema.IChatAdminRights>(); }
        if (Flags[18]) { BotBroadcastAdminRights = br.Deserialize<MyTelegram.Schema.IChatAdminRights>(); }
        if (Flags[19]) { PremiumGifts = br.Deserialize<TVector<MyTelegram.Schema.IPremiumGiftOption>>(); }
    }
}
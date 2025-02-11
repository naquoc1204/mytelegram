﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Help;


///<summary>
///See <a href="https://core.telegram.org/constructor/help.premiumPromo" />
///</summary>
[TlObject(0x5334759c)]
public sealed class TPremiumPromo : IPremiumPromo
{
    public uint ConstructorId => 0x5334759c;
    public string StatusText { get; set; }
    public TVector<MyTelegram.Schema.IMessageEntity> StatusEntities { get; set; }
    public TVector<string> VideoSections { get; set; }
    public TVector<MyTelegram.Schema.IDocument> Videos { get; set; }
    public TVector<MyTelegram.Schema.IPremiumSubscriptionOption> PeriodOptions { get; set; }
    public TVector<MyTelegram.Schema.IUser> Users { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Serialize(StatusText);
        StatusEntities.Serialize(bw);
        VideoSections.Serialize(bw);
        Videos.Serialize(bw);
        PeriodOptions.Serialize(bw);
        Users.Serialize(bw);
    }

    public void Deserialize(BinaryReader br)
    {
        StatusText = br.Deserialize<string>();
        StatusEntities = br.Deserialize<TVector<MyTelegram.Schema.IMessageEntity>>();
        VideoSections = br.Deserialize<TVector<string>>();
        Videos = br.Deserialize<TVector<MyTelegram.Schema.IDocument>>();
        PeriodOptions = br.Deserialize<TVector<MyTelegram.Schema.IPremiumSubscriptionOption>>();
        Users = br.Deserialize<TVector<MyTelegram.Schema.IUser>>();
    }
}
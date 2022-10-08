﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/premiumSubscriptionOption" />
///</summary>
[TlObject(0xb6f11ebe)]
public class TPremiumSubscriptionOption : IPremiumSubscriptionOption
{
    public uint ConstructorId => 0xb6f11ebe;
    public BitArray Flags { get; set; } = new BitArray(32);
    public bool Current { get; set; }
    public bool CanPurchaseUpgrade { get; set; }
    public int Months { get; set; }
    public string Currency { get; set; }
    public long Amount { get; set; }
    public string BotUrl { get; set; }
    public string? StoreProduct { get; set; }

    public void ComputeFlag()
    {
        if (Current) { Flags[1] = true; }
        if (CanPurchaseUpgrade) { Flags[2] = true; }
        if (StoreProduct != null) { Flags[0] = true; }
    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Serialize(Flags);
        bw.Write(Months);
        bw.Serialize(Currency);
        bw.Write(Amount);
        bw.Serialize(BotUrl);
        if (Flags[0]) { bw.Serialize(StoreProduct); }
    }

    public void Deserialize(BinaryReader br)
    {
        Flags = br.Deserialize<BitArray>();
        if (Flags[1]) { Current = true; }
        if (Flags[2]) { CanPurchaseUpgrade = true; }
        Months = br.ReadInt32();
        Currency = br.Deserialize<string>();
        Amount = br.ReadInt64();
        BotUrl = br.Deserialize<string>();
        if (Flags[0]) { StoreProduct = br.Deserialize<string>(); }
    }
}
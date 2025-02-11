﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/secureValueErrorFiles" />
///</summary>
[TlObject(0x666220e9)]
public sealed class TSecureValueErrorFiles : ISecureValueError
{
    public uint ConstructorId => 0x666220e9;

    ///<summary>
    ///See <a href="https://core.telegram.org/type/SecureValueType" />
    ///</summary>
    public MyTelegram.Schema.ISecureValueType Type { get; set; }
    public TVector<byte[]> FileHash { get; set; }
    public string Text { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        Type.Serialize(bw);
        FileHash.Serialize(bw);
        bw.Serialize(Text);
    }

    public void Deserialize(BinaryReader br)
    {
        Type = br.Deserialize<MyTelegram.Schema.ISecureValueType>();
        FileHash = br.Deserialize<TVector<byte[]>>();
        Text = br.Deserialize<string>();
    }
}
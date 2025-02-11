﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Folders;

///<summary>
///See <a href="https://core.telegram.org/method/folders.deleteFolder" />
///</summary>
[TlObject(0x1c295881)]
public sealed class RequestDeleteFolder : IRequest<MyTelegram.Schema.IUpdates>
{
    public uint ConstructorId => 0x1c295881;
    public int FolderId { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Write(FolderId);
    }

    public void Deserialize(BinaryReader br)
    {
        FolderId = br.ReadInt32();
    }
}

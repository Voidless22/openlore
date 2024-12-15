using System;
using Godot;
using OpenLore.network_manager.network_session;
using OpenLore.network_manager.packets;

namespace OpenLore.network_manager.world_server;

public class SCLogServer(PacketReader reader) : AppPacket(reader)
{
    public override void Write()
    {
        throw new NotImplementedException();
    }

    public override void Read()
    {
        GD.Print($"SCLogServer {Reader.ReadBytes(Reader.Remaining()).HexEncode()}");
    }
}
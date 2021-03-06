using Protocol.IO;


using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class ShortcutBarAddRequestMessage : NetworkMessage
	{
		public const uint Id = 6225;

		public sbyte barType;

		public Shortcut shortcut;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6225;
			}
		}

		public ShortcutBarAddRequestMessage()
		{
		}

		public ShortcutBarAddRequestMessage(sbyte barType, Shortcut shortcut)
		{
			this.barType = barType;
			this.shortcut = shortcut;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.barType = reader.ReadSByte();
			this.shortcut = ProtocolTypeManager.GetInstance<Shortcut>(reader.ReadUShort());
			this.shortcut.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(this.barType);
			writer.WriteShort(this.shortcut.TypeId);
			this.shortcut.Serialize(writer);
		}
	}
}
using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class GameEntityDispositionErrorMessage : NetworkMessage
	{
		public const uint Id = 5695;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5695;
			}
		}

		public GameEntityDispositionErrorMessage()
		{
		}

		public override void Deserialize(IDataReader reader)
		{
		}

		public override void Serialize(IDataWriter writer)
		{
		}
	}
}
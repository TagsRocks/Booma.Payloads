﻿using Booma.Payloads.Common;
using Booma.Payloads.Surrogates.Unity;
using GladNet.Payload;
using GladNet.Serializer;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Booma.Payloads.Instance
{
	/// <summary>
	/// Payload sent by players who want to move in a direction.
	/// </summary>
	[GladNetSerializationContract]
	[BoomaPayload(BoomaPayloadMessageType.PlayerMoveRequest)]
	public class PlayerMoveRequestPayload : PacketPayload
	{
		/// <summary>
		/// Represents the direction the player wants to move in (may be non-normalized).
		/// </summary>
		[GladNetMember(GladNetDataIndex.Index1)]
		public Vector3Surrogate Direction { get; private set; }

		/// <summary>
		/// Represents the position that the requestee thinks it is in. It may have mispredicted this position so it could be wrong.
		/// </summary>
		[GladNetMember(GladNetDataIndex.Index2)]
		public Vector3Surrogate CurrentPosition { get; private set; }

		/// <summary>
		/// Creates a new <see cref="BoomaPayloadMessageType.PlayerMoveRequestPayload"/> payload.
		/// </summary>
		public PlayerMoveRequestPayload(Vector3Surrogate direction, Vector3Surrogate currentPosition)
		{
			//TODO: Check refs

			//Do not normalize on client. No point. Server will need to renormalize anyway
			//Malicious clients could send non-normalized directions
			Direction = direction;
			CurrentPosition = currentPosition;
		}

		/// <summary>
		/// Protected serializer ctor
		/// </summary>
		protected PlayerMoveRequestPayload()
		{

		}
	}
}
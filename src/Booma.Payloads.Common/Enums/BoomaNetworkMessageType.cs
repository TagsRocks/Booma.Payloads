﻿using GladNet.Serializer;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Booma.Payloads.Common
{
	/// <summary>
	/// Enumeration of valid Booma message types.
	/// </summary>
	public enum BoomaPayloadMessageType : int
	{
		//We have to make sure we don't overlap with GladLive
		/// <summary>
		/// A request to get the list of available gameservers/ships
		/// </summary>
		GetGameServerListRequest = GladNetIncludeIndex.Index19,
		
		/// <summary>
		/// A response containing the list of available gameservers/ships
		/// </summary>
		GetGameServerListResponse = GladNetIncludeIndex.Index20
	}
}
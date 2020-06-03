using System;
using System.Collections.Generic;
using SimpleGameExampleInterfaces.Shared.WinDefinitions.Definitions;

namespace SimpleGameExampleInterfaces.Shared.WinDefinitions.GameSpecific
{
	/// <summary>
	/// 	replacement for static winline definition, sent to client only during init
	/// </summary>
	public class WinDefinition : ILineWinDefinition
	{
		public WinDefinition(List<Int32> linePositions)
		{
			LinePositions = linePositions;
		}

		public List<Int32> LinePositions { get; }
	}
}
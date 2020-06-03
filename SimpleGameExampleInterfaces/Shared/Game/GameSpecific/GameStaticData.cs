using System.Collections.Generic;
using SimpleGameExampleInterfaces.Shared.SymbolDefinitions;
using SimpleGameExampleInterfaces.Shared.WinDefinitions.GameSpecific;

namespace SimpleGameExampleInterfaces.Shared.GameRound.GameSpecific
{
	public class GameStaticData
	{
		public List<SymbolDefinition> SymbolDefinitions { get; }
		public List<WinDefinition> WinlineDefinitions { get; }
		
		public GameStaticData(List<SymbolDefinition> symbolDefinitions, List<WinDefinition> winlineDefinitions)
		{
			SymbolDefinitions = symbolDefinitions;
			WinlineDefinitions = winlineDefinitions;
		}
	}
}
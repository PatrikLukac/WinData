using System;
using SimpleGameExampleInterfaces.Shared.WinDefinitions.GameSpecific;

namespace SimpleGameExampleInterfaces.Shared.GameRound.GameSpecific
{
	public class GameRoundData
	{
		public Decimal Stake { get; }
		
		public Int32 Mode { get; }
		
		public VisibleSymbols VisibleSymbols { get; }
		
		public WinData WinData { get; }
		
		
		public GameRoundData(Decimal stake, Int32 mode, VisibleSymbols visibleSymbols, WinData winData)
		{
			Stake = stake;
			Mode = mode;
			VisibleSymbols = visibleSymbols;
			WinData = winData;
		}

	}
}
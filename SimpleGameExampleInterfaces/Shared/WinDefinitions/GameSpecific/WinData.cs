using System;
using System.Collections.Generic;

namespace SimpleGameExampleInterfaces.Shared.WinDefinitions.GameSpecific
{
	public class WinData
	{
		public IReadOnlyList<Win> Wins { get; }
		
		public Decimal TotalWin { get; }
		
		
		public WinData(IReadOnlyList<Win> wins)
		{
			Wins = wins;
			foreach (Win win in wins)
			{
				TotalWin += win.WinAmount;
			}
		}
	}
}
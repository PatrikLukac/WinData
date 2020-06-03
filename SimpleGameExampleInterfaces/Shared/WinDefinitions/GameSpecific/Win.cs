using System;
using System.Collections.Generic;
using SimpleGameExampleInterfaces.Shared.SymbolDefinitions;

namespace SimpleGameExampleInterfaces.Shared.WinDefinitions.GameSpecific
{
	public class Win : ISymbolsWin, IFreespinWin
	{
		/// <inheritdoc />
		public Decimal WinAmount { get; }

		/// <inheritdoc />
		public Symbol WinningSymbol { get; }

		/// <inheritdoc />
		public Int32 WinlineID { get; }

		/// <inheritdoc />
		public Int32 WinningSymbolsCount { get; }

		/// <inheritdoc />
		public List<Vector2> WinningSymbolPositions { get; }

		/// <inheritdoc />
		public Int32 FreespinsWon { get; }
		
		
		
		public Win(Decimal winAmount, Symbol winningSymbol, Int32 winlineID, Int32 winningSymbolsCount, List<Vector2> winningSymbolPositions, Int32 freespinsWon)
		{
			WinAmount = winAmount;
			WinningSymbol = winningSymbol;
			WinlineID = winlineID;
			WinningSymbolsCount = winningSymbolsCount;
			WinningSymbolPositions = winningSymbolPositions;
			FreespinsWon = freespinsWon;
		}
	}
}
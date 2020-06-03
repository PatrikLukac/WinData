// // --------------------------------
// // -- File Created 	: 19:51 03/06/2020
// // -- File Part of the WinData Solution, project SimpleGameExampleInterfaces
// // -- Edited By : 
// // --------------------------------

using System;
using System.Collections.Generic;
using SimpleGameExampleInterfaces.Shared.SymbolDefinitions;
using SimpleGameExampleInterfaces.Shared.WinDefinitions.GameSpecific;

namespace SimpleGameExampleInterfaces.Shared.WinDefinitions
{
	public interface ISymbolsWin : IPayingWin
	{
		Symbol WinningSymbol { get; }
		
		Int32 WinlineID { get; }
		
		Int32 WinningSymbolsCount { get; }
		
		List<Vector2> WinningSymbolPositions { get; }
	}
}
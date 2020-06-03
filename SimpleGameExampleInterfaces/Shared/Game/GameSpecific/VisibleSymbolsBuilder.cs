using System;
using System.Collections.Generic;
using SimpleGameExampleInterfaces.Shared.SymbolDefinitions;

namespace SimpleGameExampleInterfaces.Shared.GameRound.GameSpecific
{
	public class VisibleSymbolsBuilder
	{
		private List<ReelSymbolSequence> _Reels;

		private Int32 _ReelsetId;

		public VisibleSymbolsBuilder ReelsetId(int id)
		{
			_ReelsetId = id;
			return this;
		}
		
		public VisibleSymbolsBuilder Reel(int reelID, string symbolIds)
		{
			
			List<Symbol> symbols = new List<Symbol>();
			foreach (char c in symbolIds.ToCharArray())
			{
				symbols.Add(new Symbol(c));
			}
			
			if (_Reels == null) _Reels = new List<ReelSymbolSequence>();
			_Reels.Add(new ReelSymbolSequence(reelID, symbols));
			
			return this;
		}
		
		
		public VisibleSymbols Build()
		{
			return new VisibleSymbols(_ReelsetId, _Reels);
		} 
	}
}
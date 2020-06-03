using System;
using System.Collections.Generic;

namespace SimpleGameExampleInterfaces.Shared.GameRound.GameSpecific
{
	public class VisibleSymbols
	{
		/// <summary>The id of the reel strip set.</summary>
		public int ReelStripSetId { get; }

		/// <summary>The id of this set.</summary>
		public IReadOnlyList<ReelSymbolSequence> ReelSymbolSequences { get; }
		
		
		
		public VisibleSymbols(Int32 reelStripSetId, IReadOnlyList<ReelSymbolSequence> reelSymbolSequences)
		{
			ReelStripSetId = reelStripSetId;
			ReelSymbolSequences = reelSymbolSequences;
		}
	}
}
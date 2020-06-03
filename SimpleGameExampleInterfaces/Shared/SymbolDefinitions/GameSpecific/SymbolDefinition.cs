using System.Collections.Generic;

namespace SimpleGameExampleInterfaces.Shared.SymbolDefinitions
{
	/// <summary>
	/// 	replacement for symbol static definition, sent to client only during init
	/// </summary>
	public class SymbolDefinition : ISymbolPaytableDefinition
	{
		public SymbolDefinition(Symbol symbol, List<SymbolPaytableEntry> symbolPaytable)
		{
			Symbol = symbol;
			SymbolPaytable = symbolPaytable;
		}

		public Symbol Symbol { get; }

		/// <inheritdoc />
		public List<SymbolPaytableEntry> SymbolPaytable { get; }
	}
}
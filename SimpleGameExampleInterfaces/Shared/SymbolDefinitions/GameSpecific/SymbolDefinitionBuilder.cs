using System;
using System.Collections.Generic;

namespace SimpleGameExampleInterfaces.Shared.SymbolDefinitions
{
	public class SymbolDefinitionBuilder
	{
		private Symbol _Symbol;
		private List<SymbolPaytableEntry> _SymbolPaytable;

		public SymbolDefinitionBuilder Symbol(char symbolId)
		{
			_Symbol = new Symbol(symbolId);
			return this;
		}
		
		public SymbolDefinitionBuilder PaytableEntry(int count, int payPerLine)
		{
			if (_SymbolPaytable == null) _SymbolPaytable = new List<SymbolPaytableEntry>();
			_SymbolPaytable.Add(new SymbolPaytableEntry(count,payPerLine));
			return this;
		}
		
		public SymbolDefinition Build()
		{
			return new SymbolDefinition(_Symbol, _SymbolPaytable);
		}
	}
}
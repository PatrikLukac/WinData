using System;
using System.Collections.Generic;
using SimpleGameExampleInterfaces.Shared.SymbolDefinitions;

namespace SimpleGameExampleInterfaces.Client
{
	public class ClientSymbol
	{
		public static Dictionary<Symbol, ClientSymbol> SYMBOL_DATA = new Dictionary<Symbol, ClientSymbol>();
		
		
		public List<SymbolPaytableEntry> SymbolPaytable;
		public Char SymbolID;
		public string Texture { get; }
		
		public ClientSymbol(SymbolDefinition serverDefinition)
		{
			SymbolID = serverDefinition.Symbol.ID;
			SymbolPaytable = serverDefinition.SymbolPaytable;
			Texture = ResolveTexture(serverDefinition.Symbol);
			SYMBOL_DATA.Add(serverDefinition.Symbol, this);
		}

		private static string ResolveTexture(Symbol symbol)
		{
			switch (symbol.ID)
			{
				case 'A' :
					return null;
					break;
			}
			return null;
		}
	}
}
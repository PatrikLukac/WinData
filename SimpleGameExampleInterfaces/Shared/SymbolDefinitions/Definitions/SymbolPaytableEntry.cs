using System;

namespace SimpleGameExampleInterfaces.Shared.SymbolDefinitions
{
	//dictionary could be of course used for this base functionality
	public class SymbolPaytableEntry
	{
		public Int32 Count { get; }
		
		public Int32 PayPerLine { get; }
		
		
		
		public SymbolPaytableEntry(Int32 count, Int32 payPerLine)
		{
			Count = count;
			PayPerLine = payPerLine;
		}
	}
}
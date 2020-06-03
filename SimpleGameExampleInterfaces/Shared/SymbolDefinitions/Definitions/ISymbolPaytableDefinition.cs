// // --------------------------------
// // -- File Created 	: 19:36 03/06/2020
// // -- File Part of the WinData Solution, project SimpleGameExampleInterfaces
// // -- Edited By : 
// // --------------------------------

using System.Collections.Generic;

namespace SimpleGameExampleInterfaces.Shared.SymbolDefinitions
{
	public interface ISymbolPaytableDefinition
	{
		List<SymbolPaytableEntry> SymbolPaytable { get; }
	}
}
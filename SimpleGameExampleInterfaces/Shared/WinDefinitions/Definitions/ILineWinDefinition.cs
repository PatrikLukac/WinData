// // --------------------------------
// // -- File Created 	: 20:03 03/06/2020
// // -- File Part of the WinData Solution, project SimpleGameExampleInterfaces
// // -- Edited By : 
// // --------------------------------

using System;
using System.Collections.Generic;

namespace SimpleGameExampleInterfaces.Shared.WinDefinitions.Definitions
{
	public interface ILineWinDefinition
	{
		///element itself = y coordinate, index in list = x coordinate
		List<Int32> LinePositions { get; }
	}
}
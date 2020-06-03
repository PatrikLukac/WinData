using System;

namespace SimpleGameExampleInterfaces.Shared.WinDefinitions
{
	public class Vector2
	{
		private Int32 X { get; }
		private Int32 Y { get; }
		
		
		public Vector2(Int32 x, Int32 y)
		{
			X = x;
			Y = y;
		}
	}
}
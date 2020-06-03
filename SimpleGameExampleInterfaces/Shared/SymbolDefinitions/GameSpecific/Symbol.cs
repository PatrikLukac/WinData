using System;

namespace SimpleGameExampleInterfaces.Shared.SymbolDefinitions
{
	public class Symbol : ICharSymbol
	{
		public Symbol(Char id)
		{
			ID = id;
		}

		/// <inheritdoc />
		public Char ID { get; }
	}
}
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using SimpleGameExampleInterfaces.Shared.GameRound.GameSpecific;
using SimpleGameExampleInterfaces.Shared.SymbolDefinitions;
using SimpleGameExampleInterfaces.Shared.WinDefinitions;
using SimpleGameExampleInterfaces.Shared.WinDefinitions.GameSpecific;

namespace SimpleGameExampleInterfaces
{
	public class Program
	{
		public static void Main()
		{
			StaticDataTest();
			GameRoundTest();
		}

		private static void StaticDataTest()
		{
			GameStaticData gameStaticData = new GameStaticData(
				new List<SymbolDefinition>
				{
					new SymbolDefinitionBuilder().Symbol('A').PaytableEntry(3, 1).PaytableEntry(4, 2).PaytableEntry(5, 5).Build(),
					new SymbolDefinitionBuilder().Symbol('B').PaytableEntry(3, 1).PaytableEntry(4, 2).PaytableEntry(5, 5).Build(),
					new SymbolDefinitionBuilder().Symbol('C').PaytableEntry(3, 1).PaytableEntry(4, 2).PaytableEntry(5, 5).Build(),
					new SymbolDefinitionBuilder().Symbol('D').PaytableEntry(3, 1).PaytableEntry(4, 2).PaytableEntry(5, 5).Build(),
				},
				new List<WinDefinition>
				{
					new WinDefinition(new List<Int32> {0, 0, 0, 0, 0}),
					new WinDefinition(new List<Int32> {1, 1, 1, 1, 1}),
					new WinDefinition(new List<Int32> {2, 2, 2, 2, 2}),
					new WinDefinition(new List<Int32> {0, 1, 2, 1, 0}),
					new WinDefinition(new List<Int32> {2, 1, 0, 1, 2})
				}
			);

			//try to serialize
			string serializedStaticData = JsonConvert.SerializeObject(gameStaticData);

			//try to deserialize
			GameStaticData deserializedStaticData = JsonConvert.DeserializeObject<GameStaticData>(serializedStaticData);

			//simulate construction on client
		}

		private static void GameRoundTest()
		{
			GameRoundData gameRoundData = new GameRoundData(1, 0,
				new VisibleSymbolsBuilder()
					.Reel(0, "AAA")
					.Reel(1, "AAA")
					.Reel(2, "AAA")
					.Reel(3, "AAA")
					.Reel(4, "AAA")
					.Build(),
				new WinData(new []
				{
					new Win(10,new Symbol('A'), 0,5,new List<Vector2>(), 0),
					new Win(10,new Symbol('A'), 1,5,new List<Vector2>(), 0),
					new Win(10,new Symbol('A'), 2,5,new List<Vector2>(), 0),
					new Win(10,new Symbol('A'), 3,5,new List<Vector2>(), 0),
					new Win(10,new Symbol('A'), 4,5,new List<Vector2>(), 0),
				})
			);

			//try to serialize
			string serializedStaticData = JsonConvert.SerializeObject(gameRoundData);

			//try to deserialize
			GameRoundData deserializedStaticData = JsonConvert.DeserializeObject<GameRoundData>(serializedStaticData);
		}
	}
}
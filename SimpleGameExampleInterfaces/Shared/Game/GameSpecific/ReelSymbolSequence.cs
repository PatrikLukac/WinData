using System.Collections.Generic;
using System.Text;
using SimpleGameExampleInterfaces.Shared.SymbolDefinitions;

namespace SimpleGameExampleInterfaces.Shared.GameRound.GameSpecific
{
	public class ReelSymbolSequence
	{
    /// <summary>The lowest allowed symbol</summary>
    public const char LOWEST_SYMBOL = '0';
    /// <summary>The highest allowed symbol</summary>
    public const char HIGHEST_SYMBOL = 'Z';

    /// <summary>The configured symbols</summary>
    public List<Symbol> Symbols { get; }

    /// <summary>The reel strip id</summary>
    public int Id { get; }

    /// <summary>
    ///    The number of symbols on the reel strip. This is the length of one cycle through the loop.
    /// </summary>
    public int Count => Symbols.Count;

    /// <summary>
    ///    Create a reel strip definition with the given symbols and an identifier.
    ///    This identifier can later be used to communicate information about the used reel strip to the
    ///    game client.
    /// </summary>
    /// <param name="id">Identifier for the strip</param>
    /// <param name="symbols">The sequence of symbols</param>
    public ReelSymbolSequence(int id, List<Symbol> symbols)
    {
      Id = id;
      Symbols = symbols;
    }

    /// <summary>
    ///    Create a new reel symbol sequence from a subset of the actual symbols.
    /// </summary>
    /// <param name="offset">start from here</param>
    /// <param name="count">take that number of symbols</param>
    /// <returns>A ReelSymbolSequence</returns>
    public ReelSymbolSequence SubSequence(int offset, int count)
    {
      if (offset + count <= Symbols.Count)
        return new ReelSymbolSequence(Id, Symbols.GetRange(offset, count));
      
      int count1 = offset + count - Symbols.Count;
      List<Symbol> newList = new List<Symbol>();
      newList.AddRange(Symbols.GetRange(offset, Symbols.Count-1));
      newList.AddRange(Symbols.GetRange(0, count1));
      return new ReelSymbolSequence(Id,newList);
    }

    /// <summary>
    ///    Printable representation of the object. For debugging purposes.
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
      StringBuilder stringBuilder = new StringBuilder();
      stringBuilder.Append(this.Id);
      stringBuilder.Append(":");
      foreach (Symbol symbol in this.Symbols)
        stringBuilder.Append(symbol.ID);
      return stringBuilder.ToString();
    }
  }
}
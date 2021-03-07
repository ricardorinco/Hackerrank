using System.Collections.Generic;

namespace Hackerrank.Common
{
    public abstract class AbstractConsole : IConsole
    {
        public List<string> Contents { get; } = new List<string>();

        public virtual void WriteLine(string text)
        {
            Contents.Add(text);
        }
    }
}

using System;

namespace Hackerrank.Common
{
    public class AppConsole : AbstractConsole
    {
        public override void WriteLine(string text)
        {
            Contents.Add(text);

            Console.WriteLine(text);
        }
    }
}

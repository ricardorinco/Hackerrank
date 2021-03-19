namespace Hackerrank.Common.Console
{
    public class AppConsole : AbstractConsole
    {
        public override void WriteLine(string text)
        {
            Contents.Add(text);

            System.Console.WriteLine(text);
        }
    }
}

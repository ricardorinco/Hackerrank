using System.Linq;

namespace Hackerrank.ConsoleApp
{
    public static class DesignerPdfViewerResolve
    {
        private static readonly string[] Alphabet =
        {
            "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m",
            "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"
        };

        public static int DesignerPdfViewer(int[] heights, string word)
        {
            var tallestLetter = 0;
            
            foreach (var c in word.ToCharArray())
            {
                var wordPosition = Alphabet
                    .Select((w, i) => new {i, w})
                    .Where(x => x.w == c.ToString().ToLower())
                    .Select(x => x.i)
                    .FirstOrDefault();

                var letterHeight = heights[wordPosition];

                if (letterHeight > tallestLetter)
                {
                    tallestLetter = heights[wordPosition];    
                }
            }

            return word.Length * 1 * tallestLetter;
        }
    }
}
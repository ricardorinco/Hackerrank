namespace Hackerrank.ConsoleApp
{
    public static class BreakingTheRecordsResolve
    {
        public static int[] BreakingRecords(int[] scores)
        {
            var mostRecord = scores[0];
            var leastRecord = scores[0];

            var mostRecordBreak = 0;
            var leastRecordBreak = 0;

            for (var i = 1; i < scores.Length; i++)
            {
                if (scores[i] > mostRecord)
                {
                    mostRecord = scores[i];
                    mostRecordBreak++;
                }

                if (scores[i] >= leastRecord) continue;
                leastRecord = scores[i];
                leastRecordBreak++;
            }
            
            return new[] { mostRecordBreak, leastRecordBreak };
        }
    }
}

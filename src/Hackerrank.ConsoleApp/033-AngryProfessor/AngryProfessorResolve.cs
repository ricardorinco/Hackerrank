using System.Collections.Generic;
using System.Linq;

namespace Hackerrank.ConsoleApp
{
    public static class AngryProfessorResolve
    {
        public static string AngryProfessor(int threshold, IEnumerable<int> students)
        {
            var studentsArrived = students.Count(x => x <= 0);

            return studentsArrived >= threshold ? "NO" : "YES";
        }
    }
}

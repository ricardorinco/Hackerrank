using System;
using System.Collections.Generic;
using System.Linq;

namespace Hackerrank.ConsoleApp
{
    public static class GradingStudentsResolve
    {
        public static List<int> GradingStudents(List<int> grades)
        {
            return grades.Select(GetFinalGrade).ToList();
        }

        private static int GetNextMultipleValue(int grade)
        {
            return (int)Math.Ceiling(grade / 5.0) * 5;
        }

        private static int GetFinalGrade(int grade)
        {
            var multiple = GetNextMultipleValue(grade);
            var difference = multiple - grade;

            if (difference > 2 || multiple < 40)
            {
                return grade;
            }

            return multiple;
        }
    }
}
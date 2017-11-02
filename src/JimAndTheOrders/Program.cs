using System;
using System.Collections.Generic;
using System.Linq;

namespace JimAndTheOrders
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var fans = new List<Fan>();
            var numberOrders = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numberOrders; i++)
            {
                var inputOrders = Console.ReadLine().Split(' ');
                var order = Array.ConvertAll(inputOrders, Int32.Parse);

                var fan = new Fan { Id = (i + 1), Time = order[0], OrderTake = order[1] };
                fans.Add(fan);
            }

            Console.WriteLine(string.Join(" ", fans.OrderBy(f => (f.Time + f.OrderTake)).Select(f => f.Id)));

            Console.ReadKey();
        }
    }

    public class Fan
    {
        public int Id { get; set; }
        public int Time { get; set; }
        public int OrderTake { get; set; }
    }
}

using Hackerrank.ConsoleApp;
using System;
using Xunit;

namespace Hackerrank.Tests
{
    public class JimAndTheOrdersResolveTests
    {
        [Fact]
        public void Should_be_list_with_3_orders_and_determine_preparation_and_delivery_time()
        {
            var orders = new int[3][];
            orders[0] = Array.ConvertAll("1 3".Split(' '), ordersTemp => Convert.ToInt32(ordersTemp));
            orders[1] = Array.ConvertAll("2 3".Split(' '), ordersTemp => Convert.ToInt32(ordersTemp));
            orders[2] = Array.ConvertAll("3 3".Split(' '), ordersTemp => Convert.ToInt32(ordersTemp));

            int[] result = JimAndTheOrdersResolve.JimOrders(orders);

            Assert.Equal(new int[] { 1, 2, 3 }, result);
        }

        [Fact]
        public void Should_be_list_with_5_orders_and_determine_preparation_and_delivery_time()
        {
            var orders = new int[5][];
            orders[0] = Array.ConvertAll("8 1".Split(' '), ordersTemp => Convert.ToInt32(ordersTemp));
            orders[1] = Array.ConvertAll("4 2".Split(' '), ordersTemp => Convert.ToInt32(ordersTemp));
            orders[2] = Array.ConvertAll("5 6".Split(' '), ordersTemp => Convert.ToInt32(ordersTemp));
            orders[3] = Array.ConvertAll("3 1".Split(' '), ordersTemp => Convert.ToInt32(ordersTemp));
            orders[4] = Array.ConvertAll("4 3".Split(' '), ordersTemp => Convert.ToInt32(ordersTemp));

            int[] result = JimAndTheOrdersResolve.JimOrders(orders);

            Assert.Equal(new int[] { 4, 2, 5, 1, 3 }, result);
        }
    }
}

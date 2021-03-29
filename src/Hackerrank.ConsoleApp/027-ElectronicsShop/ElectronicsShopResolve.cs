using System.Collections.Generic;

namespace Hackerrank.ConsoleApp
{
    public static class ElectronicsShopResolve
    {
        public static int GetMoneySpent(IEnumerable<int> keyboards, int[] drives, int budget)
        {
            var kitValue = 0;

            foreach (var keyboard in keyboards)
            {
                foreach (var drive in drives)
                {
                    var kit = keyboard + drive;
                    if (keyboard + drive <= budget && kitValue < kit)
                    {
                        kitValue = kit;
                    }
                }
            }
            
            return kitValue == 0 ? -1 : kitValue;
        }
    }
}
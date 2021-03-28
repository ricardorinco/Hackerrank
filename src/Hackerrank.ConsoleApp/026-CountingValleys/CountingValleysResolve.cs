namespace Hackerrank.ConsoleApp
{
    public static class CountingValleysResolve
    {
        public static int CountingValleys(int steps, string path)
        {
			var altitude = 0;
			var valleyCounter = 0;

			for (int i = 0; i < steps; i++)
			{
				var letter = path[i];
				if (letter == 'U')
				{
					altitude++;
					if (altitude == 0)
					{
						valleyCounter++;
					}
				}
				else
				{
					altitude--;
				}
			}

			return valleyCounter;
		}
    }
}

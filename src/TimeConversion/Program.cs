using System;

namespace TimeConversion
{
    public class Program
    {
        #region Chain of Responsibility

        #region Interfaces

        public interface IHourHandler
        {
            IHourHandler SetNext(IHourHandler handler);

            string Handle(string hours, string format);
        }

        #endregion

        #region Handlers

        public abstract class AbstractHandler : IHourHandler
        {
            private IHourHandler nextHandler;

            public IHourHandler SetNext(IHourHandler hourHandler)
            {
                nextHandler = hourHandler;

                return hourHandler;
            }

            public virtual string Handle(string hours, string format)
            {
                if (nextHandler != null)
                {
                    return nextHandler.Handle(hours, format);
                }
                else
                {
                    if (hours == "12" && format == "PM")
                    {
                        return "12";
                    }

                    return hours;
                }
            }
        }

        public class OneHourPmHandler : AbstractHandler
        {
            public override string Handle(string hours, string format)
            {
                if (hours == "01" && format == "PM")
                {
                    return $"13";
                }
                else
                {
                    return base.Handle(hours, format);
                }
            }
        }
        public class TwoHourPmHandler : AbstractHandler
        {
            public override string Handle(string hours, string format)
            {
                if (hours == "02" && format == "PM")
                {
                    return $"14";
                }
                else
                {
                    return base.Handle(hours, format);
                }
            }
        }
        public class ThreeHourPmHandler : AbstractHandler
        {
            public override string Handle(string hours, string format)
            {
                if (hours == "03" && format == "PM")
                {
                    return $"15";
                }
                else
                {
                    return base.Handle(hours, format);
                }
            }
        }
        public class FourHourPmHandler : AbstractHandler
        {
            public override string Handle(string hours, string format)
            {
                if (hours == "04" && format == "PM")
                {
                    return $"16";
                }
                else
                {
                    return base.Handle(hours, format);
                }
            }
        }
        public class FiveHourPmHandler : AbstractHandler
        {
            public override string Handle(string hours, string format)
            {
                if (hours == "05" && format == "PM")
                {
                    return $"17";
                }
                else
                {
                    return base.Handle(hours, format);
                }
            }
        }
        public class SixHourPmHandler : AbstractHandler
        {
            public override string Handle(string hours, string format)
            {
                if (hours == "06" && format == "PM")
                {
                    return $"18";
                }
                else
                {
                    return base.Handle(hours, format);
                }
            }
        }
        public class SevenHourPmHandler : AbstractHandler
        {
            public override string Handle(string hours, string format)
            {
                if (hours == "07" && format == "PM")
                {
                    return $"19";
                }
                else
                {
                    return base.Handle(hours, format);
                }
            }
        }
        public class EightHourPmHandler : AbstractHandler
        {
            public override string Handle(string hours, string format)
            {
                if (hours == "08" && format == "PM")
                {
                    return $"20";
                }
                else
                {
                    return base.Handle(hours, format);
                }
            }
        }
        public class NineHourPmHandler : AbstractHandler
        {
            public override string Handle(string hours, string format)
            {
                if (hours == "09" && format == "PM")
                {
                    return $"21";
                }
                else
                {
                    return base.Handle(hours, format);
                }
            }
        }
        public class TenHourPmHandler : AbstractHandler
        {
            public override string Handle(string hours, string format)
            {
                if (hours == "10" && format == "PM")
                {
                    return $"22";
                }
                else
                {
                    return base.Handle(hours, format);
                }
            }
        }
        public class ElevenHourPmHandler : AbstractHandler
        {
            public override string Handle(string hours, string format)
            {
                if (hours == "11" && format == "PM")
                {
                    return $"23";
                }
                else
                {
                    return base.Handle(hours, format);
                }
            }
        }
        public class TwelveHourPmHandler : AbstractHandler
        {
            public override string Handle(string hours, string format)
            {
                if (hours == "12" && format == "AM")
                {
                    return $"00";
                }
                else
                {
                    return base.Handle(hours, format);
                }
            }
        }

        #endregion

        #endregion

        private static string convertHourToFormat(string hours, string format)
        {
            var oneHourPmHandler = new OneHourPmHandler();
            var twoHourPmHandler = new TwoHourPmHandler();
            var threeHourPmHandler = new ThreeHourPmHandler();
            var fourHourPmHandler = new FourHourPmHandler();
            var fiveHourPmHandler = new FiveHourPmHandler();
            var sixHourPmHandler = new SixHourPmHandler();
            var sevenHourPmHandler = new SevenHourPmHandler();
            var eightHourPmHandler = new EightHourPmHandler();
            var nineHourPmHandler = new NineHourPmHandler();
            var tenHourPmHandler = new TenHourPmHandler();
            var elevenHourPmHandler = new ElevenHourPmHandler();
            var twelveHourPmHandler = new TwelveHourPmHandler();

            oneHourPmHandler
                .SetNext(twoHourPmHandler)
                .SetNext(threeHourPmHandler)
                .SetNext(fourHourPmHandler)
                .SetNext(fiveHourPmHandler)
                .SetNext(sixHourPmHandler)
                .SetNext(sevenHourPmHandler)
                .SetNext(eightHourPmHandler)
                .SetNext(nineHourPmHandler)
                .SetNext(tenHourPmHandler)
                .SetNext(elevenHourPmHandler)
                .SetNext(twelveHourPmHandler);

            return oneHourPmHandler.Handle(hours, format);
        }

        public static string timeConversion(string time)
        {
            string format = time.Substring(time.Length - 2, 2);
            string hours = time.Substring(0, 2);
            string minutes = time.Substring(3, 2);
            string seconds = time.Substring(6, 2);

            hours = convertHourToFormat(hours, format);

            return $"{hours}:{minutes}:{seconds}";
        }

        public static void Main(string[] args)
        {
            string time = Console.ReadLine().Trim();

            string result = timeConversion(time);

            Console.Write(result);
            Console.ReadKey();
        }
    }
}

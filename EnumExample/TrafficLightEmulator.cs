using System;

using System.Threading;
namespace EnumExample
{
    public static class TrafficLightEmulator
    {
        public static void EmulatorRunner()
        {

            Console.WriteLine("Press ESC to stop this traffic light hell");
            do
            {
                while (!Console.KeyAvailable)
                {
                    Console.WriteLine(TrafficLights.GREEN);
                    Thread.Sleep(8000);
                    Console.WriteLine(TrafficLights.YELLOW);
                    Thread.Sleep(3000);
                    Console.WriteLine(TrafficLights.RED);
                    Thread.Sleep(10000);
                }
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);

        }
    }
}

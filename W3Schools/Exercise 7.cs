using System;

namespace W3Schools
{
    public class Exercise7
    {
        public void Start()
        {
            float distance;
            float hour, min, sec;
            float timeSec;

            float kmh, mph, mps;

            Console.WriteLine("Input distace: ");
            distance = float.Parse(Console.ReadLine());
            Console.WriteLine("Input timeSec(hour): ");
            hour = float.Parse(Console.ReadLine());
            Console.WriteLine("Input timeSec(minutes): ");
            min = float.Parse(Console.ReadLine());
            Console.WriteLine("Input timeSec(seconds): ");
            sec = float.Parse(Console.ReadLine());

            timeSec = (hour * 3600) + (min * 60) + sec;
            mps = distance / timeSec;
            kmh = (distance / 1000f) / (timeSec / 3600f);
            mph = kmh / 1.609f;

            Console.WriteLine($"Your speed in meters per second: {mps}");
            Console.WriteLine($"Your speed in kilometers per hour: {kmh}");
            Console.WriteLine($"Your speed in miles per hour: {mph}");


        }
    }
}
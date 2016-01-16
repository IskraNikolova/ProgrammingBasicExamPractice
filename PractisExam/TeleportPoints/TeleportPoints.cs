using System.Linq;

namespace TeleportPoints
{
    using System;

    public class TeleportPoints
    {
        public static void Main()
        {
            double[] coordinatesForA =
                Console.ReadLine()
                    .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(double.Parse)
                    .ToArray();

            double[] coordinatesForB =
                Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(double.Parse)
                    .ToArray();

            double[] coordinatesForC =
                 Console.ReadLine()
                     .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                     .Select(double.Parse)
                     .ToArray();

            double[] coordinatesForD =
                 Console.ReadLine()
                     .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                     .Select(double.Parse)
                     .ToArray();

            double radius = double.Parse(Console.ReadLine());
            double step = double.Parse(Console.ReadLine());

            double aX = coordinatesForA[0];
            double aY = coordinatesForA[1];
            double bX = coordinatesForB[0];
            double bY = coordinatesForB[1];
            double cX = coordinatesForC[0];
            double cY = coordinatesForC[1];
            double dX = coordinatesForD[0];
            double dY = coordinatesForD[1];

            int pointCounter = 0;

            for (double x = 0; x <= radius; x += step)
            {
                for (double y = 0; y <= radius; y += step)
                {
                    if ((Math.Pow(x, 2) + Math.Pow(y, 2)) <= Math.Pow(radius, 2))
                    {
                        if ((x > aX && x < bX) && (y < cY && y > bY))
                        {
                            pointCounter++;
                        }
                    }
                }

                for (double y = -step; y >= -radius; y -= step)
                {
                    if ((Math.Pow(x, 2) + Math.Pow(y, 2)) <= Math.Pow(radius, 2))
                    {
                        if ((x > aX && x < bX) && (y < cY && y > bY))
                        {
                            pointCounter++;
                        }
                    }
                }

            }

            for (double x = -step; x >= -radius; x -= step)
            {
                for (double y = 0; y <= radius; y += step)
                {
                    if ((Math.Pow(x, 2) + Math.Pow(y, 2)) <= Math.Pow(radius, 2))
                    {
                        if ((x > aX && x < bX) && (y < cY && y > bY))
                        {
                            pointCounter++;
                        }
                    }
                }

                for (double y = -step; y >= -radius; y -= step)
                {
                    if ((Math.Pow(x, 2) + Math.Pow(y, 2)) <= Math.Pow(radius, 2))
                    {
                        if ((x > aX && x < bX) && (y < cY && y > bY))
                        {
                            pointCounter++;
                        }
                    }
                }
            }

            Console.WriteLine(pointCounter);
        }
    }
}

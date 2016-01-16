namespace TorrentPirate
{
    using  System;

    public class TorrentPirate
    {
        public static void Main()
        {
            const int sizeOfMoviesInMB = 1500;
            const int mBOnSecond = 2;
            const int seconds = 60;
            const int minutes = 60;

            double megabytesDownwoad = double.Parse(Console.ReadLine());
            double priceForTicket = double.Parse(Console.ReadLine());
            double wifeSpending = double.Parse(Console.ReadLine());

            double downLoadTimeInOursInThaMall = megabytesDownwoad/mBOnSecond/seconds/minutes;
            double downloadPrice = downLoadTimeInOursInThaMall*wifeSpending;
            double numberOfMovies = megabytesDownwoad/sizeOfMoviesInMB;
            double cinemaPrice = numberOfMovies*priceForTicket;

            if (downloadPrice <= cinemaPrice)
            {
                Console.WriteLine($"mall -> {downloadPrice:F2}lv");
            }
            else
            {
                Console.WriteLine($"cinema -> {cinemaPrice:F2}lv");
            }
        }
    }
}

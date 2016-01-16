namespace TheBetterMusicProducer
{
    using System;

    public class TheBetteMusicProducer
    {
        public static void Main()
        {
            const decimal EuroIsLv = 1.94m;
            const decimal DollarsIsLv = 1.72m;
            const decimal PessosIsLv = 332.74m;

            int numberOfAlbumsSoldInEurope = int.Parse(Console.ReadLine());
            decimal priceAnAlbumInEuro = decimal.Parse(Console.ReadLine());
            decimal priceAnAlbumInLevafromEuro = priceAnAlbumInEuro * EuroIsLv;
            decimal resultOfEurope = numberOfAlbumsSoldInEurope * priceAnAlbumInLevafromEuro;

            int numberOfAlbumsSoldInNorthAmerica = int.Parse(Console.ReadLine());
            decimal priceOfAnAlbumInDollar = decimal.Parse(Console.ReadLine());
            decimal priceOfAnAlbumInLevaFromDollar = priceOfAnAlbumInDollar * DollarsIsLv;
            decimal resultOfNorthAmerica = numberOfAlbumsSoldInNorthAmerica * priceOfAnAlbumInLevaFromDollar;

            int numberOfAlbumsSoldInSouthAmerica = int.Parse(Console.ReadLine());
            decimal priceOfAnAlbumInPesos = decimal.Parse(Console.ReadLine());
            decimal priceOfAnAlbumInLevaFromPessos = priceOfAnAlbumInPesos / PessosIsLv;
            decimal resultOfSouthAmerica = numberOfAlbumsSoldInSouthAmerica * priceOfAnAlbumInLevaFromPessos;

            decimal allAlbums = resultOfEurope + resultOfNorthAmerica + resultOfSouthAmerica;
            decimal resultProcent = allAlbums * 0.35m;
            decimal resultAfterProcent = allAlbums - resultProcent;
            decimal afterTexasProcent = (resultAfterProcent - (resultAfterProcent * 0.20m));

            int numberOfConcertsDuringATour = int.Parse(Console.ReadLine());
            decimal profitFromASingleConcertInEuro = decimal.Parse(Console.ReadLine());
            decimal priceFromEuroInLeva = profitFromASingleConcertInEuro * EuroIsLv;
            decimal resultOfConcert = numberOfConcertsDuringATour * priceFromEuroInLeva;
            if (resultOfConcert > 100000)
            {
                resultOfConcert = (resultOfConcert - (resultOfConcert * 0.15m));
            }

            if (afterTexasProcent <= resultOfConcert)
            {
                Console.WriteLine($"On the road again! We'll see the world and earn {resultOfConcert:F2}lv.");
            }
            else if (afterTexasProcent > resultOfConcert)
            {
                Console.WriteLine($"Let's record some songs! They'll bring us {afterTexasProcent:F2}lv.");
            }
        }
    }
}

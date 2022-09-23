using System;
using System.Threading.Tasks;

namespace RaceWinners
{
    class Program
    {
        static async Task Main(string[] args)
        {
            DataService ds = new DataService();
 
            // Asynchronously retrieve the group (class) data
            var data = await ds.GetGroupRanksAsync();

            double fraction = 0.8;
            int count = 0;

            for (int i = 0; i < data.Count; i++)
            {
                count += data[i].Ranks.Count;
            }

                for (int i = 0; i < data.Count; i++)
            {
                double points = 0;

                var ranks = data[i].Ranks;

                foreach (var rank in ranks)
                {
                    points += 100 * Math.Pow(fraction, rank - 1);
                }
                Console.WriteLine($"{data[i].Name} - {Math.Round(points, 2)}");
            }
        }
    }
}
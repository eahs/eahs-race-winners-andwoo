﻿using System;
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

            for (int i = 0; i < data.Count; i++)
            {
                double points = 0;
                
                for (int rank: data[i].Ranks)
                
                Console.WriteLine($"{data[i].Name} - [{ranks}]");
            }
        }
    }
}
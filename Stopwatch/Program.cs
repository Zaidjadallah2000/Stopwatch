using System;
using System.Diagnostics;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        Stopwatch stopwatch = Stopwatch.StartNew();
        List<object> Numbers = new List<object>();
        List<int> Numbers1 = new List<int>();
        Random random = new Random();
        for (int i = 0; i < 1000000; i++) 
        {
            Numbers.Add(random.Next(10,10000));
        }
        stopwatch.Stop();
        Console.WriteLine($"Time need to fill boxing list :{stopwatch.ElapsedMilliseconds}");
        stopwatch.Restart();
        for (int i = 0; i < Numbers.Count; i++)
        {
            Numbers1.Add((int)Numbers[i]);
        }
        stopwatch.Stop();
        Console.WriteLine($"Time need to fill unboxing list :{stopwatch.ElapsedMilliseconds}");



    }
}

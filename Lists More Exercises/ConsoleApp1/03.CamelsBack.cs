using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class CamelsBack
{
    static void Main(string[] args)
    {
        List<int> sequence = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        int sizeCamel = int.Parse(Console.ReadLine());
        int round = 0;
        while (sequence.Count > sizeCamel)
        {
            sequence.RemoveAt(0);
            sequence.RemoveAt(sequence.Count - 1);
            round++;
            
        }
        if (round > 0)
        {
            Console.WriteLine($"{round} rounds\nremaining: {String.Join(" ", sequence)}");
        }
        else
        {
            Console.WriteLine($"already stable: {String.Join(" ", sequence)}");
        }
    }
}


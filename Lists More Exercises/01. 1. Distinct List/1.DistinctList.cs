using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class DistincList
{
    static void Main(string[] args)
    {
        List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        Console.WriteLine(String.Join(" ",input.Distinct()));
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class UnionLists
{
    static void Main(string[] args)
    {
        List<int> primal = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        int n = int.Parse(Console.ReadLine());
        List<int> toInsert = new List<int>();
        string input = string.Empty;
        for (int i = 0; i < n; i++)
        {
            input = Console.ReadLine();
            toInsert = input.Split(' ').Select(int.Parse).ToList();
            for (int x = 0; x < toInsert.Count; x++)
            {
                if (primal.Contains(toInsert[x]))
                {
                    primal.Remove(toInsert[x]);
                }
                else
                {
                    primal.Add(toInsert[x]);
                }
            }
        }
        primal = primal.OrderBy(a=>a).ToList() ;
        Console.WriteLine(String.Join(" ",primal));
    }
}


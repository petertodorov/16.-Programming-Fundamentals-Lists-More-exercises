using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class IntigerInsertion
{
    static void Main(string[] args)
    {
        List<string> receiver = Console.ReadLine().Split(' ').ToList();
        string toInsert = Console.ReadLine();
        List<string> numToInsert = new List<string>();
        List<int> index = new List<int>();
        while (toInsert != "end")
        {
            index.Add((int)char.GetNumericValue(toInsert.First()));
            numToInsert.Add(toInsert);
            toInsert = Console.ReadLine();
        }
        for (int i = 0; i < index.Count; i++)
        {
            receiver.Insert(index[i], numToInsert[i]);
        }
        Console.WriteLine(String.Join(" ", receiver));
    }
}


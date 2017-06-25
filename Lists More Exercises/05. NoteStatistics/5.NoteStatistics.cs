﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class NoteStatistics
{
    static void Main(string[] args)
    {
        List<decimal> frecs = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();
        
        Dictionary<decimal, string> notes = new Dictionary<decimal, string>()
        {
            {261.63M,"C"},
            {277.18M,"C#"},
            {293.66M,"D"},
            {311.13M,"D#"},
            {329.63M,"E"},
            {349.23M,"F"},
            {369.99M,"F#"},
            {392.0M,"G"},
            {415.3M,"G#"},
            {440.0M,"A"},
            {466.16M,"A#"},
            {493.88M,"B"},
        };

        string[] note = new string[frecs.Count];
        List<string> naturals = new List<string>();
        List<string> sharps = new List<string>();
        decimal sumNaturals = new decimal();
        decimal sumSharps = new decimal();
        int counter = 0;

        foreach (var item in notes)
        {
            if (counter < frecs.Count)
            {
                if (notes.ContainsKey(frecs[counter]))
                {
                    notes.TryGetValue(frecs[counter], out note[counter]);
                    if (note[counter].Length < 2)
                    {
                        naturals.Add(note[counter]);
                        sumNaturals += frecs[counter];
                    }
                    else if (note[counter].Last() == '#')
                    {
                        sharps.Add(note[counter]);
                        sumSharps += frecs[counter];
                    }
                }
                counter++;
            }
            else
            {
                break;
            }
        }
        Console.WriteLine($"Notes: {string.Join(" ", note)}");
        Console.WriteLine($"Naturals: {string.Join(", ", naturals)}");
        Console.WriteLine($"Sharps: {string.Join(", ", sharps)}");
        Console.WriteLine($"Naturals sum: {sumNaturals}");
        Console.WriteLine($"Sharps sum: {sumSharps}");
    }
}


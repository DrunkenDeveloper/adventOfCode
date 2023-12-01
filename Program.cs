// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;

Console.WriteLine("Advent of Code 1-1");


var lines = File.ReadLines("input1-1.txt");
Console.WriteLine(lines.Select(l => Regex.Matches(l, @"\d")).Select(mc => string.Join(string.Empty, [mc[0].Value, mc[^1].Value])).Select(c => int.Parse(c)).Sum());
// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;

Console.WriteLine("Advent of Code 1-2");


var numberOrNumberString = new Regex(@"\d|one|two|three|four|five|six|seven|eight|nine");
var numberOrNumberStringRightToLeft = new Regex(@"\d|one|two|three|four|five|six|seven|eight|nine",RegexOptions.RightToLeft);
var numberStringToNumberAsString = new Dictionary<string, string> {
    {"one", "1"},
    {"two", "2"},
    {"three", "3"},
    {"four", "4"},
    {"five", "5"},
    {"six", "6"},
    {"seven", "7"},
    {"eight", "8"},
    {"nine", "9"}
};

var lines = File.ReadLines("input1-2.txt");
Console.WriteLine(lines.Select(l => (numberOrNumberString.Matches(l), numberOrNumberStringRightToLeft.Matches(l))).
Select(mct => string.Join(string.Empty, [GetNumberString(mct.Item1[0].Value), GetNumberString(mct.Item2[0].Value)])).Select(c => int.Parse(c)).Sum());


static string GetNumberString(string numberOrNumberString)
{ 
    if(numberOrNumberString.Length == 1)
    {
        return numberOrNumberString;
    }

    return numberOrNumberString switch
    {
        "one" => "1",
        "two" => "2",
        "three" => "3",
        "four" => "4",
        "five" => "5",
        "six" => "6",
        "seven" => "7",
        "eight" => "8",
        "nine" => "9",
        _ => throw new ArgumentException($"Unexpected numberOrNumberString: {numberOrNumberString}", nameof(numberOrNumberString))
    };
};

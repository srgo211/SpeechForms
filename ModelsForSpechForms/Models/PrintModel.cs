using ModelsForSpechForms.Interfaces;

namespace ModelsForSpechForms.Models;

public record class PrintModel : IPrintModel
{
    public const char charPass = 'н';
    public const char charWeek = 'в';
    public const string charPay = default;

    public int Id { get; set; }
    public string User { get; init; }
    public string Day1 { get; init; }
    public string Day2 { get; init; }
    public string Day3 { get; init; }
    public string Day4 { get; init; }
    public string Day5 { get; init; }
    public string Day6 { get; init; }
    public string Day7 { get; init; }
    public string Day8 { get; init; }
    public string Day9 { get; init; }
    public string Day10 { get; init; }
    public string Day11 { get; init; }
    public string Day12 { get; init; }
    public string Day13 { get; init; }
    public string Day14 { get; init; }
    public string Day15 { get; init; }
    public string Day16 { get; init; }
    public string Day17 { get; init; }
    public string Day18 { get; init; }
    public string Day19 { get; init; }
    public string Day20 { get; init; }
    public string Day21 { get; init; }
    public string Day22 { get; init; }
    public string Day23 { get; init; }
    public string Day24 { get; init; }
    public string Day25 { get; init; }
    public string Day26 { get; init; }
    public string Day27 { get; init; }
    public string Day28 { get; init; }
    public string Day29 { get; init; }
    public string Day30 { get; init; }
    public string Day31 { get; init; }
    public int TotalPass { get; set; }
    public int TotalPay { get; set; }
    public int TotalWeek { get; set; }
}

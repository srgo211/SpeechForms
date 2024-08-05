using System.Reflection;
using static System.Net.Mime.MediaTypeNames;

namespace SpeechForms.Bl;

public class Calculate
{
  
    public static (int absentCount, int payableDays) CalculateAbsentDays(IAttendanceByDayBase days, int month = 0)
    {
        int absentCount = 0;
        int payableDays = 0;
        if (days is null) return (absentCount, payableDays);


        if (days.Day1 && !days.IsWeekend1) absentCount += 1;
        if (days.Day2 && !days.IsWeekend2) absentCount += 1;
        if (days.Day3 && !days.IsWeekend3) absentCount += 1;
        if (days.Day4 && !days.IsWeekend4) absentCount += 1;
        if (days.Day5 && !days.IsWeekend5) absentCount += 1;
        if (days.Day6 && !days.IsWeekend6) absentCount += 1;
        if (days.Day7 && !days.IsWeekend7) absentCount += 1;
        if (days.Day8 && !days.IsWeekend8) absentCount += 1;
        if (days.Day9 && !days.IsWeekend9) absentCount += 1;
        if (days.Day10 && !days.IsWeekend10) absentCount += 1;
        if (days.Day11 && !days.IsWeekend11) absentCount += 1;
        if (days.Day12 && !days.IsWeekend12) absentCount += 1;
        if (days.Day13 && !days.IsWeekend13) absentCount += 1;
        if (days.Day14 && !days.IsWeekend14) absentCount += 1;
        if (days.Day15 && !days.IsWeekend15) absentCount += 1;
        if (days.Day16 && !days.IsWeekend16) absentCount += 1;
        if (days.Day17 && !days.IsWeekend17) absentCount += 1;
        if (days.Day18 && !days.IsWeekend18) absentCount += 1;
        if (days.Day19 && !days.IsWeekend19) absentCount += 1;
        if (days.Day20 && !days.IsWeekend20) absentCount += 1;
        if (days.Day21 && !days.IsWeekend21) absentCount += 1;
        if (days.Day22 && !days.IsWeekend22) absentCount += 1;
        if (days.Day23 && !days.IsWeekend23) absentCount += 1;
        if (days.Day24 && !days.IsWeekend24) absentCount += 1;
        if (days.Day25 && !days.IsWeekend25) absentCount += 1;
        if (days.Day26 && !days.IsWeekend26) absentCount += 1;
        if (days.Day27 && !days.IsWeekend27) absentCount += 1;
        if (days.Day28 && !days.IsWeekend28) absentCount += 1;
        if (days.Day29 && !days.IsWeekend29) absentCount += 1;
        if (days.Day30 && !days.IsWeekend30) absentCount += 1;
        if (days.Day31 && !days.IsWeekend31) absentCount += 1;


        if (!days.Day1 && !days.IsWeekend1) payableDays += 1;
        if (!days.Day2 && !days.IsWeekend2) payableDays += 1;
        if (!days.Day3 && !days.IsWeekend3) payableDays += 1;
        if (!days.Day4 && !days.IsWeekend4) payableDays += 1;
        if (!days.Day5 && !days.IsWeekend5) payableDays += 1;
        if (!days.Day6 && !days.IsWeekend6) payableDays += 1;
        if (!days.Day7 && !days.IsWeekend7) payableDays += 1;
        if (!days.Day8 && !days.IsWeekend8) payableDays += 1;
        if (!days.Day9 && !days.IsWeekend9) payableDays += 1;
        if (!days.Day10 && !days.IsWeekend10) payableDays += 1;
        if (!days.Day11 && !days.IsWeekend11) payableDays += 1;
        if (!days.Day12 && !days.IsWeekend12) payableDays += 1;
        if (!days.Day13 && !days.IsWeekend13) payableDays += 1;
        if (!days.Day14 && !days.IsWeekend14) payableDays += 1;
        if (!days.Day15 && !days.IsWeekend15) payableDays += 1;
        if (!days.Day16 && !days.IsWeekend16) payableDays += 1;
        if (!days.Day17 && !days.IsWeekend17) payableDays += 1;
        if (!days.Day18 && !days.IsWeekend18) payableDays += 1;
        if (!days.Day19 && !days.IsWeekend19) payableDays += 1;
        if (!days.Day20 && !days.IsWeekend20) payableDays += 1;
        if (!days.Day21 && !days.IsWeekend21) payableDays += 1;
        if (!days.Day22 && !days.IsWeekend22) payableDays += 1;
        if (!days.Day23 && !days.IsWeekend23) payableDays += 1;
        if (!days.Day24 && !days.IsWeekend24) payableDays += 1;
        if (!days.Day25 && !days.IsWeekend25) payableDays += 1;
        if (!days.Day26 && !days.IsWeekend26) payableDays += 1;
        if (!days.Day27 && !days.IsWeekend27) payableDays += 1;
        if (!days.Day28 && !days.IsWeekend28) payableDays += 1;
        if (!days.Day29 && !days.IsWeekend29) payableDays += 1;
        if (!days.Day30 && !days.IsWeekend30) payableDays += 1;
        if (!days.Day31 && !days.IsWeekend31) payableDays += 1;



        return (absentCount, payableDays);

    }
}

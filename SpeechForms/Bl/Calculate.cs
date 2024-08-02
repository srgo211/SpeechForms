using System.Reflection;
using static System.Net.Mime.MediaTypeNames;

namespace SpeechForms.Bl;

public class Calculate
{
    public static (int absentCount, int payableDays) CalculateAbsentDays(IUserAttendanceTable tables, int month = 0)
    {
        int absentCount = 0;
        int payableDays = 0;
        if (tables is null) return (absentCount, payableDays);
        
        var days = tables.MonthAttendanceDays;


        if (days.Day1.IsPass  && !days.Day1.IsWeekend)  absentCount += 1;
        if (days.Day2.IsPass  && !days.Day2.IsWeekend)  absentCount += 1;
        if (days.Day3.IsPass  && !days.Day3.IsWeekend)  absentCount += 1;
        if (days.Day4.IsPass  && !days.Day4.IsWeekend)  absentCount += 1;
        if (days.Day5.IsPass  && !days.Day5.IsWeekend)  absentCount += 1;
        if (days.Day6.IsPass  && !days.Day6.IsWeekend)  absentCount += 1;
        if (days.Day7.IsPass  && !days.Day7.IsWeekend)  absentCount += 1;
        if (days.Day8.IsPass  && !days.Day8.IsWeekend)  absentCount += 1;
        if (days.Day9.IsPass  && !days.Day9.IsWeekend)  absentCount += 1;
        if (days.Day10.IsPass && !days.Day10.IsWeekend) absentCount += 1;
        if (days.Day11.IsPass && !days.Day11.IsWeekend) absentCount += 1;
        if (days.Day12.IsPass && !days.Day12.IsWeekend) absentCount += 1;
        if (days.Day13.IsPass && !days.Day13.IsWeekend) absentCount += 1;
        if (days.Day14.IsPass && !days.Day14.IsWeekend) absentCount += 1;
        if (days.Day15.IsPass && !days.Day15.IsWeekend) absentCount += 1;
        if (days.Day16.IsPass && !days.Day16.IsWeekend) absentCount += 1;
        if (days.Day17.IsPass && !days.Day17.IsWeekend) absentCount += 1;
        if (days.Day18.IsPass && !days.Day18.IsWeekend) absentCount += 1;
        if (days.Day19.IsPass && !days.Day19.IsWeekend) absentCount += 1;
        if (days.Day20.IsPass && !days.Day20.IsWeekend) absentCount += 1;
        if (days.Day21.IsPass && !days.Day21.IsWeekend) absentCount += 1;
        if (days.Day22.IsPass && !days.Day22.IsWeekend) absentCount += 1;
        if (days.Day23.IsPass && !days.Day23.IsWeekend) absentCount += 1;
        if (days.Day24.IsPass && !days.Day24.IsWeekend) absentCount += 1;
        if (days.Day25.IsPass && !days.Day25.IsWeekend) absentCount += 1;
        if (days.Day26.IsPass && !days.Day26.IsWeekend) absentCount += 1;
        if (days.Day27.IsPass && !days.Day27.IsWeekend) absentCount += 1;
        if (days.Day28.IsPass && !days.Day28.IsWeekend) absentCount += 1;
        if (days.Day29.IsPass && !days.Day29.IsWeekend) absentCount += 1;
        if (days.Day30.IsPass && !days.Day30.IsWeekend) absentCount += 1;
        if (days.Day31.IsPass && !days.Day31.IsWeekend) absentCount += 1;


        if (!days.Day1.IsPass  && !days.Day1.IsWeekend)  payableDays += 1;
        if (!days.Day2.IsPass  && !days.Day2.IsWeekend)  payableDays += 1;
        if (!days.Day3.IsPass  && !days.Day3.IsWeekend)  payableDays += 1;
        if (!days.Day4.IsPass  && !days.Day4.IsWeekend)  payableDays += 1;
        if (!days.Day5.IsPass  && !days.Day5.IsWeekend)  payableDays += 1;
        if (!days.Day6.IsPass  && !days.Day6.IsWeekend)  payableDays += 1;
        if (!days.Day7.IsPass  && !days.Day7.IsWeekend)  payableDays += 1;
        if (!days.Day8.IsPass  && !days.Day8.IsWeekend)  payableDays += 1;
        if (!days.Day9.IsPass  && !days.Day9.IsWeekend)  payableDays += 1;
        if (!days.Day10.IsPass && !days.Day10.IsWeekend) payableDays += 1;
        if (!days.Day11.IsPass && !days.Day11.IsWeekend) payableDays += 1;
        if (!days.Day12.IsPass && !days.Day12.IsWeekend) payableDays += 1;
        if (!days.Day13.IsPass && !days.Day13.IsWeekend) payableDays += 1;
        if (!days.Day14.IsPass && !days.Day14.IsWeekend) payableDays += 1;
        if (!days.Day15.IsPass && !days.Day15.IsWeekend) payableDays += 1;
        if (!days.Day16.IsPass && !days.Day16.IsWeekend) payableDays += 1;
        if (!days.Day17.IsPass && !days.Day17.IsWeekend) payableDays += 1;
        if (!days.Day18.IsPass && !days.Day18.IsWeekend) payableDays += 1;
        if (!days.Day19.IsPass && !days.Day19.IsWeekend) payableDays += 1;
        if (!days.Day20.IsPass && !days.Day20.IsWeekend) payableDays += 1;
        if (!days.Day21.IsPass && !days.Day21.IsWeekend) payableDays += 1;
        if (!days.Day22.IsPass && !days.Day22.IsWeekend) payableDays += 1;
        if (!days.Day23.IsPass && !days.Day23.IsWeekend) payableDays += 1;
        if (!days.Day24.IsPass && !days.Day24.IsWeekend) payableDays += 1;
        if (!days.Day25.IsPass && !days.Day25.IsWeekend) payableDays += 1;
        if (!days.Day26.IsPass && !days.Day26.IsWeekend) payableDays += 1;
        if (!days.Day27.IsPass && !days.Day27.IsWeekend) payableDays += 1;
        if (!days.Day28.IsPass && !days.Day28.IsWeekend) payableDays += 1;
        if (!days.Day29.IsPass && !days.Day29.IsWeekend) payableDays += 1;
        if (!days.Day30.IsPass && !days.Day30.IsWeekend) payableDays += 1;
        if (!days.Day31.IsPass && !days.Day31.IsWeekend) payableDays += 1;


        return (absentCount, payableDays);

    }


    public static (int absentCount, int payableDays) CalculateAbsentDays(IAttendanceByDayBase days, int month = 0)
    {
        int absentCount = 0;
        int payableDays = 0;
        if (days is null) return (absentCount, payableDays);

       


        if ( days.Day1?.IsPass==true &&  days.Day1?.IsWeekend == false) absentCount += 1;
        if ( days.Day2?.IsPass==true &&  days.Day2?.IsWeekend == false) absentCount += 1;
        if ( days.Day3?.IsPass==true &&  days.Day3?.IsWeekend == false) absentCount += 1;
        if ( days.Day4?.IsPass==true &&  days.Day4?.IsWeekend == false) absentCount += 1;
        if ( days.Day5?.IsPass==true &&  days.Day5?.IsWeekend == false) absentCount += 1;
        if ( days.Day6?.IsPass==true &&  days.Day6?.IsWeekend == false) absentCount += 1;
        if ( days.Day7?.IsPass==true &&  days.Day7?.IsWeekend == false) absentCount += 1;
        if ( days.Day8?.IsPass==true &&  days.Day8?.IsWeekend == false) absentCount += 1;
        if ( days.Day9?.IsPass==true &&  days.Day9?.IsWeekend == false) absentCount += 1;
        if (days.Day10?.IsPass==true &&  days.Day10?.IsWeekend == false) absentCount += 1;
        if (days.Day11?.IsPass==true &&  days.Day11?.IsWeekend == false) absentCount += 1;
        if (days.Day12?.IsPass==true &&  days.Day12?.IsWeekend == false) absentCount += 1;
        if (days.Day13?.IsPass==true &&  days.Day13?.IsWeekend == false) absentCount += 1;
        if (days.Day14?.IsPass==true &&  days.Day14?.IsWeekend == false) absentCount += 1;
        if (days.Day15?.IsPass==true &&  days.Day15?.IsWeekend == false) absentCount += 1;
        if (days.Day16?.IsPass==true &&  days.Day16?.IsWeekend == false) absentCount += 1;
        if (days.Day17?.IsPass==true &&  days.Day17?.IsWeekend == false) absentCount += 1;
        if (days.Day18?.IsPass==true &&  days.Day18?.IsWeekend == false) absentCount += 1;
        if (days.Day19?.IsPass==true &&  days.Day19?.IsWeekend == false) absentCount += 1;
        if (days.Day20?.IsPass==true &&  days.Day20?.IsWeekend == false) absentCount += 1;
        if (days.Day21?.IsPass==true &&  days.Day21?.IsWeekend == false) absentCount += 1;
        if (days.Day22?.IsPass==true &&  days.Day22?.IsWeekend == false) absentCount += 1;
        if (days.Day23?.IsPass==true &&  days.Day23?.IsWeekend == false) absentCount += 1;
        if (days.Day24?.IsPass==true &&  days.Day24?.IsWeekend == false) absentCount += 1;
        if (days.Day25?.IsPass==true &&  days.Day25?.IsWeekend == false) absentCount += 1;
        if (days.Day26?.IsPass==true &&  days.Day26?.IsWeekend == false) absentCount += 1;
        if (days.Day27?.IsPass==true &&  days.Day27?.IsWeekend == false) absentCount += 1;
        if (days.Day28?.IsPass==true &&  days.Day28?.IsWeekend == false) absentCount += 1;
        //if (days.Day29.IsPass && !days.Day29.IsWeekend) absentCount += 1;
        //if (days.Day30.IsPass && !days.Day30.IsWeekend) absentCount += 1;
        //if (days.Day31.IsPass && !days.Day31.IsWeekend) absentCount += 1;


        if ( days.Day1?.IsPass == false &&  days.Day1?.IsWeekend == false) payableDays += 1;
        if ( days.Day2?.IsPass == false &&  days.Day2?.IsWeekend == false) payableDays += 1;
        if ( days.Day3?.IsPass == false &&  days.Day3?.IsWeekend == false) payableDays += 1;
        if ( days.Day4?.IsPass == false &&  days.Day4?.IsWeekend == false) payableDays += 1;
        if ( days.Day5?.IsPass == false &&  days.Day5?.IsWeekend == false) payableDays += 1;
        if ( days.Day6?.IsPass == false &&  days.Day6?.IsWeekend == false) payableDays += 1;
        if ( days.Day7?.IsPass == false &&  days.Day7?.IsWeekend == false) payableDays += 1;
        if ( days.Day8?.IsPass == false &&  days.Day8?.IsWeekend == false) payableDays += 1;
        if ( days.Day9?.IsPass == false &&  days.Day9?.IsWeekend == false) payableDays += 1;
        if (days.Day10?.IsPass == false && days.Day10?.IsWeekend == false) payableDays += 1;
        if (days.Day11?.IsPass == false && days.Day11?.IsWeekend == false) payableDays += 1;
        if (days.Day12?.IsPass == false && days.Day12?.IsWeekend == false) payableDays += 1;
        if (days.Day13?.IsPass == false && days.Day13?.IsWeekend == false) payableDays += 1;
        if (days.Day14?.IsPass == false && days.Day14?.IsWeekend == false) payableDays += 1;
        if (days.Day15?.IsPass == false && days.Day15?.IsWeekend == false) payableDays += 1;
        if (days.Day16?.IsPass == false && days.Day16?.IsWeekend == false) payableDays += 1;
        if (days.Day17?.IsPass == false && days.Day17?.IsWeekend == false) payableDays += 1;
        if (days.Day18?.IsPass == false && days.Day18?.IsWeekend == false) payableDays += 1;
        if (days.Day19?.IsPass == false && days.Day19?.IsWeekend == false) payableDays += 1;
        if (days.Day20?.IsPass == false && days.Day20?.IsWeekend == false) payableDays += 1;
        if (days.Day21?.IsPass == false && days.Day21?.IsWeekend == false) payableDays += 1;
        if (days.Day22?.IsPass == false && days.Day22?.IsWeekend == false) payableDays += 1;
        if (days.Day23?.IsPass == false && days.Day23?.IsWeekend == false) payableDays += 1;
        if (days.Day24?.IsPass == false && days.Day24?.IsWeekend == false) payableDays += 1;
        if (days.Day25?.IsPass == false && days.Day25?.IsWeekend == false) payableDays += 1;
        if (days.Day26?.IsPass == false && days.Day26?.IsWeekend == false) payableDays += 1;
        if (days.Day27?.IsPass == false && days.Day27?.IsWeekend == false) payableDays += 1;
        if (days.Day28?.IsPass == false && days.Day28?.IsWeekend == false) payableDays += 1;
        ///if (!days.Day29.IsPass && !days.Day29.IsWeekend) payableDays += 1;
        ///if (!days.Day30.IsPass && !days.Day30.IsWeekend) payableDays += 1;
        ///if (!days.Day31.IsPass && !days.Day31.IsWeekend) payableDays += 1;


        return (absentCount, payableDays);

    }
}

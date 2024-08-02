using ModelsForSpechForms.Models;
using SpeechForms.ViewModels;
using System;

namespace SpeechForms.Extensions;



public class AttendanceGenerator
{
    static Random random = new Random();
    public static List<UserAttendanceTableVM> GenerateRandomAttendanceData(int userCount, int year, int month)
    {
       
        var attendanceList = new List<UserAttendanceTableVM>();
        var daysInMonth = DateTime.DaysInMonth(year, month);

        for (int i = 0; i < userCount; i++)
        {
            int id = i + 1;
            var user = new UserVM(id)
            {
                
                Num = random.Next(1000, 9999),
                LastName = $"Фамилия_{id}",
                Name = $"Имя_{id}",
                MiddleName = $"Отчество_{id}",
                DateOfBirth = new DateTime(random.Next(2018, 2022), random.Next(1, 12), random.Next(1, 28))
            };

            
            var monthAttendance = new AttendanceByDayLongVM
            {
                
                Month = (byte)month,
                Day1 = GenerateRandomDay(),
                Day2 = GenerateRandomDay(),
                Day3 = GenerateRandomDay(),
                Day4 = GenerateRandomDay(),
                Day5 = GenerateRandomDay(),
                Day6 = GenerateRandomDay(),
                Day7 = GenerateRandomDay(),
                Day8 = GenerateRandomDay(),
                Day9 = GenerateRandomDay(),
                Day10 = GenerateRandomDay(),
                Day11 = GenerateRandomDay(),
                Day12 = GenerateRandomDay(),
                Day13 = GenerateRandomDay(),
                Day14 = GenerateRandomDay(),
                Day15 = GenerateRandomDay(),
                Day16 = GenerateRandomDay(),
                Day17 = GenerateRandomDay(),
                Day18 = GenerateRandomDay(),
                Day19 = GenerateRandomDay(),
                Day20 = GenerateRandomDay(),
                Day21 = GenerateRandomDay(),
                Day22 = GenerateRandomDay(),
                Day23 = GenerateRandomDay(),
                Day24 = GenerateRandomDay(),
                Day25 = GenerateRandomDay(),
                Day26 = GenerateRandomDay(),
                Day27 = GenerateRandomDay(),
                Day28 = GenerateRandomDay(),
                Day29 = GenerateRandomDay(),
                Day30 = GenerateRandomDay(),
                Day31 = GenerateRandomDay()
            };

            var userAttendance = new UserAttendanceTableVM
            {
                IsCalculation = true,
                User = user,
                MonthAttendanceDays = monthAttendance
            };

            userAttendance.IsCalculation = false;
            attendanceList.Add(userAttendance);
        }

        return attendanceList;
    }

    private static DayVM GenerateRandomDay()
    {

        return new DayVM
        {
            IsPass = random.Next(0, 2) == 1,
            IsWeekend = random.Next(0, 7) == 6 || random.Next(0, 7) == 0 // Пример рандомизации выходных
        };
    }
}


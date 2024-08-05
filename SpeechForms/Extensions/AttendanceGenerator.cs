using ModelsForSpechForms.Models;
using SpeechForms.Bl;
using SpeechForms.ViewModels;
using System;

namespace SpeechForms.Extensions;



public class AttendanceGenerator
{
    static Random random = new Random();
    public static List<IUserAttendanceTable> GenerateRandomAttendanceData(int userCount, int year, int month)
    {
       
        var attendanceList = new List<IUserAttendanceTable>();
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

            
            var monthAttendance = new AttendanceByDayBaseVM
            {
                
                Month = (byte)month,
                //Day1 = false,//GenerateRandomDay(),
                //Day2 = false,//GenerateRandomDay(),
                //Day3 = false,//GenerateRandomDay(),
                //Day4 = false,//GenerateRandomDay(),
                //Day5 = false,//GenerateRandomDay(),
                Day6 = true,
                Day7 = true,
                //Day8 = false,//GenerateRandomDay(),
                //Day9 = false,//GenerateRandomDay(),
                //Day10 =false,// GenerateRandomDay(),
                //Day11 =false,// GenerateRandomDay(),
                //Day12 =false,// GenerateRandomDay(),
                //Day13 =false,// GenerateRandomDay(),
                //Day14 =false,// GenerateRandomDay(),
                //Day15 = false,// GenerateRandomDay(),
                 Day16 = true,
                 Day17 = true,
                //Day18 =false,//GenerateRandomDay(),
                //Day19 =false,//GenerateRandomDay(),
                //Day20 =false,//GenerateRandomDay(),
                //Day21 =false,//GenerateRandomDay(),
                //Day22 =false,//GenerateRandomDay(),
                //Day23 =false,//GenerateRandomDay(),
                //Day24 =false,//GenerateRandomDay(),
                //Day25 = false,//GenerateRandomDay(),
                Day26 = true,
                Day27 = true,
                //Day28 =false,// GenerateRandomDay(),
                //Day29 =false,// GenerateRandomDay(),
                //Day30 =false,// GenerateRandomDay(),
                //Day31 = false,// GenerateRandomDay(),

                IsWeekend6  = true,
                IsWeekend7  = true,
                IsWeekend16 = true,
                IsWeekend17 = true,
                IsWeekend26 = true,
                IsWeekend27 = true,


            };

            var userAttendance = new UserAttendanceTableVM
            {               
                User = user,
                MonthAttendanceDays = monthAttendance
            };


            var res = Calculate.CalculateAbsentDays(userAttendance.MonthAttendanceDays);
            userAttendance.MonthAttendanceDays.AbsentDays = res.absentCount;
            userAttendance.MonthAttendanceDays.PayableDays = res.payableDays;

            attendanceList.Add(userAttendance);
        }

        return attendanceList;
    }

    private static bool GenerateRandomDay()
    {

        return random.Next(0, 2) == 1;
    }
}


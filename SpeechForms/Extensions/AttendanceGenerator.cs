using Microsoft.Extensions.DependencyInjection;
using SpeechForms.Bl;
using SpeechForms.ViewModels;

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
                
                Num = id,
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

    public static IUserAttendanceTable GenerateDefault()
    {

        var ser = App.Services.GetRequiredService<MainVM>();

        var tables = ser.UserAttendanceTables;
        var idMax = tables.Max(x => x.User.Id)+1;


        IUserAttendanceTable table = new UserAttendanceTableVM()
        {
            Guid = Guid.NewGuid(),
            IsCalculation = false,
            User = new UserVM() {Id =  idMax, Num = idMax},
            MonthAttendanceDays = new AttendanceByDayBaseVM() { }
        };

        return table;
    }


    private static bool GenerateRandomDay()
    {

        return random.Next(0, 2) == 1;
    }


    public static List<IUserAttendanceTable> GetAttendanceData()
    {
        var attendanceList = new List<IUserAttendanceTable>();

        var tables = JsonHelper.DeserializeFromJsonAsync(Settings.PathFileUsers);

        if (tables is null) return attendanceList;

        foreach (var table in tables)
        {
            

            var userJs = table.User;
            var daysJs = table.MonthAttendanceDays;

            int id = userJs.Id;

            var user = new UserVM(id)
            {
                Num         = userJs.Num,
                LastName    = userJs.LastName,
                Name        = userJs.Name,
                MiddleName  = userJs.MiddleName,
                DateOfBirth = userJs.DateOfBirth,
            };


            var monthAttendance = new AttendanceByDayBaseVM()
            {
                Month = daysJs.Month,
                Day1 = daysJs.Day1,
                Day2 = daysJs.Day2,
                Day3 = daysJs.Day3,
                Day4 = daysJs.Day4,
                Day5 = daysJs.Day5,
                Day6 = daysJs.Day6,
                Day7 = daysJs.Day7,
                Day8 = daysJs.Day8,
                Day9 = daysJs.Day9,
                Day10 = daysJs.Day10,
                Day11 = daysJs.Day11,
                Day12 = daysJs.Day12,
                Day13 = daysJs.Day13,
                Day14 = daysJs.Day14,
                Day15 = daysJs.Day15,
                Day16 = daysJs.Day16,
                Day17 = daysJs.Day17,
                Day18 = daysJs.Day18,
                Day19 = daysJs.Day19,
                Day20 = daysJs.Day20,
                Day21 = daysJs.Day21,
                Day22 = daysJs.Day22,
                Day23 = daysJs.Day23,
                Day24 = daysJs.Day24,
                Day25 = daysJs.Day25,
                Day26 = daysJs.Day26,
                Day27 = daysJs.Day27,
                Day28 = daysJs.Day28,
                Day29 = daysJs.Day29,
                Day30 = daysJs.Day30,
                Day31 = daysJs.Day31,

                IsWeekend1 = daysJs.IsWeekend1,
                IsWeekend2 = daysJs.IsWeekend2,
                IsWeekend3 = daysJs.IsWeekend3,
                IsWeekend4 = daysJs.IsWeekend4,
                IsWeekend5 = daysJs.IsWeekend5,
                IsWeekend6 = daysJs.IsWeekend6,
                IsWeekend7 = daysJs.IsWeekend7,
                IsWeekend8 = daysJs.IsWeekend8,
                IsWeekend9 = daysJs.IsWeekend9,
                IsWeekend10 = daysJs.IsWeekend10,
                IsWeekend11 = daysJs.IsWeekend11,
                IsWeekend12 = daysJs.IsWeekend12,
                IsWeekend13 = daysJs.IsWeekend13,
                IsWeekend14 = daysJs.IsWeekend14,
                IsWeekend15 = daysJs.IsWeekend15,
                IsWeekend16 = daysJs.IsWeekend16,
                IsWeekend17 = daysJs.IsWeekend17,
                IsWeekend18 = daysJs.IsWeekend18,
                IsWeekend19 = daysJs.IsWeekend19,
                IsWeekend20 = daysJs.IsWeekend20,
                IsWeekend21 = daysJs.IsWeekend21,
                IsWeekend22 = daysJs.IsWeekend22,
                IsWeekend23 = daysJs.IsWeekend23,
                IsWeekend24 = daysJs.IsWeekend24,
                IsWeekend25 = daysJs.IsWeekend25,
                IsWeekend26 = daysJs.IsWeekend26,
                IsWeekend27 = daysJs.IsWeekend27,
                IsWeekend28 = daysJs.IsWeekend28,
                IsWeekend29 = daysJs.IsWeekend29,
                IsWeekend30 = daysJs.IsWeekend30,
                IsWeekend31 = daysJs.IsWeekend31,

                AbsentDays = daysJs.AbsentDays,
                PayableDays = daysJs.PayableDays,
                Description = daysJs.Description
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

    //
}


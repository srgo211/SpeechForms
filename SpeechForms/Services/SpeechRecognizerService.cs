using Microsoft.Extensions.DependencyInjection;
using SpeechForms.ViewModels;
using SpeechRecognitionLibrary;
using System.Diagnostics;

namespace SpeechForms.Services;

public  class SpeechRecognizerService
{
    private SpeechRecognizer recognizer;
    private readonly Dictionary<string, int> numberWords;

    

    public SpeechRecognizerService()
    {
        this.numberWords = AiSpeechText.GenerateNumberWordsDictionary();
    }


    public void RunPass(string pathModel)
    {
       
       

        recognizer = new SpeechRecognizer(pathModel);
        recognizer.OnRecognized += words =>
        {
            if (!string.IsNullOrEmpty(words))
            {

                var res = words
                        .Replace("ё", "е")
                        .Replace("й", "и");
                
                var numbers = AiSpeechText.ConvertWordsToNumbers(words, numberWords);
                var ser = App.Services.GetRequiredService<MainVM>();
                if (numbers is not null && numbers.Count > 0)
                {
                    
                    SetNumber(ser, numbers);

                    res = string.Join(", ", numbers);
                }

                App.Current.Dispatcher.Invoke(() =>
                {
                    ser.RecognizedWords.Add(res);
                });
            }
        };
    }


    public void RunWeek(string pathModel)
    {



        recognizer = new SpeechRecognizer(pathModel);
        recognizer.OnRecognized += words =>
        {
            if (!string.IsNullOrEmpty(words))
            {

                var res = words
                    .Replace("ё", "е")
                    .Replace("й", "и");

                var numbers = AiSpeechText.ConvertWordsToNumbers(words, numberWords);
                var ser = App.Services.GetRequiredService<MainVM>();
                if (numbers is not null && numbers.Count > 0)
                {

                    SetWeek(ser, numbers);

                    res = string.Join(", ", numbers);
                }

                App.Current.Dispatcher.Invoke(() =>
                {
                    ser.RecognizedWords.Add(res);
                });
            }
        };
    }



    private void SetNumber(MainVM ser, List<int> numbers)
    {
        if(ser.SelectedTable is null || numbers?.Count == 0) return;
        Debug.WriteLine(ser.SelectedTable.User.Id);

        var day = ser.SelectedTable.MonthAttendanceDays;
        foreach(int number in numbers) 
        { 
        
            switch(number) 
            {
                case 1:   day.Day1 = true; break;
                case 2:   day.Day2 = true; break;
                case 3:   day.Day3 = true; break;
                case 4:   day.Day4 = true; break;
                case 5:   day.Day5 = true; break;
                case 6:   day.Day6 = true; break;
                case 7:   day.Day7 = true; break;
                case 8:   day.Day8 = true; break;
                case 9:   day.Day9 = true; break;
                case 10: day.Day10 = true; break;
                case 11: day.Day11 = true; break;
                case 12: day.Day12 = true; break;
                case 13: day.Day13 = true; break;
                case 14: day.Day14 = true; break;
                case 15: day.Day15 = true; break;
                case 16: day.Day16 = true; break;
                case 17: day.Day17 = true; break;
                case 18: day.Day18 = true; break;
                case 19: day.Day19 = true; break;
                case 20: day.Day20 = true; break;
                case 21: day.Day21 = true; break;
                case 22: day.Day22 = true; break;
                case 23: day.Day23 = true; break;
                case 24: day.Day24 = true; break;
                case 25: day.Day25 = true; break;
                case 26: day.Day26 = true; break;
                case 27: day.Day27 = true; break;
                case 28: day.Day28 = true; break;
                case 29: day.Day29 = true; break;
                case 30: day.Day30 = true; break;
                case 31: day.Day31 = true; break;
                    default: return;

            }
        
        
        }



    }

    private void SetWeek(MainVM ser, List<int> numbers)
    {
        if (ser.UserAttendanceTables is null || numbers?.Count == 0) return;
       
        

        
        foreach (int number in numbers)
        {

            foreach (var tables in ser.UserAttendanceTables)
            { 
                var day = tables?.MonthAttendanceDays;

                if(day is null) continue;

                switch (number)
                {
                    case 1:  day.IsWeekend1  = true; day.Day1  = true; break;
                    case 2:  day.IsWeekend2  = true; day.Day2  = true; break;
                    case 3:  day.IsWeekend3  = true; day.Day3  = true; break;
                    case 4:  day.IsWeekend4  = true; day.Day4  = true; break;
                    case 5:  day.IsWeekend5  = true; day.Day5  = true; break;
                    case 6:  day.IsWeekend6  = true; day.Day6  = true; break;
                    case 7:  day.IsWeekend7  = true; day.Day7  = true; break;
                    case 8:  day.IsWeekend8  = true; day.Day8  = true; break;
                    case 9:  day.IsWeekend9  = true; day.Day9  = true; break;
                    case 10: day.IsWeekend10 = true; day.Day10 = true; break;
                    case 11: day.IsWeekend11 = true; day.Day11 = true; break;
                    case 12: day.IsWeekend12 = true; day.Day12 = true; break;
                    case 13: day.IsWeekend13 = true; day.Day13 = true; break;
                    case 14: day.IsWeekend14 = true; day.Day14 = true; break;
                    case 15: day.IsWeekend15 = true; day.Day15 = true; break;
                    case 16: day.IsWeekend16 = true; day.Day16 = true; break;
                    case 17: day.IsWeekend17 = true; day.Day17 = true; break;
                    case 18: day.IsWeekend18 = true; day.Day18 = true; break;
                    case 19: day.IsWeekend19 = true; day.Day19 = true; break;
                    case 20: day.IsWeekend20 = true; day.Day20 = true; break;
                    case 21: day.IsWeekend21 = true; day.Day21 = true; break;
                    case 22: day.IsWeekend22 = true; day.Day22 = true; break;
                    case 23: day.IsWeekend23 = true; day.Day23 = true; break;
                    case 24: day.IsWeekend24 = true; day.Day24 = true; break;
                    case 25: day.IsWeekend25 = true; day.Day25 = true; break;
                    case 26: day.IsWeekend26 = true; day.Day26 = true; break;
                    case 27: day.IsWeekend27 = true; day.Day27 = true; break;
                    case 28: day.IsWeekend28 = true; day.Day28 = true; break;
                    case 29: day.IsWeekend29 = true; day.Day29 = true; break;
                    case 30: day.IsWeekend30 = true; day.Day30 = true; break;
                    case 31: day.IsWeekend31 = true; day.Day31 = true; break;
                    default: return;

                }

            }




        }



    }


    public void StartRecognition()
    {
        recognizer.Start();
    }

    public void StopRecognition()
    {
        recognizer?.Stop();
        recognizer?.Dispose();
    }


}

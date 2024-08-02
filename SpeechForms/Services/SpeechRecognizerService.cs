using SpeechRecognitionLibrary;
using System.Collections.ObjectModel;
using SpeechForms.Extensions;
using SpeechForms.ViewModels;
using Microsoft.Extensions.DependencyInjection;

namespace SpeechForms.Services;

public  class SpeechRecognizerService
{
    private SpeechRecognizer recognizer;
    private readonly Dictionary<string, int> numberWords;

    

    public SpeechRecognizerService()
    {
        this.numberWords = AiSpeechText.GenerateNumberWordsDictionary();
    }


    public void Run(string pathModel)
    {
       
        var ser = App.Services.GetRequiredService<MainVM>();

        recognizer = new SpeechRecognizer(pathModel);
        recognizer.OnRecognized += words =>
        {
            if (!string.IsNullOrEmpty(words))
            {

                var res = words
                        .Replace("ё", "е")
                        .Replace("й", "и");
                
                var numbers = AiSpeechText.ConvertWordsToNumbers(words, numberWords);

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

    private void SetNumber(MainVM ser, List<int> numbers)
    {
        if(ser.SelectedTable is null || numbers?.Count == 0) return;
        var day = ser.SelectedTable.MonthAttendanceDays;
        foreach(int number in numbers) 
        { 
        
            switch(number) 
            {
                case 1: day.Day1.IsPass = true; break;
                case 2: day.Day2.IsPass = true; break;
                case 3: day.Day3.IsPass = true; break;
                case 4: day.Day4.IsPass = true; break;
                case 5: day.Day5.IsPass = true; break;
                case 6: day.Day6.IsPass = true; break;
                case 7: day.Day7.IsPass = true; break;
                case 8: day.Day8.IsPass = true; break;
                case 9: day.Day9.IsPass = true; break;
                case 10: day.Day10.IsPass = true; break;
                case 11: day.Day11.IsPass = true; break;
                case 12: day.Day12.IsPass = true; break;
                case 13: day.Day13.IsPass = true; break;
                case 14: day.Day14.IsPass = true; break;
                case 15: day.Day15.IsPass = true; break;
                case 16: day.Day16.IsPass = true; break;
                case 17: day.Day17.IsPass = true; break;
                case 18: day.Day18.IsPass = true; break;
                case 19: day.Day19.IsPass = true; break;
                case 20: day.Day20.IsPass = true; break;
                case 21: day.Day21.IsPass = true; break;
                case 22: day.Day22.IsPass = true; break;
                case 23: day.Day23.IsPass = true; break;
                case 24: day.Day24.IsPass = true; break;
                case 25: day.Day25.IsPass = true; break;
                case 26: day.Day26.IsPass = true; break;
                case 27: day.Day27.IsPass = true; break;
                case 28: day.Day28.IsPass = true; break;
                case 29: day.Day29.IsPass = true; break;
                case 30: day.Day30.IsPass = true; break;
                case 31: day.Day31.IsPass = true; break;
                    default: return;

            }
        
        
        }



    }

    public void StartRecognition()
    {
        recognizer.Start();
    }

    public void StopRecognition()
    {
        recognizer.Stop();
    }


}

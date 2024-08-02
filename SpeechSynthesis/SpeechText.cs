using System.Speech.Synthesis;

namespace SpeechSynthesis;

public class SpeechText : IDisposable
{
    private SpeechSynthesizer synthesizer;
    private bool isDisposed = false;
    public SpeechText()
    {
        this.synthesizer = new SpeechSynthesizer();
    }


   

    public void Start(string text, byte rate = 0, byte volume = 100)
    {
        if (isDisposed)
        {
            this.synthesizer = new SpeechSynthesizer();
            isDisposed = false;
        }


        // Устанавливаем голос (по умолчанию используется системный голос)
        synthesizer.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult);

        // Устанавливаем скорость речи (от -10 до 10, 0 по умолчанию)
        synthesizer.Rate = rate;

        // Устанавливаем громкость (от 0 до 100)
        synthesizer.Volume = volume;

        // Запускаем синтез речи
        synthesizer.SpeakSsml(text);
    }

    

    public void Stop() => Dispose();


    public void Dispose()
    {
        if (!isDisposed)
        {
            this.synthesizer?.Dispose();
            isDisposed = true;
        }
    }

}

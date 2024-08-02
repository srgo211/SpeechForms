using NAudio.Wave;
using System.Text.Json;
using Vosk;

namespace SpeechRecognitionLibrary;

public class SpeechRecognizer : IDisposable
{
    private Model model;
    private VoskRecognizer recognizer;
    private WaveInEvent waveIn;
    private bool isDisposed = false;

    public event Action<string> OnRecognized;
    public event Action<string> OnFinalResult;

    public SpeechRecognizer(string modelPath)
    {
        model = new Model(modelPath);
        recognizer = new VoskRecognizer(model, 16000.0f);
    }

    public void Start()
    {
        waveIn = new WaveInEvent
        {
            WaveFormat = new WaveFormat(16000, 1)
        };

        waveIn.DataAvailable += (s, a) =>
        {
            if (recognizer.AcceptWaveform(a.Buffer, a.BytesRecorded))
            {
                var result = recognizer.Result();
                var recognizedWords = ExtractWordsFromResult(result);
                OnRecognized?.Invoke(recognizedWords);
            }
        };

        waveIn.RecordingStopped += (s, a) =>
        {
            var finalResult = recognizer.FinalResult();
            var finalWords = ExtractWordsFromResult(finalResult);
            OnFinalResult?.Invoke(finalWords);
        };

        waveIn.StartRecording();
    }

    public void Stop()=> waveIn?.StopRecording();


    private string ExtractWordsFromResult(string result)
    {
        using (JsonDocument doc = JsonDocument.Parse(result))
        {
            JsonElement root = doc.RootElement;
            if (root.TryGetProperty("text", out JsonElement textElement))
            {
                return textElement.GetString();
            }
        }
        return string.Empty;
    }


    public void Dispose()
    {
        if (!isDisposed)
        {
            recognizer?.Dispose();
            model?.Dispose();
            waveIn?.Dispose();
            isDisposed = true;
        }
    }
}

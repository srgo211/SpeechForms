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
    private bool isRecordingStopped = false;
    private readonly object lockObj = new object();

    public event Action<string> OnRecognized;
    public event Action<string> OnFinalResult;

    public SpeechRecognizer(string modelPath)
    {
        model = new Model(modelPath);
        recognizer = new VoskRecognizer(model, 16000.0f);
    }

    public void Start()
    {
        lock (lockObj)
        {
            if (isDisposed) throw new ObjectDisposedException(nameof(SpeechRecognizer));

            waveIn = new WaveInEvent
            {
                WaveFormat = new WaveFormat(16000, 1)
            };

            waveIn.DataAvailable += (s, a) =>
            {
                lock (lockObj)
                {
                    if (!isDisposed && recognizer.AcceptWaveform(a.Buffer, a.BytesRecorded))
                    {
                        var result = recognizer.Result();
                        var recognizedWords = ExtractWordsFromResult(result);
                        OnRecognized?.Invoke(recognizedWords);
                    }
                }
            };

            waveIn.RecordingStopped += (s, a) =>
            {
                lock (lockObj)
                {
                    if (!isDisposed)
                    {
                        isRecordingStopped = true;
                        var finalResult = recognizer.FinalResult();
                        var finalWords = ExtractWordsFromResult(finalResult);
                        OnFinalResult?.Invoke(finalWords);
                    }
                }
            };

            waveIn.StartRecording();
        }
    }

    public void Stop()
    {
        lock (lockObj)
        {
            if (waveIn != null && !isRecordingStopped)
            {
                waveIn.StopRecording();
                isRecordingStopped = true;
            }
        }
    }

    private string ExtractWordsFromResult(string result)
    {
        if (string.IsNullOrEmpty(result)) return string.Empty;

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
        lock (lockObj)
        {
            if (!isDisposed)
            {
                if (waveIn != null)
                {
                    if (!isRecordingStopped)
                    {
                        waveIn.StopRecording();
                    }

                    waveIn.Dispose();
                    waveIn = null;
                }

                recognizer?.Dispose();
                recognizer = null;

                model?.Dispose();
                model = null;

                isDisposed = true;
            }
        }
    }
}



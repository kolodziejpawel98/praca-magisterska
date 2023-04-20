using UnityEngine;

public class Timer : MonoBehaviour
{
    private static long startTimeMs;

    public static void StartTimer()
    {
        ResetTimer();
        startTimeMs = System.DateTime.Now.Ticks / System.TimeSpan.TicksPerMillisecond;
    }

    public static long StopTimer()
    {
        long stopTimeMs = System.DateTime.Now.Ticks / System.TimeSpan.TicksPerMillisecond;
        return stopTimeMs - startTimeMs;
    }

    public static float GetElapsedTimeInSeconds()
    {
        long elapsedMilliseconds = StopTimer();
        float elapsedTimeSeconds = (float)elapsedMilliseconds / 1000f;
        return elapsedTimeSeconds;
    }

    public static void ResetTimer()
    {
        startTimeMs = System.DateTime.Now.Ticks / System.TimeSpan.TicksPerMillisecond;
    }

}
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Finish-line trigger for the player's car. Records the lap time, counts the lap and
/// re-arms the half-way checkpoint, so a lap only counts after driving the whole track.
/// </summary>
public class LapComplete : MonoBehaviour
{
    /// <summary>Laps needed to finish a race.</summary>
    public const int RaceLaps = 1;

    public static int lapsDone = 0;

    public GameObject LapCompleteTrig;
    public GameObject HalfLapTrig;

    public GameObject MinuteDisplay;
    public GameObject SecDisplay;
    public GameObject MilliDisplay;
    public GameObject LapCounter;
    public GameObject RaceFinish;

    /// <summary>Clears every car's lap count, ready for a new race.</summary>
    public static void ResetAllLaps()
    {
        lapsDone = 0;
        LapCompleteAI.lapsDoneAI = 0;
        LapCompletesecondAI.lapsDonesecondAI = 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!other.gameObject.CompareTag("playercar"))
        {
            return;
        }

        lapsDone += 1;

        MinuteDisplay.GetComponent<Text>().text = LapTimeManager.FormatMinutes(LapTimeManager.MintCount);
        SecDisplay.GetComponent<Text>().text = LapTimeManager.FormatSeconds(LapTimeManager.SecCount);
        MilliDisplay.GetComponent<Text>().text = LapTimeManager.FormatTenths(LapTimeManager.MilliCount);
        LapCounter.GetComponent<Text>().text = lapsDone.ToString();
        LapTimeManager.ResetClock();

        HalfLapTrig.SetActive(true);
        LapCompleteTrig.SetActive(false);

        if (lapsDone == RaceLaps)
        {
            RaceFinish.SetActive(true);
        }
    }
}

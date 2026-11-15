using UnityEngine;

/// <summary>Finish-line trigger for the AI car tagged "AIcar". Counts its laps the same way as the player's.</summary>
public class LapCompleteAI : MonoBehaviour
{
    public static int lapsDoneAI = 0;

    public GameObject LapCompleteTrigAI;
    public GameObject HalfLapTrigAI;
    public GameObject RaceFinish;

    private void OnTriggerEnter(Collider other)
    {
        if (!other.gameObject.CompareTag("AIcar"))
        {
            return;
        }

        lapsDoneAI += 1;
        HalfLapTrigAI.SetActive(true);
        LapCompleteTrigAI.SetActive(false);

        if (lapsDoneAI == LapComplete.RaceLaps)
        {
            RaceFinish.SetActive(true);
        }
    }
}

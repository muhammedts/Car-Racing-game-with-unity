using UnityEngine;

/// <summary>Finish-line trigger for the AI car tagged "AIsecondcar". Counts its laps the same way as the player's.</summary>
public class LapCompletesecondAI : MonoBehaviour
{
    public static int lapsDonesecondAI = 0;

    public GameObject LapCompleteTrigAI;
    public GameObject HalfLapTrigAI;
    public GameObject RaceFinish;

    private void OnTriggerEnter(Collider other)
    {
        if (!other.gameObject.CompareTag("AIsecondcar"))
        {
            return;
        }

        lapsDonesecondAI += 1;
        HalfLapTrigAI.SetActive(true);
        LapCompleteTrigAI.SetActive(false);

        if (lapsDonesecondAI == LapComplete.RaceLaps)
        {
            RaceFinish.SetActive(true);
        }
    }
}

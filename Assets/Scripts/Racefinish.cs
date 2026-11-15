using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

/// <summary>
/// Finish line on the town track, which has two AI opponents. The first car to complete
/// the race decides the result: the player wins, or either AI car wins and the player loses.
/// </summary>
public class Racefinish : MonoBehaviour
{
    public GameObject Mycar;
    public GameObject carAI1;
    public GameObject carAI2;

    public GameObject FinishCam;
    public GameObject Cam;
    public GameObject TimerMange;
    public GameObject end;
    public GameObject win;
    public GameObject lose;
    public GameObject PlayAgain;
    public GameObject MAinMenu;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("playercar") && LapComplete.lapsDone == LapComplete.RaceLaps)
        {
            EndRace(true);
        }
        else if (other.gameObject.CompareTag("AIcar") && LapCompleteAI.lapsDoneAI == LapComplete.RaceLaps)
        {
            EndRace(false);
        }
        else if (other.gameObject.CompareTag("AIsecondcar") && LapCompletesecondAI.lapsDonesecondAI == LapComplete.RaceLaps)
        {
            EndRace(false);
        }
    }

    private void EndRace(bool playerWon)
    {
        // Briefly deactivating the cars stops them in place; the player's controls stay off.
        Mycar.SetActive(false);
        carAI1.SetActive(false);
        carAI2.SetActive(false);
        Mycar.GetComponent<CarController>().enabled = false;
        Mycar.GetComponent<CarUserControl>().enabled = false;
        Mycar.SetActive(true);
        carAI1.SetActive(true);
        carAI2.SetActive(true);

        FinishCam.SetActive(true);
        Cam.SetActive(false);

        end.SetActive(true);
        (playerWon ? win : lose).SetActive(true);
        PlayAgain.SetActive(true);
        MAinMenu.SetActive(true);

        TimerMange.SetActive(false);
        LapTimeManager.ResetClock();
        LapComplete.ResetAllLaps();
    }
}

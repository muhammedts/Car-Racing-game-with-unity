using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

/// <summary>
/// Finish line on the smaller track, which has one AI opponent: the player wins by reaching it
/// first, and loses if anything else gets there first.
/// (The class keeps its original name because the scene refers to it by this name.)
/// </summary>
public class NewBehaviourScript : MonoBehaviour
{
    public GameObject Mycar;
    public GameObject carAI;

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
        bool playerWon = other.gameObject.CompareTag("playercar");

        // Briefly deactivating the cars stops them in place; the player's controls stay off.
        Mycar.SetActive(false);
        carAI.SetActive(false);
        Mycar.GetComponent<CarController>().enabled = false;
        Mycar.GetComponent<CarUserControl>().enabled = false;
        Mycar.SetActive(true);
        carAI.SetActive(true);

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

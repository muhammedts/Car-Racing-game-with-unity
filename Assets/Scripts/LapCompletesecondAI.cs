using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Vehicles.Car;

public class LapCompletesecondAI : MonoBehaviour {
        public GameObject LapCompleteTrigAI;
    public GameObject HalfLapTrigAI;

  
    public GameObject RaceFinish;
    public GameObject Player;
    public GameObject Ai;
    public GameObject Mycar;
    public GameObject firstAIcar;
    public GameObject secondAIcar;
    public GameObject end;
    public GameObject win;
    public GameObject lose;
    public GameObject PlayAgain;
    public GameObject FinishCam;
    public GameObject Cam;
    public GameObject TimerMange;

    public static int lapsDonesecondAI=0;


    public float RawTime;

    private void OnTriggerEnter(Collider other)
    {
        
       
        
        if (other.gameObject.CompareTag("AIsecondcar"))
        {
            Debug.Log(other.gameObject.tag);
            lapsDonesecondAI += 1;
            HalfLapTrigAI.SetActive(true);
            LapCompleteTrigAI.SetActive(false);


        }


        if (lapsDonesecondAI == 1)
        {
            Mycar.SetActive(false);
            CarController.m_Topspeed = 0.0f;
            Mycar.GetComponent<CarController>().enabled = false;
            Mycar.GetComponent<CarUserControl>().enabled = false;
            Mycar.GetComponent<CarAudio>().enabled = false;

            Mycar.SetActive(true);

            FinishCam.SetActive(true);
            Cam.SetActive(false);

            end.SetActive(true);
            lose.SetActive(true);
            PlayAgain.SetActive(true);
            TimerMange.SetActive(false);
            LapTimeManager.MintCount = 0;
            LapTimeManager.SecCount = 0;
            LapTimeManager.MilliCount = 0;
        }
    }
}

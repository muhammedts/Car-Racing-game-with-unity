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

    public static int lapsDonesecondAI = 0;


    public float RawTime;

    private void OnTriggerEnter(Collider other)
    {



        if (other.gameObject.CompareTag("AIsecondcar") )
        {
            Debug.Log(other.gameObject.tag);
            lapsDonesecondAI += 1;
            HalfLapTrigAI.SetActive(true);
            LapCompleteTrigAI.SetActive(false);


        }


        if (lapsDonesecondAI == 1)
        {
            RaceFinish.SetActive(true);
        }
    }
}

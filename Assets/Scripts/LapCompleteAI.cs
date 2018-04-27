using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapCompleteAI : MonoBehaviour {
        public GameObject LapCompleteTrigAI;
    public GameObject HalfLapTrigAI;

  
    public GameObject RaceFinish;
    public GameObject Player;
    public GameObject Ai;

    public static int lapsDoneAI=0;


    public float RawTime;

    private void OnTriggerEnter(Collider other)
    {
        
       
        
        if (other.gameObject.CompareTag("AIcar"))
        {
            Debug.Log(other.gameObject.tag);
            lapsDoneAI += 1;
            HalfLapTrigAI.SetActive(true);
            LapCompleteTrigAI.SetActive(false);


        }


        if (lapsDoneAI == 1)
        {
            RaceFinish.SetActive(true);
        }
    }
}

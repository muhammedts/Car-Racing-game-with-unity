using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfPointTargger : MonoBehaviour {

    // Use this for initialization
    public GameObject LapCompleteTrig;
    public GameObject HalfLapTrig;
    void onTriggerEnter()
    {
        LapCompleteTrig.SetActive(true);
        HalfLapTrig.SetActive(false);
        

    }
}

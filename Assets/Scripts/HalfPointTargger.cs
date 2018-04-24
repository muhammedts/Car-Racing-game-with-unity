using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfPointTargger : MonoBehaviour {

    // Use this for initialization
    public GameObject LapCompleteTrig;
    public GameObject HalfLapTrig;
    private void OnTriggerEnter(Collider other)
    {
        LapCompleteTrig.SetActive(true);
        HalfLapTrig.SetActive(false);
    }
}

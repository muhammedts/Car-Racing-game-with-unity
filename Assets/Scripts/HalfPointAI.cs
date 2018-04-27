using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfPointAI : MonoBehaviour {

    public GameObject LapCompleteTrigAI;
    public GameObject HalfLapTrigAI;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "AIcar")
        {
            Debug.Log("AIhalf");
            LapCompleteTrigAI.SetActive(true);
            HalfLapTrigAI.SetActive(false);
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfPointsecondAI : MonoBehaviour {

    public GameObject LapCompleteTrigsecondAI;
    public GameObject HalfLapTrigsecondAI;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "AIsecondcar")
        {
            Debug.Log("secondAIhalf");
            LapCompleteTrigsecondAI.SetActive(true);
            HalfLapTrigsecondAI.SetActive(false);
        }

    }
}

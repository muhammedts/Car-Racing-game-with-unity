using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfPointTrig : MonoBehaviour {

    public GameObject LapCompleteTrig;
    public GameObject HalfLapTrig;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "playercar")
        {
            Debug.Log("playerhalf");
            LapCompleteTrig.SetActive(true);
            HalfLapTrig.SetActive(false);
        }
       
    }

}

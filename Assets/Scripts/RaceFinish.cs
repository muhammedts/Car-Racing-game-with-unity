using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class RaceFinish : MonoBehaviour {
    public GameObject Mycar;
    public GameObject CompleteTrig;

    private void OnTriggerEnter(Collider other)
    {
        
            if (other.gameObject.CompareTag("playercar"))
        {
            Debug.Log("youWin");
            Mycar.SetActive(false);
            CompleteTrig.SetActive(false);
            CarController.m_Topspeed = 0.0f;
            Mycar.GetComponent<CarController>().enabled = false;
            Mycar.GetComponent<CarUserControl>().enabled = false;
        }
        else
        {
            Debug.Log("Loserrrrrrrrrrrrrrrrr");

            Mycar.SetActive(false);
            CompleteTrig.SetActive(false);
            CarController.m_Topspeed = 0.0f;
            Mycar.GetComponent<CarController>().enabled = false;
            Mycar.GetComponent<CarUserControl>().enabled = false;
        }

    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

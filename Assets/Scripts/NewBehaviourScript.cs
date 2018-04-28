using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;


public class NewBehaviourScript : MonoBehaviour {

    // Use this for initialization
    public GameObject Mycar;
    public GameObject FinishCam;
    public GameObject Cam;
    //public GameObject TimerMange;
    public GameObject end;
    public GameObject win;
    public GameObject lose;
    public GameObject PlayAgain;
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("playercar"))
        {
            Debug.Log("Winner");
            Mycar.SetActive(false);
            CarController.m_Topspeed = 0.0f;
            Mycar.GetComponent<CarController>().enabled = false;
            Mycar.GetComponent<CarUserControl>().enabled = false;
            // Mycar.SetActive(true);

            // FinishCam.SetActive(true);
            // Cam.SetActive(false);


            //end.SetActive(true);
            //win.SetActive(true);
            // PlayAgain.SetActive(true);
            /*TimerMange.SetActive(false);
            LapTimeManager.MintCount = 0;
            LapTimeManager.SecCount = 0;
            LapTimeManager.MilliCount = 0;*/

        }
        else
        {
            Debug.Log("GameOver");
            Mycar.SetActive(false);
            CarController.m_Topspeed = 0.0f;
            Mycar.GetComponent<CarController>().enabled = false;
            Mycar.GetComponent<CarUserControl>().enabled = false;
            // Mycar.SetActive(true);

            //  FinishCam.SetActive(true);
            // Cam.SetActive(false);

            //end.SetActive(true);
            //lose.SetActive(true);
            //PlayAgain.SetActive(true);
            /*  TimerMange.SetActive(false);
              LapTimeManager.MintCount = 0;
              LapTimeManager.SecCount = 0;
              LapTimeManager.MilliCount = 0;
              */



        }
    }
        void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

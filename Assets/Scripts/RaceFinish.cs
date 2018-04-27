using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class RaceFinish : MonoBehaviour
{
    public GameObject Mycar;
    public GameObject CompleteTrig;
    public GameObject FinishCam;
    public GameObject Cam;
    public GameObject TimerMange;




    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("playercar"))
        {
            Debug.Log("Winner");
            Mycar.SetActive(false);
            CompleteTrig.SetActive(false);  
            CarController.m_Topspeed = 0.0f;
            Mycar.GetComponent<CarController>().enabled = false;
            Mycar.GetComponent<CarUserControl>().enabled = false;
            Mycar.SetActive(true);
           
            FinishCam.SetActive(true);
            Cam.SetActive(false);
            LapTimeManager.MintCount = 0;
            LapTimeManager.SecCount = 0;
            LapTimeManager.MilliCount = 0;
            TimerMange.SetActive(false);
           


        }
        else
        {
            Debug.Log("GameOver");

            Mycar.SetActive(false);
            CompleteTrig.SetActive(false);
            CarController.m_Topspeed = 0.0f;
            Mycar.GetComponent<CarController>().enabled = false;
            Mycar.GetComponent<CarUserControl>().enabled = false;
            LapTimeManager.MintCount = 0;
            LapTimeManager.SecCount = 0;
            LapTimeManager.MilliCount = 0;
            TimerMange.SetActive(false);


            FinishCam.SetActive(true);
            Cam.SetActive(false);



        }

    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}

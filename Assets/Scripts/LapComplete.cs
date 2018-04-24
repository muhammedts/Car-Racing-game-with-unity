using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LapComplete : MonoBehaviour {


    public GameObject LapCompleteTrig;
    public GameObject HalfLapTrig;

    public GameObject MinuteDisplay;
    public GameObject SecDisplay;
    public GameObject MilliDisplay;
    public GameObject LapTimeBox;


    private void OnTriggerEnter(Collider other)
    {
        if(LapTimeManager.SecCount <= 0)
        {
            SecDisplay.GetComponent<Text>().text = "0" + LapTimeManager.SecCount + ".";
        } else
        {

            SecDisplay.GetComponent<Text>().text = "" + LapTimeManager.SecCount + ".";

        }
        if (LapTimeManager.MintCount <= 0)
        {
            MinuteDisplay.GetComponent<Text>().text = "0" + LapTimeManager.MintCount + ".";
        }
        else
        {

            MinuteDisplay.GetComponent<Text>().text = "" + LapTimeManager.MintCount + ".";

        }
        MilliDisplay.GetComponent<Text>().text = "" + LapTimeManager.MilliCount;
        LapTimeManager.MintCount = 0;
        LapTimeManager.SecCount = 0;
        LapTimeManager.MilliCount = 0;
        HalfLapTrig.SetActive(true);
        LapCompleteTrig.SetActive(false);
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LapTimeManager : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }
    public static int MintCount;
    public static int SecCount;
    public static float MilliCount;
    public static string MilliDisplay;

    public GameObject MinuteBox;
    public GameObject SecBox;
    public GameObject MilliBox;


    // Update is called once per frame
    void Update()
    {
        MilliCount += Time.deltaTime * 10;
        MilliDisplay = MilliCount.ToString("F0");
        MilliBox.GetComponent<Text>().text = "" + MilliDisplay;
        if (MilliCount >= 10)
        {
            MilliCount = 0;
            SecCount += 1;
        }
        if (SecCount <= 9)
        {

            SecBox.GetComponent<Text>().text = "0" + SecCount + ".";
        }
        else
        {
            SecBox.GetComponent<Text>().text = "" + SecCount + ".";

        }
        if (SecCount >= 60)
        {
            SecCount = 0;
            MintCount += 1;
        }
        if (MintCount <= 9)
        {

            MinuteBox.GetComponent<Text>().text = "0" + MintCount + ":";

        }
        else
        {
            MinuteBox.GetComponent<Text>().text = "" + MintCount + ":";

        }
    }
}


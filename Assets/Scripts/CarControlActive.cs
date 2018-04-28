using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class CarControlActive : MonoBehaviour
{
   public GameObject CarControl;
    public GameObject AIControl;
    public GameObject AIControl2;
    void Start()
    {
        (CarControl.GetComponent("CarController") as MonoBehaviour).enabled = true;
        (CarControl.GetComponent("CarUserControl") as MonoBehaviour).enabled = true;
        (AIControl.GetComponent("CarAIControl") as MonoBehaviour).enabled = true;
        (AIControl.GetComponent("CarController") as MonoBehaviour).enabled = true;
        (AIControl2.GetComponent("CarAIControl") as MonoBehaviour).enabled = true;
        (AIControl2.GetComponent("CarController") as MonoBehaviour).enabled = true;




    }
}

    
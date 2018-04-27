using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LappTimeStart : MonoBehaviour {

    public GameObject TimeMManger;
    private void OnTriggerEnter(Collider other)
    {
        TimeMManger.SetActive(true);
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

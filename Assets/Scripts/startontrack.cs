using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startontrack : MonoBehaviour {

    public GameObject RaceFinishTrack;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("akjhasjdw");
        RaceFinishTrack.SetActive(true);

    }


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}





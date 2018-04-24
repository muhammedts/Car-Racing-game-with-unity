using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIcar : MonoBehaviour {
    public GameObject themarker;
    public GameObject mark1;
    public GameObject mark2;
    public GameObject mark3;
    public GameObject mark4;
    public GameObject mark5;
    public GameObject mark6;
    public GameObject mark7;
    public GameObject mark8;
    public GameObject mark9;
    public GameObject mark10;

    public int marktracker;
    // Use this for initialization
    
	
	// Update is called once per frame
	void Update () {
      
        if (marktracker == 0)
        {
            themarker.transform.position = mark1.transform.position;
        }
        if (marktracker == 1)
        {
            themarker.transform.position = mark2.transform.position;
        }
        if (marktracker == 2)
        {
            themarker.transform.position = mark3.transform.position;

        }
        if (marktracker == 3)
        {
            themarker.transform.position = mark4.transform.position;
        }
        if (marktracker == 4)
        {
            themarker.transform.position = mark5.transform.position;
        }
        if (marktracker == 5)
        {
            themarker.transform.position = mark6.transform.position;
        }
        if (marktracker == 6)
        {
            themarker.transform.position = mark7.transform.position;
        }
        if (marktracker == 7)
        {
            themarker.transform.position = mark8.transform.position;
        }
        if (marktracker == 8)
        {
            themarker.transform.position = mark9.transform.position;
        }
        if (marktracker == 9)
        {
            themarker.transform.position = mark10.transform.position;

        }



    }
    IEnumerator OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "AIcar")
        {
            this.GetComponent<BoxCollider>().enabled = false;
            marktracker += 1;
            if (marktracker == 21)
            {
                marktracker = 0;
            }
            yield return new WaitForSeconds(1);
            this.GetComponent<BoxCollider>().enabled = true;
        }
    }
}

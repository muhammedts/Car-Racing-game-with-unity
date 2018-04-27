using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIcartrack : MonoBehaviour {

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
    public GameObject mark11;
    public GameObject mark12;
    public GameObject mark13;
    public GameObject mark14;
    public GameObject mark15;
    public GameObject mark16;
    public GameObject mark17;
    public GameObject mark18;
    public GameObject mark19;
  

    public int marktracker;
    // Use this for initialization


    // Update is called once per frame
    void Update()
    {

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
        if (marktracker == 10)
        {
            themarker.transform.position = mark11.transform.position;
        }
        if (marktracker == 11)
        {
            themarker.transform.position = mark12.transform.position;
        }
        if (marktracker == 12)
        {
            themarker.transform.position = mark13.transform.position;
        }
        if (marktracker == 13)
        {
            themarker.transform.position = mark14.transform.position;
        }
        if (marktracker == 14)
        {
            themarker.transform.position = mark15.transform.position;
        }
        if (marktracker == 15)
        {
            themarker.transform.position = mark16.transform.position;
        }
        if (marktracker == 16)
        {
            themarker.transform.position = mark17.transform.position;
        }
        if (marktracker == 17)
        {
            themarker.transform.position = mark18.transform.position;
        }
        if (marktracker == 18)
        {
            themarker.transform.position = mark19.transform.position;
        }
       


    }
    IEnumerator OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "AIcar")
        {
            this.GetComponent<BoxCollider>().enabled = false;
            marktracker += 1;
          
            yield return new WaitForSeconds(1);
            this.GetComponent<BoxCollider>().enabled = true;
        }
    }
}

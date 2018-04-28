using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AICar2 : MonoBehaviour {

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
    public GameObject mark20;
    public GameObject mark21;
    public GameObject mark22;
    public GameObject mark23;
    public GameObject mark24;
    public GameObject mark25;
    public GameObject mark26;
    public GameObject mark27;
    public GameObject mark28;
    public GameObject mark29;
    public GameObject mark30;
    public GameObject mark31;
    public GameObject mark32;

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
        if (marktracker == 19)
        {
            themarker.transform.position = mark20.transform.position;
        }
        if (marktracker == 20)
        {
            themarker.transform.position = mark21.transform.position;
        }
        if (marktracker == 21)
        {
            themarker.transform.position = mark22.transform.position;
        }
        if (marktracker == 22)
        {
            themarker.transform.position = mark23.transform.position;
        }
        if (marktracker == 23)
        {
            themarker.transform.position = mark24.transform.position;

        }
        if (marktracker == 24)
        {
            themarker.transform.position = mark25.transform.position;
        }
        if (marktracker == 25)
        {
            themarker.transform.position = mark26.transform.position;
        }
        if (marktracker == 26)
        {
            themarker.transform.position = mark27.transform.position;
        }
        if (marktracker == 27)
        {
            themarker.transform.position = mark28.transform.position;
        }
        if (marktracker == 28)
        {
            themarker.transform.position = mark29.transform.position;
        }
        if (marktracker == 29)
        {
            themarker.transform.position = mark30.transform.position;
        }
        if (marktracker == 30)
        {
            themarker.transform.position = mark31.transform.position;
        }
        if (marktracker == 31)
        {
            themarker.transform.position = mark32.transform.position;
        }



    }
    IEnumerator OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "AIsecondcar")
        {
            this.GetComponent<BoxCollider>().enabled = false;
            marktracker += 1;
            if (marktracker == 32)
            {
                marktracker = 0;
            }
            yield return new WaitForSeconds(1);
            this.GetComponent<BoxCollider>().enabled = true;
        }
    }
}

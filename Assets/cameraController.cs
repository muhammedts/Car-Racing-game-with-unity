using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour
{
    public GameObject SpikeBall;
    private Vector3 offset;


    // Use this for initialization
    void Start()
    {
        offset = transform.position - SpikeBall.transform.position;

    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = SpikeBall.transform.position + offset;

    }
}

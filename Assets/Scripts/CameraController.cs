using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{

    public GameObject player;

    public float carx;
    public float cary;
    public float carz;

    void Update()
    {
        carx = player.transform.eulerAngles.x;
        cary = player.transform.eulerAngles.y;
        carz = player.transform.eulerAngles.z;
        transform.eulerAngles = new Vector3(carx - carx,cary, carz - carz);
    }
}   
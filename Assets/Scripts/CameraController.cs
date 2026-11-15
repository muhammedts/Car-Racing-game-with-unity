using UnityEngine;

/// <summary>Keeps the camera facing the car's heading while staying level.</summary>
public class CameraController : MonoBehaviour
{
    public GameObject player;

    private void Update()
    {
        transform.eulerAngles = new Vector3(0, player.transform.eulerAngles.y, 0);
    }
}

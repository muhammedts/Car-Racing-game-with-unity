using UnityEngine;

/// <summary>Spins the object slowly around the vertical axis.</summary>
public class FinishRotate : MonoBehaviour
{
    private void Update()
    {
        transform.Rotate(0, 1, 0, Space.World);
    }
}

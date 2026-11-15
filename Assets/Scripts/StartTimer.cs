using UnityEngine;

/// <summary>Starts the lap timer when a car drives through this trigger.</summary>
public class StartTimer : MonoBehaviour
{
    public GameObject Timer;

    private void OnTriggerEnter(Collider other)
    {
        Timer.SetActive(true);
    }
}

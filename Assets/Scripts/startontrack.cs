using UnityEngine;

/// <summary>Arms the race finish line when a car drives through this trigger.</summary>
public class startontrack : MonoBehaviour
{
    public GameObject RaceFinishTrack;

    private void OnTriggerEnter(Collider other)
    {
        RaceFinishTrack.SetActive(true);
    }
}

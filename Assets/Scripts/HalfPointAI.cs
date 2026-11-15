using UnityEngine;

/// <summary>
/// Half-way checkpoint for the car tagged "AIcar". Passing it arms the finish line,
/// so a lap only counts after driving the whole track.
/// </summary>
public class HalfPointAI : MonoBehaviour
{
    public GameObject LapCompleteTrigAI;
    public GameObject HalfLapTrigAI;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("AIcar"))
        {
            LapCompleteTrigAI.SetActive(true);
            HalfLapTrigAI.SetActive(false);
        }
    }
}

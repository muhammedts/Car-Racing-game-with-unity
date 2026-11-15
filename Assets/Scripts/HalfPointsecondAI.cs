using UnityEngine;

/// <summary>
/// Half-way checkpoint for the car tagged "AIsecondcar". Passing it arms the finish line,
/// so a lap only counts after driving the whole track.
/// </summary>
public class HalfPointsecondAI : MonoBehaviour
{
    public GameObject LapCompleteTrigsecondAI;
    public GameObject HalfLapTrigsecondAI;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("AIsecondcar"))
        {
            LapCompleteTrigsecondAI.SetActive(true);
            HalfLapTrigsecondAI.SetActive(false);
        }
    }
}

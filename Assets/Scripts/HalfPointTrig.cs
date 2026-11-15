using UnityEngine;

/// <summary>
/// Half-way checkpoint for the car tagged "playercar". Passing it arms the finish line,
/// so a lap only counts after driving the whole track.
/// </summary>
public class HalfPointTrig : MonoBehaviour
{
    public GameObject LapCompleteTrig;
    public GameObject HalfLapTrig;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("playercar"))
        {
            LapCompleteTrig.SetActive(true);
            HalfLapTrig.SetActive(false);
        }
    }
}

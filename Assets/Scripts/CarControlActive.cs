using UnityEngine;

/// <summary>
/// Enabled when the countdown ends: switches on the player's car controls and the AI drivers.
/// AIControl2 is only set on the town track, which has a second AI car.
/// </summary>
public class CarControlActive : MonoBehaviour
{
    public GameObject CarControl;
    public GameObject AIControl;
    public GameObject AIControl2;

    private void Start()
    {
        Enable(CarControl, "CarController");
        Enable(CarControl, "CarUserControl");
        Enable(AIControl, "CarAIControl");
        Enable(AIControl, "CarController");

        if (AIControl2 != null)
        {
            Enable(AIControl2, "CarAIControl");
            Enable(AIControl2, "CarController");
        }
    }

    private static void Enable(GameObject car, string component)
    {
        ((MonoBehaviour)car.GetComponent(component)).enabled = true;
    }
}

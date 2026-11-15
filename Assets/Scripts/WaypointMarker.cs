using System.Collections;
using UnityEngine;

/// <summary>
/// Moves a target marker along a chain of waypoints for an AI car to chase.
///
/// The marker object carries a trigger collider. Each time the AI car with the matching tag drives
/// into it, the marker jumps to the next waypoint. The Standard Assets CarAIControl on the car
/// steers towards the marker, so the car follows the track.
///
/// Subclasses only list their waypoints. They keep their own public mark1..markN fields because
/// the scenes reference those fields by name.
/// </summary>
public abstract class WaypointMarker : MonoBehaviour
{
    // Seconds the trigger stays off after a hit, so one pass does not count twice.
    private const float RetriggerDelay = 1f;

    public GameObject themarker;
    public int marktracker;

    private GameObject[] waypoints;
    private BoxCollider trigger;

    /// <summary>Tag of the AI car that drives this marker.</summary>
    protected abstract string CarTag { get; }

    /// <summary>Whether the marker returns to the first waypoint after the last one.</summary>
    protected abstract bool Loops { get; }

    /// <summary>The waypoints in driving order.</summary>
    protected abstract GameObject[] Waypoints();

    protected virtual void Awake()
    {
        waypoints = Waypoints();
        trigger = GetComponent<BoxCollider>();
    }

    protected virtual void Update()
    {
        if (marktracker >= 0 && marktracker < waypoints.Length)
        {
            themarker.transform.position = waypoints[marktracker].transform.position;
        }
    }

    protected IEnumerator OnTriggerEnter(Collider other)
    {
        if (!other.gameObject.CompareTag(CarTag))
        {
            yield break;
        }

        trigger.enabled = false;
        marktracker += 1;
        if (Loops && marktracker >= waypoints.Length)
        {
            marktracker = 0;
        }

        yield return new WaitForSeconds(RetriggerDelay);
        trigger.enabled = true;
    }
}

using UnityEngine;

/// <summary>Waypoints for the AI car on the smaller track ("Track" scene). Stops at the last waypoint.</summary>
public class AIcartrack : WaypointMarker
{
    public GameObject mark1;
    public GameObject mark2;
    public GameObject mark3;
    public GameObject mark4;
    public GameObject mark5;
    public GameObject mark6;
    public GameObject mark7;
    public GameObject mark8;
    public GameObject mark9;
    public GameObject mark10;
    public GameObject mark11;
    public GameObject mark12;
    public GameObject mark13;
    public GameObject mark14;
    public GameObject mark15;
    public GameObject mark16;
    public GameObject mark17;
    public GameObject mark18;
    public GameObject mark19;

    protected override string CarTag
    {
        get { return "AIcar"; }
    }

    protected override bool Loops
    {
        get { return false; }
    }

    protected override GameObject[] Waypoints()
    {
        return new[]
        {
            mark1,
            mark2,
            mark3,
            mark4,
            mark5,
            mark6,
            mark7,
            mark8,
            mark9,
            mark10,
            mark11,
            mark12,
            mark13,
            mark14,
            mark15,
            mark16,
            mark17,
            mark18,
            mark19
        };
    }
}

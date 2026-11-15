using UnityEngine;

/// <summary>Waypoints for the first AI car on the town track ("road asmaa and moaaz" scene).</summary>
public class AIcar : WaypointMarker
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
    public GameObject mark20;
    public GameObject mark21;
    public GameObject mark22;
    public GameObject mark23;
    public GameObject mark24;
    public GameObject mark25;
    public GameObject mark26;
    public GameObject mark27;
    public GameObject mark28;
    public GameObject mark29;
    public GameObject mark30;
    public GameObject mark31;
    public GameObject mark32;

    protected override string CarTag
    {
        get { return "AIcar"; }
    }

    protected override bool Loops
    {
        get { return true; }
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
            mark19,
            mark20,
            mark21,
            mark22,
            mark23,
            mark24,
            mark25,
            mark26,
            mark27,
            mark28,
            mark29,
            mark30,
            mark31,
            mark32
        };
    }
}

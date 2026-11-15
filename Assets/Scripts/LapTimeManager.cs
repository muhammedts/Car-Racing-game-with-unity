using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Runs the on-screen lap timer, shown as mm:ss.t.
/// The counters are static so the lap and finish triggers can read and reset them.
/// </summary>
public class LapTimeManager : MonoBehaviour
{
    public static int MintCount;
    public static int SecCount;
    public static float MilliCount; // tenths of a second, 0-9
    public static string MilliDisplay;

    public GameObject MinuteBox;
    public GameObject SecBox;
    public GameObject MilliBox;

    private Text minuteText;
    private Text secText;
    private Text milliText;

    public static void ResetClock()
    {
        MintCount = 0;
        SecCount = 0;
        MilliCount = 0;
    }

    public static string FormatMinutes(int minutes)
    {
        return minutes.ToString("00") + ":";
    }

    public static string FormatSeconds(int seconds)
    {
        return seconds.ToString("00") + ".";
    }

    public static string FormatTenths(float tenths)
    {
        return Mathf.FloorToInt(tenths).ToString();
    }

    private void Start()
    {
        minuteText = MinuteBox.GetComponent<Text>();
        secText = SecBox.GetComponent<Text>();
        milliText = MilliBox.GetComponent<Text>();
    }

    private void Update()
    {
        MilliCount += Time.deltaTime * 10;
        if (MilliCount >= 10)
        {
            MilliCount -= 10;
            SecCount += 1;
        }
        if (SecCount >= 60)
        {
            SecCount = 0;
            MintCount += 1;
        }

        MilliDisplay = FormatTenths(MilliCount);
        milliText.text = MilliDisplay;
        secText.text = FormatSeconds(SecCount);
        minuteText.text = FormatMinutes(MintCount);
    }
}

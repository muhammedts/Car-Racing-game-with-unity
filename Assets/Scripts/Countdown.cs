using System.Collections;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// "3, 2, 1, GO" countdown at the start of a race. Starts the lap timer and
/// hands control to the cars when it finishes.
/// </summary>
public class Countdown : MonoBehaviour
{
    public GameObject CountDown;
    public AudioSource GetReady;
    public AudioSource GoAudio;
    public GameObject LapTimer;
    public GameObject CarControls;

    private void Start()
    {
        StartCoroutine(CountStart());
    }

    private IEnumerator CountStart()
    {
        Text label = CountDown.GetComponent<Text>();
        yield return new WaitForSeconds(0.5f);

        for (int count = 3; count >= 1; count--)
        {
            label.text = count.ToString();
            GetReady.Play();
            CountDown.SetActive(true);
            yield return new WaitForSeconds(1);
            CountDown.SetActive(false);
        }

        GoAudio.Play();
        LapTimer.SetActive(true);
        CarControls.SetActive(true);
    }
}

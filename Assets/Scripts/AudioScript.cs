using UnityEngine;
using UnityEngine.UI;

/// <summary>Plays the menu music and binds its volume to the settings slider.</summary>
public class AudioScript : MonoBehaviour
{
    public AudioClip MusicClip;
    public AudioSource MusicSource;
    public Slider Volume;

    private void Start()
    {
        MusicSource.volume = Volume.value;
        Volume.onValueChanged.AddListener(value => MusicSource.volume = value);

        // No music ships with the project; assign a royalty-free track in the Inspector.
        if (MusicClip != null)
        {
            MusicSource.clip = MusicClip;
            MusicSource.Play();
        }
    }
}

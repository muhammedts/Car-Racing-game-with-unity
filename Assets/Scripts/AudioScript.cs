using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioScript : MonoBehaviour {
    public AudioClip MusicClip;
    public AudioSource MusicSource;
    public Slider Volume;
	// Use this for initialization
	void Start () {
        MusicSource.clip = MusicClip;
        MusicSource.Play();
	}
	
	// Update is called once per frame
	void Update () {
        MusicSource.volume = Volume.value;
	}
}

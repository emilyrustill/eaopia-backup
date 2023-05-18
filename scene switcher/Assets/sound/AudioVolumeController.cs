using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AudioVolumeController : MonoBehaviour

{
      public Slider volumeSlider;

    private AudioSource audioSource;

    private void Start()
    {
        // Get the AudioSource component attached to the GameObject containing the Slider
        audioSource = GetComponent<AudioSource>();

        // Initialize the slider value to match the audio source volume
        volumeSlider.value = audioSource.volume;
    }

    public void OnVolumeChanged(float volume)
    {
        audioSource.volume = volume;
    }
}


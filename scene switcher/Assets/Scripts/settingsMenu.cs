using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;


public class settingsMenu : MonoBehaviour {

    public AudioMixer audioMixer;

    public void SetMusic (float music)
  {
     audioMixer.SetFloat("Volume", music);
  }

}

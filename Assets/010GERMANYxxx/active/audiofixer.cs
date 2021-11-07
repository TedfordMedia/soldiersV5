using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class audiofixer : MonoBehaviour
{
    public AudioMixer mixer;

    public void SetLevel(float sliderValue)
    {
        Debug.Log("set level sliderValue:" + Mathf.Log10(sliderValue) * 20);
        mixer.SetFloat("MasterVolume", Mathf.Log10(sliderValue) * 20);
    }
}

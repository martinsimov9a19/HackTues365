using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeContoller : MonoBehaviour
{

    public AudioSource audio;
    public Slider slider;

    
    void Update()
    {
        if (slider.value >= 0) {
            audio.volume = slider.value;
        }
    }
}

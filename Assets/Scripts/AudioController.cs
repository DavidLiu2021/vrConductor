using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Volume control for different audio clip
/// </summary>
public class AudioController : MonoBehaviour
{
    public AudioSource audioSource;
    public Slider volumeSlider;
    // Start is called before the first frame update
    void Start()
    {
        volumeSlider.value = audioSource.volume;
        volumeSlider.onValueChanged.AddListener(OnVolumeChange);
    }
    void OnVolumeChange(float value)
    {
        audioSource.volume = value;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

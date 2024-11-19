using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeDebugUI : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private Text volumeText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float volume = audioSource.volume;
        volumeText.text = $"{volume:P0}";
    }
}

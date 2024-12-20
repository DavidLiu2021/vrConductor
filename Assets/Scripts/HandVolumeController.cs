using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using UnityEngine.XR.Interaction.Toolkit;

public class HandVolumeController : MonoBehaviour
{
    [Header("Audio Settings")]
    [SerializeField] private AudioSource audioSource;

    [Header("Hand Settings")]
    [SerializeField] private Transform minPosition;
    [SerializeField] private Transform maxPosition;

    private bool isHandInside = false;
    private Transform handTransform;
    private float initialHandPosition;
    private float currentVolume;
    private float previousHandY;



    // Start is called before the first frame update
    void Start()
    {
        // audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other){
        if (other.CompareTag("VRhand")){
            isHandInside = true;

            handTransform = other.transform;
            // initialHandPosition = handTransform.position.y;
            previousHandY = handTransform.position.y;
            currentVolume = audioSource.volume;
        }
    }

    private void OnTriggerExit(Collider other){
        if (other.CompareTag("VRhand")){
            isHandInside = false;
            handTransform = null;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (isHandInside && handTransform != null){
            // float handY = handTransform.position.y;
            // float normalizedYPosition = Mathf.InverseLerp(minPosition.position.y, maxPosition.position.y, handY);

            // float newVolume;
            // if (handY - initialHandPosition < 0){
            //     newVolume = Mathf.Lerp(currentVolume, 0f, normalizedYPosition);
            // }else{
            //     newVolume = Mathf.Lerp(currentVolume, 1f, normalizedYPosition);
            // }
            // newVolume = Mathf.Clamp01(newVolume);
            // audioSource.volume = newVolume;
            float currentHandY = handTransform.position.y;
            float deltaY = currentHandY - previousHandY;
            float newVolume = audioSource.volume + deltaY;

            audioSource.volume = Mathf.Clamp01(newVolume);

            previousHandY = currentHandY;

        }
    }
}

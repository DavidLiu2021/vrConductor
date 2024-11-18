using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using UnityEngine.XR.Interaction.Toolkit;

public class HandVolumeController : MonoBehaviour
{
    [Header("Audio Settings")]
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private float minVolume = 0f;
    [SerializeField] private float maxVolume = 1f;

    [Header("Hand Settings")]
    [SerializeField] private float minYPosition = 0f;
    [SerializeField] private float maxYPosition = 1f;

    private bool isHandInside = false;
    private Transform handTransform;
    private float initialHandPosition;


    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other){
        if (other.CompareTag("VRhand")){
            isHandInside = true;
            handTransform = other.transform;
            initialHandPosition = handTransform.position.y;
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
        if (isHandInside){
            float normalizedYPosition = Mathf.InverseLerp(minYPosition, maxYPosition, handTransform.position.y);
            float newVolume = Mathf.Lerp(minVolume, maxVolume, normalizedYPosition);
            audioSource.volume = newVolume;
        }
    }

    private void OnDrawGizmos(){
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireCube(handTransform.position, transform.localScale);
    }
}

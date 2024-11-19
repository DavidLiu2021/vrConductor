using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using UnityEngine.XR.Interaction.Toolkit;

public class HandVolumeController : MonoBehaviour
{
    [Header("Audio Settings")]
    [SerializeField] private AudioSource audioSource;
    // [SerializeField] private float minVolume = 0f;
    // [SerializeField] private float maxVolume = 1f;

    [Header("Hand Settings")]
    // [SerializeField] private Trasnform LeftHand;
    [SerializeField] private Transform minPosition;
    [SerializeField] private Transform maxPosition;

    private bool isHandInside = false;
    private Transform handTransform;
    // private float initialHandPosition;
    // private float minYPosition = 0f;
    // private float maxYPosition = 1f;


    // Start is called before the first frame update
    void Start()
    {
        // audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other){
        if (other.CompareTag("VRhand")){
            isHandInside = true;
            handTransform = other.transform;
            // initialHandPosition = other.transform.position.y;
            Debug.Log("Hand inside");
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
            Debug.Log("Hand inside");
            float handY = handTransform.position.y;
            float normalizedYPosition = Mathf.InverseLerp(minPosition.position.y, maxPosition.position.y, handY);

            float newVolume = Mathf.Lerp(0f, 1f, normalizedYPosition);
            audioSource.volume = newVolume;
        }
    }

    // private void OnDrawGizmos(){
    //     Gizmos.color = Color.yellow;
    //     Gizmos.DrawWireCube(handTransform.position, transform.localScale);
    // }
}

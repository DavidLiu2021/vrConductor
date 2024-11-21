using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighlightOnEnter : MonoBehaviour
{
    [SerializeField] private Material highlightMaterial;

    private Material defaultMaterial;
    private Renderer cubeRenderer;

    
    // Start is called before the first frame update
    void Start()
    {
        cubeRenderer = GetComponent<Renderer>();
        defaultMaterial = cubeRenderer.material;
    }


    private void OnTriggerEnter(Collider other){
        if (other.CompareTag("VRhand")){
            cubeRenderer.material = highlightMaterial;
        }
    }

    private void OnTriggerExit(Collider other){
        if (other.CompareTag("VRhand")){
            cubeRenderer.material = defaultMaterial;
        }
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}

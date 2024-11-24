using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LibrarySelect : MonoBehaviour
{
    [SerializeField] private GameObject Detail01;
    [SerializeField] private GameObject Detail02;
    
    public void ClickMusic(){
        Detail01.SetActive(false);
        Detail02.SetActive(true);
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiddleTableReset : MonoBehaviour
{
    [SerializeField] private GameObject HomePage;
    [SerializeField] private GameObject Library;    
    // Start is called before the first frame update
    void Start()
    {
        HomePage.SetActive(true);
        Library.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

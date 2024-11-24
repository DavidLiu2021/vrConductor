using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModeContinue : MonoBehaviour
{
    [SerializeField] private GameObject Screen01;
    [SerializeField] private GameObject Screen02;
    [SerializeField] private GameObject ThumbUp;
    
    public void ClickStart(){
        Screen01.SetActive(false);
        Screen02.SetActive(true);
    }

    public void ClickGotIt(){
        Screen02.SetActive(false);
        ThumbUp.SetActive(true);
    }
    
    // Start is called before the first frame update
    void Start()
    {
        Screen01.SetActive(true);
        Screen02.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
